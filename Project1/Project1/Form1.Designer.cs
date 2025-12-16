namespace Project1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewTask = new System.Windows.Forms.ListView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.httpsgithubcomMatrixVSDevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewTask
            // 
            this.listViewTask.HideSelection = false;
            this.listViewTask.Location = new System.Drawing.Point(450, 442);
            this.listViewTask.Name = "listViewTask";
            this.listViewTask.Size = new System.Drawing.Size(10, 10);
            this.listViewTask.TabIndex = 1;
            this.listViewTask.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(453, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.helpToolStripMenuItem.Text = "help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskViewerToolStripMenuItem,
            this.byMatrixToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // taskViewerToolStripMenuItem
            // 
            this.taskViewerToolStripMenuItem.Name = "taskViewerToolStripMenuItem";
            this.taskViewerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.taskViewerToolStripMenuItem.Text = "Version:0.1 Beta";
            // 
            // byMatrixToolStripMenuItem
            // 
            this.byMatrixToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.httpsgithubcomMatrixVSDevToolStripMenuItem});
            this.byMatrixToolStripMenuItem.Name = "byMatrixToolStripMenuItem";
            this.byMatrixToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byMatrixToolStripMenuItem.Text = "by MatrixVSDev";
            this.byMatrixToolStripMenuItem.Click += new System.EventHandler(this.byMatrixToolStripMenuItem_Click);
            // 
            // httpsgithubcomMatrixVSDevToolStripMenuItem
            // 
            this.httpsgithubcomMatrixVSDevToolStripMenuItem.Name = "httpsgithubcomMatrixVSDevToolStripMenuItem";
            this.httpsgithubcomMatrixVSDevToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.httpsgithubcomMatrixVSDevToolStripMenuItem.Text = "https://github.com/MatrixVSDev";
            this.httpsgithubcomMatrixVSDevToolStripMenuItem.Click += new System.EventHandler(this.httpsgithubcomMatrixVSDevToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.listViewTask);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Task Viewer Beta 0.1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTask;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem httpsgithubcomMatrixVSDevToolStripMenuItem;
    }
}