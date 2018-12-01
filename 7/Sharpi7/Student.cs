using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpi7
{
    //стркуктура информация об экзамене
    [Serializable]
    public struct Exam
    {
        public string subject;//наименование предмета
        public int mark;      //оценка
    }
   
    [Serializable]
    public class Sessia
    {
        public Exam[] Exams { get; set; }
        public Sessia()
        {
            Exams = new Exam[5];
            Exams[0].subject = "Матан";
            Exams[1].subject = "ЭВМ";
            Exams[2].subject = "Си";
            Exams[3].subject = "Веб";
            Exams[4].subject = "Алгебра";
            
        }
    }

    [Serializable]
    public class Student
    {
        public string FIO{ get; set; }       //поле ФИО
        public int Course{ get; set; }       //Номер курса
        public int Group{ get; set; }        //Номер группы
        public bool Budget{ get; set; }      //форма обучения
        public Sessia[] Sessions { get; set; }  //успеваемость
        
        //преобразование в массив строк
        public string[] ToText()
        {
            int size = 5 + Course * 12;//5 полей обязательны остальные зависят от кол-ва сессий
            string[] result = new string[size];
            string fio = "ФИО: " + FIO;
            string course = "Курс: " + Course.ToString();
            string group = "Номер группы: " + Group.ToString();
            string form = "Форма обучения: " + (Budget ? "Бюджет" : "Договор");
            string progress = "Успеваемость:";
            result[0] = fio;
            result[1] = course;
            result[2] = group;
            result[3] = form;
            result[4] = progress;
            int s = 5;//начиная с 6-й строки идет информация об успеваемости
            for (int i = 0; i < Course * 2; ++i)//записываем каждую сессию
            {
                result[s] = "Сессия №" + (i + 1).ToString() + ":";
                ++s;
                for (int j = 0; j < 5; ++j)
                {
                    result[s] = Sessions[i].Exams[j].subject + " " + Sessions[i].Exams[j].mark.ToString();
                    ++s;
                }
            }
            return result;
        }

        //достаем нужную часть из строки: count - сколько, one - начиная с какого слова
        static public string GetData(string str, int count, int one = 1)
        {
            string result = "";
            char[] splitchar = { ' ' }; //разделяющий пробел
            string[] strArr;            //вспомогательный массив для Split
            strArr = str.Split(splitchar);//разбиваем строку  
            //вытаскиваем нужное кол-во слов значение
            for (int i = one; i <= count; ++i)
                result = result + strArr[i] + " ";
            result = result.Trim();
            return result;
        }

        //из массива строк в объект
        static public Student TextToStudent(string[] mas)
        {        
                int size = mas.Length;      //кол-во строк
                Student result = new Student();
                //Достаем значение ФИО
                result.FIO = GetData(mas[0], 3);
                //Достаем значение Номер курса
                result.Course = Int32.Parse(GetData(mas[1], 1));
                //Достаем номер группы
                result.Group = Int32.Parse(GetData(mas[2], 2, 2));
                //Достаем форму обучения
                result.Budget = (GetData(mas[3], 2,2) == "Бюджет");
                //mas[4]-Успеваемость:
                //каждая 6-я строка номер сессии
                int CountSessio = result.Course*2;
                result.Sessions = new Sessia[CountSessio];
                for (int i = 0; i < CountSessio; ++i)
                {
                    result.Sessions[i] = new Sessia();
                }

                int s = 5;
                for (int i = 0; i < result.Course * 2; ++i)//записываем каждую сессию
                {
                    ++s;
                    for (int j = 0; j < 5; ++j)
                    {
                        result.Sessions[i].Exams[j].subject = GetData(mas[s], 0, 0);
                        result.Sessions[i].Exams[j].mark = Int32.Parse(GetData(mas[s], 1, 1));
                        ++s;
                    }
                }
                return result;
        }



    }
}
