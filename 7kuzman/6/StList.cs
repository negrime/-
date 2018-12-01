using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace _6
{
    // Список студентов
    [Serializable]
    [XmlRoot("Student")]
    class StList
    {
        [XmlArray("StudentList"), XmlArrayItem(typeof(Student), ElementName = "Student")]

        public List<Student> list
        { get; set; }

        // Конструктор класса
        public StList()
        {
            list = new List<Student>();
        }

        // Добавить в список
        public void Add(Student St)
        {
            list.Add(St);
        }

        // Сохранить бинарный
        public void SaveBin(string fileName)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream writer = new FileStream(fileName, FileMode.Create))
            {
                bf.Serialize(writer, list);
            }
        }

        // Открыть бинарный
        public void OpenBin(string fileName)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream reader = new FileStream(fileName, FileMode.Open))
            {
                list = (List<Student>)bf.Deserialize(reader);
            }
        }

        //XML Сериализация
        public void SaveXML(string fileName)
        {
            // передаем в конструктор тип класса
            XmlSerializer writer = new XmlSerializer(typeof(StList));

            // получаем поток, куда будем записывать сериализованный объект
            FileStream sw = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            StreamWriter file = new StreamWriter(sw);
            writer.Serialize(file, this);
            file.Close();
        }

        //XML десериализация
        public void OpenXML(string fileName)
        {
            XmlSerializer xf = new XmlSerializer(typeof(StList));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                StList tmb = (StList)xf.Deserialize(fs);
                list = tmb.list;
            }
        }

        // Сохрнаить как текстовый
        public void SaveTxt(string fileName)
        {
            StreamWriter stWr = new StreamWriter(fileName, false, Encoding.Default);
            foreach (Student x in list)
            {
                stWr.WriteLine("ФИО: " + x.FIO + Environment.NewLine + "Курс: " + x.Course + Environment.NewLine + "Группа: " + x.Groupe +
                                Environment.NewLine + "Форма обучения: " + x.Form);
                stWr.WriteLine("Успеваемость");
                for (int i = 0; i < x.Course * 2; i++)
                {
                    stWr.WriteLine("Сессия №" + (i + 1));
                    for (int j = 0; j < 5; j++)
                        stWr.WriteLine(x.Perf[i].Exams[j].subject + ' ' + x.Perf[i].Exams[j].mark);
                }
                stWr.WriteLine();
            }
            stWr.Close();
        }

        // Открыть текстовый
        public void OpenTxt(string fileName)
        {
            list = new List<Student>();
            StreamReader stR = new StreamReader(fileName, Encoding.Default);
            string AllTxt = stR.ReadToEnd();
            string[] Study = AllTxt.Split(new string[] { "ФИО: " }, StringSplitOptions.None);
            for (int i = 1; i < Study.Length; i++)
                list.Add(Student.TxtToStud(Study[i]));
            stR.Close();
        }
        public static List<string> Task(StList StudList)
        {
            List<string> subPositive = new List<string>();
            List<string> subBad = new List<string>();

            for (int i = 0; i < StudList.list.Count; i++)
            {

                //  int j = 0;
                int course = StudList.list[i].Course;
                int M = course * 2;
                for (int k = 0; k < M; k++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        if (StudList.list[i].Perf[k].Exams[j].mark == 2)
                        {
                            if (subPositive.Contains(StudList.list[i].Perf[k].Exams[j].subject))
                            {
                                subPositive.Remove(StudList.list[i].Perf[k].Exams[j].subject);
                            }
                            if (!subBad.Contains(StudList.list[i].Perf[k].Exams[j].subject))
                            {
                                subBad.Add(StudList.list[i].Perf[k].Exams[j].subject);
                            }
                        }
                        else if (StudList.list[i].Perf[k].Exams[j].mark > 2 && !subBad.Contains(StudList.list[i].Perf[k].Exams[j].subject)
                                 && (!subPositive.Contains(StudList.list[i].Perf[k].Exams[j].subject)))
                        {
                            subPositive.Add(StudList.list[i].Perf[k].Exams[j].subject);
                        }
                    }
                }
            }
            return subPositive;
        }
    }
}



    

