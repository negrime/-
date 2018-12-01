namespace _6
{
    partial class FMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.условиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ListStudents = new System.Windows.Forms.ListBox();
            this.listBoxSubjects = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.работаСоСтудентомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.заданиеToolStripMenuItem,
            this.работаСоСтудентомToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1240, 44);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.SaveAsMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(324, 38);
            this.OpenMenuItem.Text = "Открыть...";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.SaveBinToolStripMenuItem,
            this.SaveTxtToolStripMenuItem});
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.Size = new System.Drawing.Size(324, 38);
            this.SaveAsMenuItem.Text = "Сохранить как ";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(231, 38);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // SaveBinToolStripMenuItem
            // 
            this.SaveBinToolStripMenuItem.Name = "SaveBinToolStripMenuItem";
            this.SaveBinToolStripMenuItem.Size = new System.Drawing.Size(231, 38);
            this.SaveBinToolStripMenuItem.Text = "Бинарный";
            this.SaveBinToolStripMenuItem.Click += new System.EventHandler(this.SaveBinToolStripMenuItem_Click);
            // 
            // SaveTxtToolStripMenuItem
            // 
            this.SaveTxtToolStripMenuItem.Name = "SaveTxtToolStripMenuItem";
            this.SaveTxtToolStripMenuItem.Size = new System.Drawing.Size(231, 38);
            this.SaveTxtToolStripMenuItem.Text = "Текстовый";
            this.SaveTxtToolStripMenuItem.Click += new System.EventHandler(this.SaveTxtToolStripMenuItem_Click);
            // 
            // заданиеToolStripMenuItem
            // 
            this.заданиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.условиеToolStripMenuItem,
            this.выполнитьToolStripMenuItem});
            this.заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            this.заданиеToolStripMenuItem.Size = new System.Drawing.Size(118, 36);
            this.заданиеToolStripMenuItem.Text = "Задание";
            this.заданиеToolStripMenuItem.Click += new System.EventHandler(this.заданиеToolStripMenuItem_Click);
            // 
            // условиеToolStripMenuItem
            // 
            this.условиеToolStripMenuItem.Name = "условиеToolStripMenuItem";
            this.условиеToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.условиеToolStripMenuItem.Text = "Условие";
            this.условиеToolStripMenuItem.Click += new System.EventHandler(this.условиеToolStripMenuItem_Click);
            // 
            // выполнитьToolStripMenuItem
            // 
            this.выполнитьToolStripMenuItem.Name = "выполнитьToolStripMenuItem";
            this.выполнитьToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.выполнитьToolStripMenuItem.Text = "Выполнить";
            this.выполнитьToolStripMenuItem.Click += new System.EventHandler(this.выполнитьToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Данные о студентах";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(732, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(506, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Список предметов у  которых нет неуспевающих";
            // 
            // ListStudents
            // 
            this.ListStudents.FormattingEnabled = true;
            this.ListStudents.ItemHeight = 25;
            this.ListStudents.Location = new System.Drawing.Point(22, 94);
            this.ListStudents.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ListStudents.Name = "ListStudents";
            this.ListStudents.Size = new System.Drawing.Size(680, 454);
            this.ListStudents.TabIndex = 27;
            this.ListStudents.DoubleClick += new System.EventHandler(this.Change_Click);
            // 
            // listBoxSubjects
            // 
            this.listBoxSubjects.FormattingEnabled = true;
            this.listBoxSubjects.ItemHeight = 25;
            this.listBoxSubjects.Location = new System.Drawing.Point(738, 94);
            this.listBoxSubjects.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.listBoxSubjects.Name = "listBoxSubjects";
            this.listBoxSubjects.Size = new System.Drawing.Size(308, 454);
            this.listBoxSubjects.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(0, 560);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1354, 413);
            this.button1.TabIndex = 42;
            this.button1.Text = "ВЫХОД";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // работаСоСтудентомToolStripMenuItem
            // 
            this.работаСоСтудентомToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСтудентаToolStripMenuItem,
            this.изменитьИнформациюToolStripMenuItem,
            this.удалитьСтудентаToolStripMenuItem});
            this.работаСоСтудентомToolStripMenuItem.Name = "работаСоСтудентомToolStripMenuItem";
            this.работаСоСтудентомToolStripMenuItem.Size = new System.Drawing.Size(255, 36);
            this.работаСоСтудентомToolStripMenuItem.Text = "Работа со студентом";
            // 
            // добавитьСтудентаToolStripMenuItem
            // 
            this.добавитьСтудентаToolStripMenuItem.Name = "добавитьСтудентаToolStripMenuItem";
            this.добавитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.добавитьСтудентаToolStripMenuItem.Text = "Добавить студента";
            this.добавитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтудентаToolStripMenuItem_Click);
            // 
            // изменитьИнформациюToolStripMenuItem
            // 
            this.изменитьИнформациюToolStripMenuItem.Name = "изменитьИнформациюToolStripMenuItem";
            this.изменитьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.изменитьИнформациюToolStripMenuItem.Text = "Изменить информацию";
            this.изменитьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.изменитьИнформациюToolStripMenuItem_Click);
            // 
            // удалитьСтудентаToolStripMenuItem
            // 
            this.удалитьСтудентаToolStripMenuItem.Name = "удалитьСтудентаToolStripMenuItem";
            this.удалитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.удалитьСтудентаToolStripMenuItem.Text = "Удалить студента";
            this.удалитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.удалитьСтудентаToolStripMenuItem_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1240, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxSubjects);
            this.Controls.Add(this.ListStudents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База студентов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveTxtToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ListStudents;
        private System.Windows.Forms.ListBox listBoxSubjects;
        private System.Windows.Forms.ToolStripMenuItem заданиеToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem условиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСоСтудентомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтудентаToolStripMenuItem;
    }
}

