using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class NewForm : Form
    {
        // Объявляем временный массив оценок
        Ses[] NewS = new Ses[8];
        List<string> Fio = new List<string>();
        

        public NewForm(Student st)
        {
            InitializeComponent();

            try // Попытка считать объект студент в форму, если не получилось, значит объект пустой, 
                // следовательно, переходим к созданию нового
            {
                FIO.Text = st.FIO;
                Course.Value = Convert.ToDecimal(st.Course);
                Groupe.Value = Convert.ToDecimal(st.Groupe);
                NewS = st.Perf;
                numericUpDown1.Value = Convert.ToDecimal(st.Perf[0].Exams[0].mark);
                numericUpDown2.Value = Convert.ToDecimal(st.Perf[0].Exams[1].mark);
                numericUpDown3.Value = Convert.ToDecimal(st.Perf[0].Exams[2].mark);
                numericUpDown4.Value = Convert.ToDecimal(st.Perf[0].Exams[3].mark);
                numericUpDown5.Value = Convert.ToDecimal(st.Perf[0].Exams[4].mark);
                textBoxSub1.Text = st.Perf[0].Exams[0].subject;
                textBoxSub2.Text = st.Perf[0].Exams[1].subject;
                textBoxSub3.Text = st.Perf[0].Exams[2].subject;
                textBoxSub4.Text = st.Perf[0].Exams[3].subject;
                textBoxSub5.Text = st.Perf[0].Exams[4].subject;
                
                Form.Text = st.Form;
            }
            catch
            { // Инициализация массива оценок
                for (int i = 0; i < 8; ++i)
                {
                    NewS[i] = new Ses();
                    for (int j = 0; j < 5; ++j)
                    {
                        NewS[i].Exams[j].mark = 2;
                        NewS[i].Exams[j].subject = "Название предмета";
                    }
                }
            }
            // Считаем максимальное количество сессий
            NumSes.Maximum = (int)Course.Value * 2;
        }
        

        FMain main = new FMain();

        // Создание или изменение студента
        public Student NewSt()
        {
            Student Stud = new Student();
            Stud.FIO = FIO.Text;
            Stud.Course = (int)Course.Value;
            Stud.Groupe = (int)Groupe.Value;
            Stud.Form = Form.Text;
            Stud.Perf = NewS;
            //Stud.Marks[2].Exams[1].subject;
            return Stud;
        }
        
        // При изменении курса меняется максимальное значение количества сессий
        private void Course_ValueChanged(object sender, EventArgs e)
        {
            NumSes.Maximum = (int)Course.Value * 2;
        }

        // При изменении номера сессии изменяются значения каждого экзамена
        private void NumSes_ValueChanged(object sender, EventArgs e)
        {
            int N = (int)NumSes.Value - 1; 
            numericUpDown1.Value = Convert.ToDecimal(NewS[N].Exams[0].mark);
            numericUpDown2.Value = Convert.ToDecimal(NewS[N].Exams[1].mark);
            numericUpDown3.Value = Convert.ToDecimal(NewS[N].Exams[2].mark);
            numericUpDown4.Value = Convert.ToDecimal(NewS[N].Exams[3].mark);
            numericUpDown5.Value = Convert.ToDecimal(NewS[N].Exams[4].mark);

            textBoxSub1.Text = NewS[N].Exams[0].subject;
            textBoxSub2.Text = NewS[N].Exams[1].subject;
            textBoxSub3.Text = NewS[N].Exams[2].subject;
            textBoxSub4.Text = NewS[N].Exams[3].subject;
            textBoxSub5.Text = NewS[N].Exams[4].subject;
        }

        // Изменяя оценку, она сохраняется во временный массив оценок
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NewS[(int)NumSes.Value - 1].Exams[0].mark = (int)numericUpDown1.Value; 
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            NewS[(int)NumSes.Value-1].Exams[1].mark = (int)numericUpDown2.Value;
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            NewS[(int)NumSes.Value-1].Exams[2].mark = (int)numericUpDown3.Value;
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            NewS[(int)NumSes.Value-1].Exams[3].mark = (int)numericUpDown4.Value;
        }
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            NewS[(int)NumSes.Value-1].Exams[4].mark = (int)numericUpDown5.Value;
        }

        // Кнопка Сохранить 
        private void Save_MouseClick(object sender, MouseEventArgs e)
        {
            if (FIO.Text != "")
                this.DialogResult = DialogResult.OK;
            else MessageBox.Show("Введите имя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Кнопка Отменить изменения
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSub1_TextChanged(object sender, EventArgs e)
        {
            NewS[(int)NumSes.Value - 1].Exams[0].subject = textBoxSub1.Text;            
        }

        private void textBoxSub2_TextChanged(object sender, EventArgs e)
        {
            NewS[(int)NumSes.Value - 1].Exams[1].subject = textBoxSub2.Text;
        }

        private void textBoxSub3_TextChanged(object sender, EventArgs e)
        {
            NewS[(int)NumSes.Value - 1].Exams[2].subject = textBoxSub3.Text;
        }

        private void textBoxSub4_TextChanged(object sender, EventArgs e)
        {
            NewS[(int)NumSes.Value - 1].Exams[3].subject = textBoxSub4.Text;
        }

        private void textBoxSub5_TextChanged(object sender, EventArgs e)
        {
            NewS[(int)NumSes.Value - 1].Exams[4].subject = textBoxSub5.Text;
        }

        

        private void buttonRndStudent_Click(object sender, EventArgs e)
        {
            labelLoad.Visible = true;
            if (Fio.Count == 0)
            {
                Fio = VK.GetFio();
            }
            List<string> subjects = new List<string> { "Матан", "Программирование", "ЯСП", "C#", "C++", "Delphi", "Линейная алгебра", "Диффуры", "Вычислительная математика", "Swift", "История", "Право" };
            Random rnd = new Random();
            if (Fio.Count > 0)
            {
                int value = rnd.Next(0, Fio.Count);
                FIO.Text = Fio[value];
            }
            Course.Value = rnd.Next(1, 5);
            Groupe.Value = rnd.Next(1, 11);
            Form.SelectedIndex = rnd.Next(0, 2);           
            for (int i = 0; i < Course.Value * 2; i++)
            {
                List<string> useSub = new List<string>(subjects);
                // NewS[i].Exams[j].mark = Convert.ToDecimal(numericUpDown1.Value);
                numericUpDown1.Value = NewS[i].Exams[0].mark = rnd.Next(2 , 6);
                numericUpDown2.Value = NewS[i].Exams[1].mark = rnd.Next(2 , 6);
                numericUpDown3.Value = NewS[i].Exams[2].mark = rnd.Next(2 , 6);
                numericUpDown4.Value = NewS[i].Exams[3].mark = rnd.Next(2 , 6);
                numericUpDown5.Value = NewS[i].Exams[4].mark = rnd.Next(2 , 6);

                string value;

                value = useSub[rnd.Next(0, useSub.Count)];
                useSub.Remove(value);
                textBoxSub1.Text = NewS[i].Exams[0].subject = value;

                value = useSub[rnd.Next(0, useSub.Count)];
                useSub.Remove(value);
                textBoxSub2.Text = NewS[i].Exams[1].subject = value;

                value = useSub[rnd.Next(0, useSub.Count)];
                useSub.Remove(value);
                textBoxSub3.Text = NewS[i].Exams[2].subject = value;

                value = useSub[rnd.Next(0, useSub.Count)];
                useSub.Remove(value);
                textBoxSub4.Text = NewS[i].Exams[3].subject = value;

                value = useSub[rnd.Next(0, useSub.Count)];
                useSub.Remove(value);
                textBoxSub5.Text = NewS[i].Exams[4].subject = value;
                labelLoad.Visible = false;
            }
        }
    }
}
