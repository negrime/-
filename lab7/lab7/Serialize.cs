using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace lab7
{
    class  Serialize
    {
        public static Student GetStudent()
        {
            Student student = null;
            FileStream fs = new FileStream("test.xml", FileMode.Open);
            XmlSerializer xser = new XmlSerializer(typeof(Student));
            student = (Student)xser.Deserialize(fs);
            fs.Close();
            return student;
        }
        public static void Save(Student student)
        {
            FileStream fs = new FileStream("test.xml", FileMode.Create);

            XmlSerializer xser = new XmlSerializer(typeof(Student));
            xser.Serialize(fs, student);
            fs.Close();
            
        }

    }
}
