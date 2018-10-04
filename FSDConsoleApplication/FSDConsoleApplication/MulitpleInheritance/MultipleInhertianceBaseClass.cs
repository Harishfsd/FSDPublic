using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDConsoleApplication.MulitpleInheritance
{
    public class MultipleInhertianceBaseClass : IFirstInterface, ISecondInterface
    {

        public virtual void FirstInterfaceDisplay()
        {
            Console.WriteLine("Display Virtual method from First Interface ");
        }


        public virtual void SecondInterfaceDisplay()
        {
            Console.WriteLine("Display Virtual method from second Interface ");
        }
    }
}
