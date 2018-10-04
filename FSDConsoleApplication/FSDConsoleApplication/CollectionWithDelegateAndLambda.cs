using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDConsoleApplication
{
    public class CollectionWithDelegateAndLambda
    {
        public delegate List<int> MyDelegate();
        public CollectionWithDelegateAndLambda()
        {
            m_numberList = new List<int>();
            IntializeList();
        }

        private List<int> m_numberList;

        private void IntializeList()
        {
            for (int i = 1; i <= 100; i++)
            {
                m_numberList.Add(i);
            }
        }
        public void GetLambdaResult()
        {
            Console.Write("\nThe Lambda Result is : \n");
            List<int> outputResult = GetListDivisibleBy3();
            foreach (int i in outputResult)
            {
                Console.Write("{0}\t", i);
            }
        }

        public void GetDelegateResult()
        {
            Console.Write("\nThe delegate Result is : \n");

            //create delegate instances
            MyDelegate objDelegate = new MyDelegate(GetListDivisibleBy3);

            //Calling Delegate methods
            List<int> outputResult = objDelegate();

            foreach (int i in outputResult)
            {
                Console.Write("{0}\t", i);
            }
        }

        private List<int> GetListDivisibleBy3()
        {
            return m_numberList.Where(x => x % 3 == 0).ToList();
        }

    }
}
