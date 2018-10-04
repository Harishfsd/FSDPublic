using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDClassApplication
{
    public class Student : Person
    {
        private double d_Percentage;
        public double Percentage
        {
            get { return d_Percentage; }
            set { d_Percentage = value; }
        }

        public Student()
        {

        }
        public Student(string name, double percentage)
            : base(name)
        {
            d_Percentage = percentage;
        }

        public void Display()
        {
            if (isOutStanding())
            {
                Console.WriteLine(string.Format("Name : {0} Percentage :  {1}", this.Name, this.Percentage));
            }
        }

        public override bool isOutStanding()
        {
            return this.Percentage > 85;
        }
    }
}
