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

namespace _6
{
    public partial class FMain : Form
    {
        StList StudList = new StList();
        public  List<string> friendsData = new List<string>();
        
        public FMain()
        {
            InitializeComponent();
        }

        // КНОПКА Добавить нового студента
        private void Add_Click(object sender, EventArgs e)
        {
            Student St = new Student();
            NewForm StudForm = new NewForm(St);
            StudForm.ShowDialog();
            if (StudForm.DialogResult == DialogResult.OK)
            {
                St = StudForm.NewSt();
                ListStudents.Items.Add(St.FIO);
                StudList.Add(St);
            } 
        }

        // КНОПКА Изменить данные о студенте
        private void Change_Click(object sender, EventArgs e)
        {
            int i = ListStudents.SelectedIndex;
            if (i != -1)
            {
                Student St = new Student();
                NewForm StudForm = new NewForm(StudList.list[i]);
                StudForm.ShowDialog();
                if (StudForm.DialogResult == DialogResult.OK)
                {
                    StudList.list[i] = StudForm.NewSt();
                    ListStudents.Items[i] = StudList.list[i].FIO;
                }
            }
            else MessageBox.Show("Вы не выбрали студента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // КНОПКА Удаление студента
        private void Delete_Click(object sender, EventArgs e)
        {
            int i = ListStudents.SelectedIndex;
            if (i != -1)
            {
                StudList.list.RemoveAt(i);
                ListStudents.Items.RemoveAt(i);
            }
            else MessageBox.Show("Вы не выбрали студента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // МЕНЮ Save XML
        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                StudList.SaveXML(saveFileDlg.FileName);
            }
        }

        // МЕНЮ Открыть XML
        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                // Очищаем предыдущий
                ListStudents.Items.Clear();
                StudList.OpenXML(openFileDlg.FileName);
                foreach (Student x in StudList.list)
                {
                    ListStudents.Items.Add(x.FIO);
                }
            }
        }

        // МЕНЮ Сохранить как бинарный
        private void SaveBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            if (saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                StudList.SaveBin(saveFileDlg.FileName);
            }
        }

        // МЕНЮ Открыть как бинарный
        private void OpenBinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                ListStudents.Items.Clear();
                StudList.OpenBin(openFileDlg.FileName);
                foreach (Student x in StudList.list)
                {
                    ListStudents.Items.Add(x.FIO);
                }
            }
        }

        // МЕНЮ Сохранить как текстовый
        private void SaveTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                StudList.SaveTxt(saveFileDlg.FileName);
            }
        }

        // МЕНЮ Открыть как текстовый
        private void OpenTxtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
               ListStudents.Items.Clear();
                StudList.OpenTxt(openFileDlg.FileName);
                foreach (Student x in StudList.list)
                {
                    ListStudents.Items.Add(x.FIO);
                }  
            }
        }


        // КНОПКА Выполнить задание 
        private void RunTask_Click(object sender, EventArgs e)
        {
           
            
            //else MessageBox.Show("Выберите предмет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        // МЕНЮ Узнать задание
        private void заданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void выполнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxSubjects.Items.Clear();         
            foreach (var item in StList.Task(StudList))
            {
                listBoxSubjects.Items.Add(item.ToString());
            }
            if (listBoxSubjects.Items.Count == 0) MessageBox.Show("Таких предметов не найдено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void условиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

            MessageBox.Show("Найти предметы у которых нет неуспевающих студентов", "Задание №6", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "txt files (*.txt)|*.txt|bin files (*.bin)|*.bin|XML files (*.xml)|*.xml";
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                ListStudents.Items.Clear();
                switch (openFileDlg.FilterIndex)
                {
                    case 1:
                        StudList.OpenTxt(openFileDlg.FileName);
                        break;
                    case 2:
                        StudList.OpenBin(openFileDlg.FileName);
                        break;
                    case 3:
                        StudList.OpenXML(openFileDlg.FileName);
                        break;
                    default:
                            break;
                }
                foreach (Student x in StudList.list)
                {
                    ListStudents.Items.Add(x.FIO);
                }
              
            }
        }

        private void добавитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student St = new Student();
            NewForm StudForm = new NewForm(St);
            StudForm.ShowDialog();
            if (StudForm.DialogResult == DialogResult.OK)
            {
                St = StudForm.NewSt();
                ListStudents.Items.Add(St.FIO);
                StudList.Add(St);
            }
        }

        private void изменитьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = ListStudents.SelectedIndex;
            if (i != -1)
            {
                Student St = new Student();
                NewForm StudForm = new NewForm(StudList.list[i]);
                StudForm.ShowDialog();
                if (StudForm.DialogResult == DialogResult.OK)
                {
                    StudList.list[i] = StudForm.NewSt();
                    ListStudents.Items[i] = StudList.list[i].FIO;
                }
            }
            else MessageBox.Show("Вы не выбрали студента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void удалитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = ListStudents.SelectedIndex;
            if (i != -1)
            {
                StudList.list.RemoveAt(i);
                ListStudents.Items.RemoveAt(i);
            }
            else MessageBox.Show("Вы не выбрали студента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
