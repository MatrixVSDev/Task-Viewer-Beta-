using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        private ListView listViewTasks; // Добавлено объявление поля

        public Form1()
        {
            InitializeComponent();

            // Подпишемся на событие загрузки формы
            this.Load += Form1_Load;

            // Инициализация listViewTasks, если не добавлен через дизайнер
            if (listViewTasks == null)
            {
                listViewTasks = new ListView
                {
                    Dock = DockStyle.Fill,
                    View = View.Details,
                    FullRowSelect = true
                };
                Controls.Add(listViewTasks);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Вызываем обновление списка процессов при старте приложения
            await UpdateProcessListAsync();
        }

        private async Task UpdateProcessListAsync()
        {
            // Получаем список процессов и всех экземпляров категории "Process"
            var processes = Process.GetProcesses();
            PerformanceCounterCategory category = null;
            string[] instances = new string[0];
            try
            {
                category = new PerformanceCounterCategory("Process");
                instances = category.GetInstanceNames();
            }
            catch
            {
                // Невозможно получить экземпляры — продолжим с пустым набором
            }

            // Сопоставляем имя экземпляра -> PID через счётчик "ID Process"
            var instanceToPid = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            foreach (var inst in instances)
            {
                try
                {
                    using (var pcId = new PerformanceCounter("Process", "ID Process", inst, true))
                    {
                        // RawValue безопасен для идентификатора процесса
                        int pid = (int)pcId.RawValue;
                        if (pid > 0 && !instanceToPid.ContainsKey(inst))
                            instanceToPid[inst] = pid;
                    }
                }
                catch
                {
                    // Игнорируем экземпляры, на которые нет доступа
                }
            }

            // Создаём счётчики % Processor Time для найденных процессов (один проход - первичное значение)
            var counterEntries = new List<(Process Proc, PerformanceCounter Counter, int Pid)>();
            foreach (var proc in processes)
            {
                try
                {
                    var inst = instanceToPid.FirstOrDefault(kv => kv.Value == proc.Id).Key;
                    if (string.IsNullOrEmpty(inst))
                        continue;

                    var pc = new PerformanceCounter("Process", "% Processor Time", inst, true);
                    pc.NextValue(); // первый вызов для инициализации
                    counterEntries.Add((proc, pc, proc.Id));
                }
                catch
                {
                    // Процесс мог завершиться или доступ запрещён — пропускаем
                }
            }

            // Ждём между снятиями значений (не блокируя UI)
            await Task.Delay(500).ConfigureAwait(false);

            // Собираем элементы ListView
            var items = new List<ListViewItem>();
            int processorCount = Environment.ProcessorCount;
            foreach (var e in counterEntries)
            {
                float cpuPercent = 0f;
                try
                {
                    cpuPercent = e.Counter.NextValue() / processorCount;
                    if (cpuPercent < 0) cpuPercent = 0f;
                }
                catch
                {
                    cpuPercent = 0f;
                }
                finally
                {
                    e.Counter.Dispose();
                }

                string name = e.Proc?.ProcessName ?? "";
                string pidStr = e.Pid.ToString();
                string cpuStr = cpuPercent.ToString("F1", System.Globalization.CultureInfo.CurrentCulture) + " %";

                var lvi = new ListViewItem(new[] { name, pidStr, cpuStr });
                items.Add(lvi);
            }

            // Обновляем UI безопасно (Invoke при необходимости)
            Action updateUi = () =>
            {
                listViewTasks.BeginUpdate();
                try
                {
                    // Настраиваем колонки
                    listViewTasks.Columns.Clear();
                    listViewTasks.Columns.Add("Имя процесса", 220);
                    listViewTasks.Columns.Add("ID", 80);
                    listViewTasks.Columns.Add("Процент использования CPU", 160);

                    listViewTasks.Items.Clear();
                    if (items.Count > 0)
                        listViewTasks.Items.AddRange(items.ToArray());
                }
                finally
                {
                    listViewTasks.EndUpdate();
                }
            };

            if (listViewTasks.InvokeRequired)
                listViewTasks.Invoke(updateUi);
            else
                updateUi();
        }

        private void видToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void byMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void httpsgithubcomMatrixVSDevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ваша ссылка, которую нужно открыть в браузере
            string githubUrl = "https://github.com/MatrixVSDev";

            try
            {
                // КЛЮЧЕВАЯ команда: Запускает ссылку через браузер по умолчанию
                System.Diagnostics.Process.Start(githubUrl);
            }
            catch (Exception)
            {
                // Ошибка обрабатывается "тихо" (без сообщений), как вы и просили.
            }
        }
    }
}