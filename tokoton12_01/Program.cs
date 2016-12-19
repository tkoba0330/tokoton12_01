using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tokoton12_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Thread((x) =>
            {
                for (;;)
                {
                    Console.WriteLine(DateTime.Now.Second);
                    Thread.Sleep(1000);
                }
            });

            Console.WriteLine("Type Enter Key to stop!");
            t.Start();

            Console.WriteLine(Console.ReadLine());
            t.Abort();
        }
    }
}
