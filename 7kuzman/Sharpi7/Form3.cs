using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharpi7
{
    public partial class Form3 : Form
    {
        public Student tmp = new Student();
        int index = -1;
        public Form3(Student x)
        {
            InitializeComponent();
            //копируем значения во временный объект
            tmp.FIO = x.FIO; 
            tmp.Course = x.Course;
            tmp.Group = x.Group;
            tmp.Budget = x.Budget;
            int CountSessio = tmp.Course * 2;
            tmp.Sessions = new Sessia[CountSessio];
            for (int i = 0; i < CountSessio; ++i)
            {
                tmp.Sessions[i] = new Sessia();
            }

            for (int i = 0; i < tmp.Course * 2; ++i)//записываем каждую сессию
            {
                for (int j = 0; j < 5; ++j)//каждый экзамен
                {
                    tmp.Sessions[i].Exams[j].subject =  x.Sessions[i].Exams[j].subject;
                    tmp.Sessions[i].Exams[j].mark = x.Sessions[i].Exams[j].mark;
                }
            }
            //заносим значения на формочку
            textBoxFio.Text = tmp.FIO;
            textBoxCourse.Text = (tmp.Course).ToString();
            textBoxGroup.Text = (tmp.Group).ToString();
            textBoxForm.Text = (tmp.Budget ? "Бюджет" : "Договор");
            ChangeList(CountSessio);
            save.Visible = false;
        }

        //Возращаем ОК если данные надо изменить
        private void save_Click(object sender, EventArgs e)
        {
            //вносим изменения
            tmp.FIO = textBoxFio.Text;
            tmp.Group = Int32.Parse(textBoxGroup.Text);
            tmp.Budget = (textBoxForm.Text == "Бюджет");
            this.DialogResult = DialogResult.OK;
        }
        //отмена
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        //событие на выбор сессии
        private void listBoxPerf_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            index = listBoxPerf.SelectedIndex;//узнаем индекс выбранной сессии
            if (index != -1)
            {
                panel1.Visible = true;//делаем панель предметов видимой
                //заносим значения
                textBoxMath.Text = tmp.Sessions[index].Exams[0].subject;
                numericUpDown1.Value = tmp.Sessions[index].Exams[0].mark;
                textBoxAVM.Text = tmp.Sessions[index].Exams[1].subject;
                numericUpDown2.Value = tmp.Sessions[index].Exams[1].mark;
                textBoxC.Text = tmp.Sessions[index].Exams[2].subject;
                numericUpDown3.Value = tmp.Sessions[index].Exams[2].mark;
                textBoxWeb.Text = tmp.Sessions[index].Exams[3].subject;
                numericUpDown4.Value = tmp.Sessions[index].Exams[3].mark;
                textBoxAlgebra.Text = tmp.Sessions[index].Exams[4].subject;
                numericUpDown5.Value = tmp.Sessions[index].Exams[4].mark;
            }
        }
        //изменение списка сессий
        private void ChangeList(int CountSessio)
        {
            listBoxPerf.Items.Clear();
            for (int i = 1; i <= CountSessio; ++i)
            {
                listBoxPerf.Items.Add(i.ToString());
            }
        }

        //событие на изменение номера курса
        private void textBoxCourse_TextChanged(object sender, EventArgs e)
        {
            int newCourse = Int32.Parse(textBoxCourse.Text);
            if (tmp.Course != newCourse)
            {
                tmp.Course = newCourse;
                int CountSessio = tmp.Course * 2;
                tmp.Sessions = new Sessia[CountSessio];
                for (int i = 0; i < CountSessio; ++i)
                {
                    tmp.Sessions[i] = new Sessia();
                }
                save.Visible = true;
                ChangeList(CountSessio);
            }
        }
        //изменение ФИО
        private void textBoxFio_TextChanged(object sender, EventArgs e)
        {
            save.Visible = true;
        }
        //изменение номера группы
        private void textBoxGroup_TextChanged(object sender, EventArgs e)
        {
            save.Visible = true;
        }
        //изменение формы обучения
        private void textBoxForm_TextChanged(object sender, EventArgs e)
        {  
            save.Visible = true;
        }
        //изменения названия 1-го предмета
        private void textBoxMath_TextChanged(object sender, EventArgs e)
        {
            save.Visible = true;
            tmp.Sessions[index].Exams[0].subject = textBoxMath.Text;
        }
        //изменения оценки 1-го предмета
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            save.Visible = true;
            tmp.Sessions[index].Exams[0].mark = (int)(numericUpDown1.Value);
        }
        //изменения названия 2-го предмета
        private void textBoxAVM_TextChanged(object sender, EventArgs e)
        {
            save.Visible = true;
            tmp.Sessions[index].Exams[1].subject = textBoxAVM.Text;
        }
        //изменения оценки 2-го предмета
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            save.Visible = true;
            tmp.Sessions[index].Exams[1].mark = (int)(numericUpDown2.Value);
        }
        //изменения названия 3-го предмета
        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
            save.Visible = true;
            tmp.Sessions[index].Exams[2].subject = textBoxC.Text;
        }
        //изменения оценки 3-го предмета
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            save.Visible = true;
            tmp.Sessions[index].Exams[2].mark = (int)(numericUpDown3.Value);
        }
        //изменение названия 4-го предмета
        private void textBoxWeb_TextChanged(object sender, EventArgs e)
        {
            save.Visible = true;
            tmp.Sessions[index].Exams[3].subject = textBoxWeb.Text;
        }
        //изменения оценки 4-го предмета
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            save.Visible = true;
            tmp.Sessions[index].Exams[3].mark = (int)(numericUpDown4.Value);
        }
        //изменение названия 5-го предмета
        private void textBoxAlgebra_TextChanged(object sender, EventArgs e)
        {
            save.Visible = true;
            tmp.Sessions[index].Exams[4].subject = textBoxAlgebra.Text;
        }
        //изменения оценки 5-го предмета
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            save.Visible = true;
            tmp.Sessions[index].Exams[4].mark = (int)(numericUpDown5.Value);
        }  
    }
}
