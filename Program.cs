using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TestAction> actions = new List<TestAction>();

            for (int i = 0; i < 2; i++)
            {
                TestAction action = new TestAction();
               
                actions.Add(action);
            }

            foreach (var item in actions)
            {
                //item.DoWork();

                item.Run();

            }



            Console.ReadKey();

        }
    }
}
