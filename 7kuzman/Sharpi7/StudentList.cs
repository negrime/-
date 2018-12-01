using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Sharpi7
{
    [Serializable]
    [XmlRoot("Student")]
    public class StudentList
    {
        [XmlArray("StudentList"), XmlArrayItem(typeof(Student), ElementName = "Student")]
        public List<Student> list//список студентов
        { get; set; }

        //конструктор класса
        public StudentList()
        {
            list = new List<Student>();
        }

        //добавление студента в список
        public int Add(Student student)
        {
            list.Add(student);
            return list.Count - 1;
        }

        class Ex
        {
            public Exam info;
            public int count;
        }   

        //Найти предмет по которому наилучшая успеваемость
        public string Task()
        {
           
            List<Ex> all = new List<Ex>();//список из предметов
            //пробегаем по всем студентам
            foreach (Student x in list)
            {
                int count = x.Course * 2;
                //по каждой сессии отдельного студента
                //пробегаем по каждому экзамену студента
                for (int i = 0; i < count; ++i)
                {
                    for (int j = 0; j < 5; ++j)
                    {
                        //если такой экзамен не существует - добавляем
                        if(!all.Exists(y => y.info.subject ==  x.Sessions[i].Exams[j].subject )) 
                        {
                            Ex tmp =new Ex();
                            tmp.info = new Exam();
                            tmp.info.subject = x.Sessions[i].Exams[j].subject;
                            tmp.info.mark = x.Sessions[i].Exams[j].mark;
                            tmp.count = 1;
                            all.Add(tmp);
                        }
                        else//иначе прибавляем значения к имеющемуся
                        {
                            int index = all.FindIndex(u => u.info.subject == x.Sessions[i].Exams[j].subject);//находим индекс экзамена
                            all[index].info.mark += x.Sessions[i].Exams[j].mark;//добавляем оценку
                            all[index].count++;//увеличиваем кол-во оценок
                        }
                            
                    }
                }

            }
            string result;
            if (all.Count > 0)
            {
            double max = all[0].info.mark / all[0].count;
            result = all[0].info.subject;
            int size = all.Count;
            for(int k=1; k < size; k++){
                double tmp = all[k].info.mark / all[k].count;
                if (tmp > max)
                {
                    max = tmp;
                    result = all[k].info.subject;
                }
             }
            }
            else
            {
                result = "нет";
            }
            return result;
        }

        public void Display()
        {
            foreach (Student x in list)
            {
                string[] newmas = x.ToText();
                foreach (string elem in newmas)
                {
                    Console.WriteLine(elem);
                }
            }
        }

        //бинарная сериализация
        //Сохранить как бинарный файл
        public void SaveBin(string fileName)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream writer = new FileStream(fileName, FileMode.Create))
            {
                bf.Serialize(writer, list);
            }
        }

        //загрузить из бинарного файла
        public void LoadBin(string fileName)
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
            XmlSerializer writer = new XmlSerializer(typeof(StudentList));

            // получаем поток, куда будем записывать сериализованный объект
            FileStream sw = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            StreamWriter file = new StreamWriter(sw);
            writer.Serialize(file, this);
            file.Close();
        }

        //XML десериализация
        public void LoadXML(string fileName)
        {
            XmlSerializer xf = new XmlSerializer(typeof(StudentList));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                StudentList tmb = (StudentList)xf.Deserialize(fs);
                list = tmb.list;
            }

        }

        //сохранить как текстовый
        public void Savetxt(string fileName)
        {
                StreamWriter stWr = new StreamWriter(fileName, false, Encoding.Default);
                foreach (Student x in list)
                {
                    string[] txt = x.ToText();
                    foreach(string s in txt)
                    stWr.WriteLine(s);
                    stWr.WriteLine();
                }
                stWr.Close();
        }

        //загрузить из текстового
        public void Loadtxt(string fileName)
        {
            list = new List<Student>();
            StreamReader stR = new StreamReader(fileName, Encoding.Default);
            string line;
            while ((line = stR.ReadLine()) != null)
            {
                string[] mas = new string[17];
                mas[0] = line;
                int i = 1;
                while ((i < 17) && ((line = stR.ReadLine()) != null))
                {
                    mas[i] = line;
                    ++i;
                }

                line = stR.ReadLine();
                list.Add(Student.TextToStudent(mas));
            }
            stR.Close();
        }
    }
}
