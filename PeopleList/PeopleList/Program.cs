using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleList
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People("Oleg",15,"IT");
            
            people.PrintAllInfo();

        }
    }
}
