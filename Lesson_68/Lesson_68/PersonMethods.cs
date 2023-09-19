using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    partial class Person
    {
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public partial void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }
        private int b;
    }
}