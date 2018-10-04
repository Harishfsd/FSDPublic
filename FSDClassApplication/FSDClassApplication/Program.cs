using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDClassApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] objPerson = new Person[5];
            objPerson[0] = new Professor("Professor1", 5);
            objPerson[1] = new Professor("Professor2", 8);
            objPerson[2] = new Professor("Professor3", 3);
            objPerson[3] = new Student("Student1", 90);
            objPerson[4] = new Student("Student2", 70);

            foreach (Person per in objPerson)
            {
                if (per is Professor)
                    ((Professor)per).Print();
                if (per is Student)
                    ((Student)per).Display();
            }

            Console.Read();
        }
    }
}
