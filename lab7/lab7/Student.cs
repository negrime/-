using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Student
    {
        
        public string name;
        private int _groupNumber;
        public int groupNumber
        {
            get
            {
                return _groupNumber;
            }
            set
            {
                if (value >= 0)
                    _groupNumber = value;
            }
        }
        public  enum Mark
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5
        }
        public Session[] sessions = new Session[Form1.semester];

        public Student()
        {
            name = "";
            groupNumber = 0;
            for (int i = 0; i < Form1.semester; i++)
            {
                sessions[i].exams = new string[Form1.subjects];
                sessions[i].marks = new string[Form1.subjects];
            }
         
        }
    
        public struct Session
        {
            public string[] exams;
            public string[] marks;
        }
    }
  
}
