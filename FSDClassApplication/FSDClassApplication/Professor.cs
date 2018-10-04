using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDClassApplication
{
    public class Professor : Person
    {
        private int i_bookPublished;
        public int BookPublished
        {
            get { return i_bookPublished; }
            set { i_bookPublished = value; }
        }

        public Professor()
        {

        }
        public Professor(string name, int bookPublished)
            : base(name)
        {
            i_bookPublished = bookPublished;
        }

        public void Print()
        {
            if (isOutStanding())
            {
                Console.WriteLine(string.Format("Name : {0} Books Published : {1}", this.Name, this.BookPublished));
            }
        }

        public override bool isOutStanding()
        {
            return this.BookPublished > 4;
        }
    }
}
