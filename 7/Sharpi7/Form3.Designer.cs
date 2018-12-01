namespace Sharpi7
{
    partial class Form3
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
            this.save = new System.Windows.Forms.Button();
            this.textBoxCourse = new System.Windows.Forms.ComboBox();
            this.textBoxForm = new System.Windows.Forms.ComboBox();
            this.SessionsList = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxPerf = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAlgebra = new System.Windows.Forms.TextBox();
            this.textBoxWeb = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxAVM = new System.Windows.Forms.TextBox();
            this.textBoxMath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SessionsList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(316, 539);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(320, 42);
            this.save.TabIndex = 49;
            this.save.Text = "Сохранить изменения";
            this.save.UseVisualStyleBackColor = true;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.FormattingEnabled = true;
            this.textBoxCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.textBoxCourse.Location = new System.Drawing.Point(446, 64);
            this.textBoxCourse.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(97, 24);
            this.textBoxCourse.TabIndex = 48;
            this.textBoxCourse.TextChanged += new System.EventHandler(this.textBoxCourse_TextChanged);
            // 
            // textBoxForm
            // 
            this.textBoxForm.FormattingEnabled = true;
            this.textBoxForm.Items.AddRange(new object[] {
            "Договор",
            "Бюджет"});
            this.textBoxForm.Location = new System.Drawing.Point(690, 65);
            this.textBoxForm.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxForm.MaxDropDownItems = 2;
            this.textBoxForm.Name = "textBoxForm";
            this.textBoxForm.Size = new System.Drawing.Size(247, 24);
            this.textBoxForm.TabIndex = 47;
            this.textBoxForm.TextChanged += new System.EventHandler(this.textBoxForm_TextChanged);
            // 
            // SessionsList
            // 
            this.SessionsList.Controls.Add(this.label5);
            this.SessionsList.Controls.Add(this.listBoxPerf);
            this.SessionsList.Location = new System.Drawing.Point(142, 115);
            this.SessionsList.Margin = new System.Windows.Forms.Padding(4);
            this.SessionsList.Name = "SessionsList";
            this.SessionsList.Size = new System.Drawing.Size(292, 405);
            this.SessionsList.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Список сессий";
            // 
            // listBoxPerf
            // 
            this.listBoxPerf.FormattingEnabled = true;
            this.listBoxPerf.ItemHeight = 16;
            this.listBoxPerf.Location = new System.Drawing.Point(21, 47);
            this.listBoxPerf.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPerf.Name = "listBoxPerf";
            this.listBoxPerf.Size = new System.Drawing.Size(247, 340);
            this.listBoxPerf.TabIndex = 6;
            this.listBoxPerf.SelectedIndexChanged += new System.EventHandler(this.listBoxPerf_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown5);
            this.panel1.Controls.Add(this.numericUpDown4);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxAlgebra);
            this.panel1.Controls.Add(this.textBoxWeb);
            this.panel1.Controls.Add(this.textBoxC);
            this.panel1.Controls.Add(this.textBoxAVM);
            this.panel1.Controls.Add(this.textBoxMath);
            this.panel1.Location = new System.Drawing.Point(479, 115);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 405);
            this.panel1.TabIndex = 45;
            this.panel1.Visible = false;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(267, 331);
            this.numericUpDown5.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown5.TabIndex = 32;
            this.numericUpDown5.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(267, 265);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown4.TabIndex = 31;
            this.numericUpDown4.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(267, 198);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown3.TabIndex = 30;
            this.numericUpDown3.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(267, 132);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown2.TabIndex = 29;
            this.numericUpDown2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(267, 65);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Оценка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Предмет";
            // 
            // textBoxAlgebra
            // 
            this.textBoxAlgebra.Location = new System.Drawing.Point(31, 330);
            this.textBoxAlgebra.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAlgebra.Name = "textBoxAlgebra";
            this.textBoxAlgebra.Size = new System.Drawing.Size(199, 23);
            this.textBoxAlgebra.TabIndex = 11;
            this.textBoxAlgebra.Text = "Алгебра";
            this.textBoxAlgebra.TextChanged += new System.EventHandler(this.textBoxAlgebra_TextChanged);
            // 
            // textBoxWeb
            // 
            this.textBoxWeb.Location = new System.Drawing.Point(31, 265);
            this.textBoxWeb.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWeb.Name = "textBoxWeb";
            this.textBoxWeb.Size = new System.Drawing.Size(199, 23);
            this.textBoxWeb.TabIndex = 10;
            this.textBoxWeb.Text = "Веб";
            this.textBoxWeb.TextChanged += new System.EventHandler(this.textBoxWeb_TextChanged);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(31, 198);
            this.textBoxC.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(199, 23);
            this.textBoxC.TabIndex = 9;
            this.textBoxC.Text = "Си";
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // textBoxAVM
            // 
            this.textBoxAVM.Location = new System.Drawing.Point(31, 132);
            this.textBoxAVM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAVM.Name = "textBoxAVM";
            this.textBoxAVM.Size = new System.Drawing.Size(199, 23);
            this.textBoxAVM.TabIndex = 8;
            this.textBoxAVM.Text = "ЭВМ";
            this.textBoxAVM.TextChanged += new System.EventHandler(this.textBoxAVM_TextChanged);
            // 
            // textBoxMath
            // 
            this.textBoxMath.Location = new System.Drawing.Point(31, 65);
            this.textBoxMath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMath.Name = "textBoxMath";
            this.textBoxMath.Size = new System.Drawing.Size(199, 23);
            this.textBoxMath.TabIndex = 7;
            this.textBoxMath.Text = "Матан";
            this.textBoxMath.TextChanged += new System.EventHandler(this.textBoxMath_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Форма обучения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Группа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Курс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "ФИО";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.AutoCompleteCustomSource.AddRange(new string[] {
            "Бюджет",
            "Договор"});
            this.textBoxGroup.Location = new System.Drawing.Point(559, 65);
            this.textBoxGroup.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(111, 23);
            this.textBoxGroup.TabIndex = 40;
            this.textBoxGroup.TextChanged += new System.EventHandler(this.textBoxGroup_TextChanged);
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(45, 65);
            this.textBoxFio.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(392, 23);
            this.textBoxFio.TabIndex = 39;
            this.textBoxFio.TextChanged += new System.EventHandler(this.textBoxFio_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 605);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 41);
            this.button1.TabIndex = 50;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 678);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.textBoxForm);
            this.Controls.Add(this.SessionsList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.textBoxFio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о студенте";
            this.SessionsList.ResumeLayout(false);
            this.SessionsList.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox textBoxCourse;
        private System.Windows.Forms.ComboBox textBoxForm;
        private System.Windows.Forms.Panel SessionsList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxPerf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAlgebra;
        private System.Windows.Forms.TextBox textBoxWeb;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxAVM;
        private System.Windows.Forms.TextBox textBoxMath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.Button button1;

    }
}