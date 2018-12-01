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

namespace Sharpi7
{
    
    public partial class Form1 : Form
    {
        StudentList StudentsBook = new StudentList();
        int id;//индекс выбранного студента
        int idSes;//индекс выбранной сессии
        string FileName="";//имя файла с которым работаем в текущий момент
        public Form1()
        {
            InitializeComponent(); 
            
        }

        //событие на выбор студента из списка
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = listBox1.SelectedIndex;
            if (id != -1)
            {
                deleteStudent.Visible = true;
                Task.Visible = true;
            }
            else
            {      
                buttonChange.Visible = false;
                Task.Visible = (listBox1.Items.Count != 0);
            }
        }
       
        //изменить информация о студенте
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Form3 newForm = new Form3(StudentsBook.list[id]);
                newForm.Owner = this;
                newForm.ShowDialog();
                if (newForm.DialogResult == DialogResult.OK)
                {
                    StudentsBook.list[id] = newForm.tmp;
                }

                newForm.Close();
            }
            else
            {
                MessageBox.Show("Сначала выберите студента", "Информация",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
            }
            
        }

        //добавить нового студента
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Owner = this;
            newForm.ShowDialog();
            if (newForm.DialogResult == DialogResult.OK)
            {
                Student newStudent = new Student();
                newStudent.FIO = newForm.StudentFIO;
                StudentsBook.Add(newStudent);
                listBox1.Items.Add(newStudent.FIO);
                
                listBox1.SelectedIndex = StudentsBook.list.Count - 1;
                newForm.Close();
                buttonChange_Click(sender, e);
            }
            
        }

        //Выполнить задание (вывести предмет, по которому наилучшая успеваемость)
        private void Task_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Наилучшая успеваемость:"+StudentsBook.Task(), "Информация",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        //Удалить студента из списка
        private void button8_Click(object sender, EventArgs e)
        {
            id = listBox1.SelectedIndex;
            StudentsBook.list.RemoveAt(id);
            listBox1.Items.RemoveAt(id);
            if (listBox1.Items.Count == 0)
            {
                deleteStudent.Visible = false;
            }
            id = 0;
        }

     
        //Загрузка данных из текстового файла
        private void изTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                StudentsBook.Loadtxt(openFileDlg.FileName);
                foreach (Student x in StudentsBook.list)
                {
                    listBox1.Items.Add(x.FIO);
                }
            }
        }
        //загрузка данных из xml файла
        private void изXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                StudentsBook.LoadXML(openFileDlg.FileName);
                foreach (Student x in StudentsBook.list)
                {
                    listBox1.Items.Add(x.FIO);
                }
            }
        }
        //загрузка из бинарного файла
        private void изBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                StudentsBook.LoadBin(openFileDlg.FileName);
                foreach (Student x in StudentsBook.list)
                {
                    listBox1.Items.Add(x.FIO);
                }
            }
        }
        //сохранить в txt
        private void вTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                StudentsBook.Savetxt(saveFileDlg.FileName);
            }
        }
        //сохранить в xml
        private void вToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                StudentsBook.SaveXML(saveFileDlg.FileName);
            }
        }
        //сохранить в bin
        private void ыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            if (saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                StudentsBook.SaveBin(saveFileDlg.FileName);
            }
        }

        //событие на двойной щелчок по студенту
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            buttonChange_Click(sender, e);
        }
    }
}
