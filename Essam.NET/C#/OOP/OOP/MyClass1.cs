using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
  public partial class Person
    {
        public int age { get; set; }

        partial void PrintAge();

        public void BirthDay()
        {
            age++;
            PrintAge();
        }

    }
}
