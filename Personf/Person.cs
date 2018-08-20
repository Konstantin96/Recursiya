using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personf
{
    public class Person
    {
        public string name { get; set; }
        public int Age { get; set; }

        public void Display()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + Age);
        }
        public string DoB(DateTime dob)
        {
            return string.Format("{0:dd.MM.yy}", dob.Date);
        }
    }

}
