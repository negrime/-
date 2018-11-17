using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    
    public partial class Form1 : Form
    {
        public List<Student> students = new List<Student>();
        public const int semester = 8;
        public const int subjects = 5;
        Student st = new Student();

        public Form1()
        {
    
          
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students.Add(st);
            textBoxSubject1Sem1.Text = students.Count.ToString();
        }

        private void textBoxGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (StudentPasportSave(ref st))
            {
                for (int i = 0; i < subjects; i++)
                {
                    st.sessions[i].exams[i] = textBoxSubject1Sem1.Text;
                    st.sessions[i].marks[i] = domainUpDown1.Text;
                }
                Serialize.Save(st);
                MessageBox.Show("Path for file ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
            
        }


        private bool StudentPasportSave(ref Student student)
        {
            bool result = true;
            if (textBoxName.Text != "")
            {
                st.name = textBoxName.Text;
            }
            else
            {
                MessageBox.Show("Заполните поле \"ФИО\" ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                result = false;
            }
            try
            {
                st.groupNumber = Int32.Parse(textBoxGroup.Text);   
            }
            catch
            {
                MessageBox.Show("Заполните поле \"№ Группы\" ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                result = false;
            }
            return result;
            
        }

        private void domainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown dup = (DomainUpDown)sender;
          
            DomainUpDown.DomainUpDownItemCollection collection = dup.Items;
            collection.Add(5);
            collection.Add(4);
            collection.Add(3);
            collection.Add(2);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] formats = new string[] {".xml", ".txt" };
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "XML файл (*.xml)|*xml|Текстовый файл (*txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FileName.Contains(formats[0]))
                {
                    MessageBox.Show("Заполните поле \"№ Группы\" ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Student st1 = Serialize.GetStudent();
                    listBox.Items.Add(st1.name + " " +st.groupNumber);
                    tabControl.SelectTab(1);   
                }

            }

            
        }
    }
}
