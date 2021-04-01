using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleList
{
    class People
    {
        private int _age;
        private string _name;
        private string _job;
        

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public string Name { get { return _name; } set { _name = value; } }
        public string Job
        {
            get
            {
                return _job;
            }
            set
                {
                if (_age < 18)
                    _job = "Безработный";
                else
                _job = value;
                }
        }
        public People(string name,int age,string job)
        {
            Age =age;
            Job = job;
            Name = name;
        }
        public void PrintAllInfo()
        {
            Console.WriteLine("Имя:" +_name + "\nВозраст:" + _age + "\nРабота:" + _job);
        }
    }
}
