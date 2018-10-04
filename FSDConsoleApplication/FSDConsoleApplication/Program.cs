using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSDConsoleApplication.MulitpleInheritance;

namespace FSDConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 2d 3x3 Array
            Console.WriteLine("2D 3x3 Matrix ");
            TwoDimensionalArray3x3Matrix objArray = new TwoDimensionalArray3x3Matrix();
            objArray.PrintArray();
            Console.WriteLine();


            //2. Multiple Inheritance , Virutal, Override
            Console.WriteLine(" Multiple Inheritance , Virutal, Override  \n");
            MultipleInheritanceChildClass objChildClass = new MultipleInheritanceChildClass();
            objChildClass.FirstInterfaceDisplay();
            objChildClass.SecondInterfaceDisplay();
            Console.WriteLine();

            //3. Lambda and delegates
            Console.WriteLine("Lambda and delegates  \n");
            CollectionWithDelegateAndLambda objCollection = new CollectionWithDelegateAndLambda();
            objCollection.GetLambdaResult();
            objCollection.GetDelegateResult();
            Console.WriteLine();

            //4. Email check using Regex
            Console.WriteLine("Email check using Regex  \n");
            StringExtension objString = new StringExtension();
            objString.CheckEmail();
            Console.WriteLine();

            Console.Read();

        }
    }
}
