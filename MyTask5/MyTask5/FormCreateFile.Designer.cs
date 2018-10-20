namespace MyTask5
{
    partial class FormCreateFile
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
            this.BTNpath = new System.Windows.Forms.Button();
            this.txtBoxFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createFileBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNpath
            // 
            this.BTNpath.Enabled = false;
            this.BTNpath.Location = new System.Drawing.Point(58, 58);
            this.BTNpath.Name = "BTNpath";
            this.BTNpath.Size = new System.Drawing.Size(100, 20);
            this.BTNpath.TabIndex = 1;
            this.BTNpath.Text = "File path";
            this.BTNpath.UseVisualStyleBackColor = true;
            this.BTNpath.Click += new System.EventHandler(this.BTNpath_Click);
            // 
            // txtBoxFileName
            // 
            this.txtBoxFileName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxFileName.Location = new System.Drawing.Point(58, 32);
            this.txtBoxFileName.Name = "txtBoxFileName";
            this.txtBoxFileName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFileName.TabIndex = 1;
            this.txtBoxFileName.TextChanged += new System.EventHandler(this.txtBoxFileName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File name";
            // 
            // createFileBTN
            // 
            this.createFileBTN.Enabled = false;
            this.createFileBTN.Location = new System.Drawing.Point(58, 84);
            this.createFileBTN.Name = "createFileBTN";
            this.createFileBTN.Size = new System.Drawing.Size(100, 23);
            this.createFileBTN.TabIndex = 5;
            this.createFileBTN.Text = "Create File";
            this.createFileBTN.UseVisualStyleBackColor = true;
            this.createFileBTN.Click += new System.EventHandler(this.createFileBTN_Click);
            // 
            // FormCreateFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(203, 119);
            this.Controls.Add(this.createFileBTN);
            this.Controls.Add(this.BTNpath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormCreateFile";
            this.ShowIcon = false;
            this.Text = "Create File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCreateFile_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNpath;
        private System.Windows.Forms.TextBox txtBoxFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createFileBTN;
    }
}