using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace _6
{

    // Структура экзамена
    [Serializable]
    public struct Exam
    {
        public string subject;
        public int mark;     
        
    }

    [Serializable]
    public class Ses
    {
        public Exam[] Exams { get; set; }

        public Ses()
        {
            Exams = new Exam[5];
            for (int i = 0; i < 5; i++)
            {
                Exams[i].subject = ""; //Sub.Name_Sub[i];    
            }
        }
    }

    // Класс для одного студента
    [Serializable]
    public class Student
    {
        public string FIO { set; get; }
        public int Course { set; get; }
        public int Groupe { set; get; }
        public string Form { set; get; }
        public Ses[] Perf { set; get; }

        // Пустой конструктор
        public Student()
        {
            Perf = new Ses[8];
            for (int i = 0; i < 8; ++i)
            {
                Perf[i] = new Ses();

            }
        }

        // Констуктор с введенными данными
        public Student(string FIO, int Gr, int Co, Ses[] Mar, string Form)
        {
            this.FIO = FIO;
            this.Course = Co;
            this.Groupe = Gr;
            this.Form = Form;
            this.Perf = Mar;
        }

        //преобразование в строку
        public string ToStr()
        {
            string St;
            St = FIO + "\nКурс: " + Course + "\nГруппа: " + Groupe + "\n";
            St = St + "Успеваемость\n";
            for (int i = 0; i < Course * 2; i++)
            {
                St = St + "Сессия " + i;
                for (int j = 0; j < 5; j++)
                {
                    St = St + Perf[i].Exams[j].subject + ' ' + Perf[i].Exams[j].mark + '\n';
                }
            }
            return St;
        }

        // Из строки в объект
        public static Student TxtToStud(string str)
        {
            Student St = new Student();
            string[] MasS = str.Split('\n'); // Делим на отдельные строки
            St.FIO = MasS[0]; // Первая строка - фамилия
            St.Course = Int32.Parse(MasS[1].Substring(6)); // Вторая строка - курс, substringом выцепляем номер
            St.Groupe = Int32.Parse(MasS[2].Substring(8));
            St.Form = MasS[3].Substring(16); // начиная с 16 символа указано - бюджет или договор
            for (int i = 0; i < St.Course * 2; i++) // загружаем оценки
                for (int j = 0; j < 5; j++)
                {
                    // St.Perf[i].Exams[j].subject = 
                    int L = MasS[6 + (i * 6) + j].Length; // (6 + (i * 6) + j) - формула для каждого предмета
                    St.Perf[i].Exams[j].mark = Int32.Parse(MasS[6 + (i * 6) + j].Substring(L - 2));
                    St.Perf[i].Exams[j].subject = MasS[6 + (i * 6) + j].Remove(L - 2);
                }
            return St;
        }

    }

}
