using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyTask5
{ 
    // Те строки которые не содержат слова
    public partial class Form1 : Form
    {
       
        private string fileName = string.Empty;

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter ="txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                saveToolStripMenuItem.Enabled = false;
                fileName = dlg.FileName;
                StreamReader st = new StreamReader(dlg.FileName, Encoding.GetEncoding(1251));
                txtInput.Text = st.ReadToEnd();  
                st.Close();
                
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (fileName != "")
            {
                StreamWriter st = new StreamWriter(fileName, false, Encoding.GetEncoding(1251));
                st.Write(txtOutput.Text);
                st.Close();
                MessageBox.Show("Файл успешно сохранен!");
            }
            else
            MessageBox.Show("Файл не открыт", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "*.txt|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Файл успешно сохранен!");
                StreamWriter st = new StreamWriter(dlg.FileName, false, Encoding.GetEncoding(1251));
                st.Write(txtInput.Text); 
                st.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateFile createFileF = new FormCreateFile();
            createFileF.Owner = this;
            createFileF.Show();
            
            Enabled = false;
          
        }
       

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            txtInput.Text = string.Empty;
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Дан текстовый файл. Создать на его основе новый файл, состоящий только из тех строк первого файла," +
                "которые не содержат заданного слова",
                "Условие",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxTask.Text != "")
            {
              
                taskToolStripMenuItem1.Enabled = true;
                
            }
            else
            {
                taskToolStripMenuItem1.Enabled = false;
               
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            string setWrd = txtBoxTask.Text;
            string line = "";
           

            // textOutput.Clear();
            for (int i = 0; i < txtInput.Lines.Count(); i++)
            {
                line = txtInput.Lines[i];
                if (!line.Contains(setWrd))
                {
                    txtOutput.Text += line + Environment.NewLine;
                }
            }
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            if (txtOutput.Text != "")
            {
                
                saveToolStripMenuItem.Enabled = true;
                saveResultToolStripMenuItem.Enabled = true;
            }
            else
            {
                saveResultToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
               
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                txtBoxTask.Enabled = true;
            }
            else
            {
                txtBoxTask.Enabled = false;           
            }
        }

        private void BTNsaveResult_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "*.txt|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Файл успешно сохранен!");
                StreamWriter st = new StreamWriter(dlg.FileName, false, Encoding.GetEncoding(1251));
                st.Write(txtOutput.Text);
                st.Close();
            }
        }

        private void taskToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string setWrd = txtBoxTask.Text;
            string line = "";


            // textOutput.Clear();
            for (int i = 0; i < txtInput.Lines.Count(); i++)
            {
                line = txtInput.Lines[i];
                if (!line.Contains(setWrd))
                {
                    txtOutput.Text += line + Environment.NewLine;
                }
            }
        }

        private void saveResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "*.txt|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Файл успешно сохранен!");
                StreamWriter st = new StreamWriter(dlg.FileName, false, Encoding.GetEncoding(1251));
                st.Write(txtOutput.Text);
                st.Close();
            }
        }
    }
}
