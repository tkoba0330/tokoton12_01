using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace tokoton12_03
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(say, 1);
            ThreadPool.QueueUserWorkItem(say, 2);
            ThreadPool.QueueUserWorkItem(say, 3);
            ThreadPool.QueueUserWorkItem(say, 4);
            ThreadPool.QueueUserWorkItem(say, 5);
            ThreadPool.QueueUserWorkItem(say, 6);
            Console.WriteLine("Type Enter Key to stop!");
            Console.WriteLine(Console.ReadLine());

        }

        private static void say(object number)
        {
            Console.WriteLine($"Thread is running: {number}");
        }
    }
}
