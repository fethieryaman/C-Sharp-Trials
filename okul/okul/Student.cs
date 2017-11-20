using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okul
{
    class Student
    {
        private string name, surname, gender, period;

        public string getName
        {
            get { return name; }
        }

        public string getSurname
        {
            get { return surname; }
        }
        
        public string getGender
        {
            get { return gender; }
        }

        public string getPeriod
        {
            get { return period; }
        }

        public Student(string name, string surname, string gender, string period)
        {
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.period = period;
        }

    }
}
