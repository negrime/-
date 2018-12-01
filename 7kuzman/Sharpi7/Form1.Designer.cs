namespace Sharpi7
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Task = new System.Windows.Forms.Button();
            this.deleteStudent = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(48, 72);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(472, 304);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(45, 384);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(149, 32);
            this.buttonChange.TabIndex = 17;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Visible = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Список студентов";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(207, 384);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 32);
            this.button4.TabIndex = 34;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Task
            // 
            this.Task.Location = new System.Drawing.Point(171, 435);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(219, 45);
            this.Task.TabIndex = 42;
            this.Task.Text = "Задание";
            this.Task.UseVisualStyleBackColor = true;
            this.Task.Visible = false;
            this.Task.Click += new System.EventHandler(this.Task_Click);
            // 
            // deleteStudent
            // 
            this.deleteStudent.Location = new System.Drawing.Point(370, 384);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(150, 32);
            this.deleteStudent.TabIndex = 43;
            this.deleteStudent.Text = "Удалить";
            this.deleteStudent.UseVisualStyleBackColor = true;
            this.deleteStudent.Visible = false;
            this.deleteStudent.Click += new System.EventHandler(this.button8_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 29);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изTxtToolStripMenuItem,
            this.изXmlToolStripMenuItem,
            this.изBinToolStripMenuItem});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // изTxtToolStripMenuItem
            // 
            this.изTxtToolStripMenuItem.Name = "изTxtToolStripMenuItem";
            this.изTxtToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.изTxtToolStripMenuItem.Text = "из txt";
            this.изTxtToolStripMenuItem.Click += new System.EventHandler(this.изTxtToolStripMenuItem_Click);
            // 
            // изXmlToolStripMenuItem
            // 
            this.изXmlToolStripMenuItem.Name = "изXmlToolStripMenuItem";
            this.изXmlToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.изXmlToolStripMenuItem.Text = "из xml";
            this.изXmlToolStripMenuItem.Click += new System.EventHandler(this.изXmlToolStripMenuItem_Click);
            // 
            // изBinToolStripMenuItem
            // 
            this.изBinToolStripMenuItem.Name = "изBinToolStripMenuItem";
            this.изBinToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.изBinToolStripMenuItem.Text = "из bin";
            this.изBinToolStripMenuItem.Click += new System.EventHandler(this.изBinToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вTxtToolStripMenuItem,
            this.вToolStripMenuItem,
            this.ыToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // вTxtToolStripMenuItem
            // 
            this.вTxtToolStripMenuItem.Name = "вTxtToolStripMenuItem";
            this.вTxtToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.вTxtToolStripMenuItem.Text = "в txt";
            this.вTxtToolStripMenuItem.Click += new System.EventHandler(this.вTxtToolStripMenuItem_Click);
            // 
            // вToolStripMenuItem
            // 
            this.вToolStripMenuItem.Name = "вToolStripMenuItem";
            this.вToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.вToolStripMenuItem.Text = "в xml";
            this.вToolStripMenuItem.Click += new System.EventHandler(this.вToolStripMenuItem_Click);
            // 
            // ыToolStripMenuItem
            // 
            this.ыToolStripMenuItem.Name = "ыToolStripMenuItem";
            this.ыToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.ыToolStripMenuItem.Text = "в bin";
            this.ыToolStripMenuItem.Click += new System.EventHandler(this.ыToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 511);
            this.Controls.Add(this.deleteStudent);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Task;
        private System.Windows.Forms.Button deleteStudent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ыToolStripMenuItem;
    }
}

