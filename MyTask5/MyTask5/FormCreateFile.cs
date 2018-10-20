using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MyTask5
{
    
    public partial class FormCreateFile : Form
    {
       
        private string fileName = string.Empty;
        private string filePath = string.Empty;
        public FormCreateFile()
        {
            InitializeComponent();
            CenterToScreen();
        }
        

        private void BTNpath_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;

            FolderBrowserDialog dialog = new FolderBrowserDialog();
           //Environment.CurrentDirectory + @"\File.exe
         
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = dialog.SelectedPath;
                MessageBox.Show("Path for file " + filePath, "Info",MessageBoxButtons.OK ,MessageBoxIcon.Information);


                //  main.Enabled = true;

            }
           
                
        }

        private void txtBoxFileName_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxFileName.Text != "")
            {
                BTNpath.Enabled = true;
                createFileBTN.Enabled = true;
            }       
            else
            {
                BTNpath.Enabled = false;
                createFileBTN.Enabled = false;
            }
                
        }

        private void FormCreateFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 main = this.Owner as Form1;
            main.Enabled = true;
        }

      
        private void createFileBTN_Click(object sender, EventArgs e)
        {
            fileName = txtBoxFileName.Text;
           

            // this.Close();
            if (!File.Exists(filePath + @"\" + fileName + ".txt"))
            {
                
                File.WriteAllText(Path.Combine(filePath, fileName + ".txt"), string.Empty);       
                MessageBox.Show("File was create", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
            }
            else
            {
                if (MessageBox.Show($"File with name {fileName} already exists! Rewrite?", "Warning!",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.WriteAllText(Path.Combine(filePath, fileName + ".txt"), string.Empty);
                    MessageBox.Show("File was rewrite!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
            }
            txtBoxFileName.Text = string.Empty;

        }
    }
}
