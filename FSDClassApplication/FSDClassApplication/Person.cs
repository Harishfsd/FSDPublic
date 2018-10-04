using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDClassApplication
{
    public abstract class Person
    {
        private string s_Name;
        public string Name
        {
            get { return s_Name; }
            set { s_Name = value; }
        }
        public Person()
        {

        }
        public Person(string name)
        {
            s_Name = name;
        }
        
        public abstract bool isOutStanding();


    }
}
