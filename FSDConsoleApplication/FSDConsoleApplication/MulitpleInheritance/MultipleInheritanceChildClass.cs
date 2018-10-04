using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDConsoleApplication.MulitpleInheritance
{
    public class MultipleInheritanceChildClass : MultipleInhertianceBaseClass
    {
        public override void FirstInterfaceDisplay()
        {
            base.FirstInterfaceDisplay();
            Console.WriteLine("Display Override method from First Interface ");
        }

        public override void SecondInterfaceDisplay()
        {
            base.SecondInterfaceDisplay();
            Console.WriteLine("Display Override method from Second Interface ");
        }

    }
}
