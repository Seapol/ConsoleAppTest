using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;

namespace ConsoleAppTest
{
    class TestAction
    {

        public TestAction()
        {

        }

        public void DoWork()
        {
            int CursorLeft = 0;
            int CursorTop = Thread.CurrentThread.ManagedThreadId + 1 ;

            for (int i = 0; i < 1000; i++)
            {
                Console.SetCursorPosition(CursorLeft, CursorTop);
                Console.WriteLine(string.Format("{0}: {1}", Thread.CurrentThread.ManagedThreadId, i));
                Thread.Sleep(10);
            }

            WebClient client = new WebClient();
            string result = client.DownloadString("https://www.baidu.com/");
            Console.WriteLine(result);
        }

        public void Run()
        {
            Thread thread = new Thread(new ThreadStart(DoWork));

            thread.Start();
            thread.Join();
        }
    }
}
