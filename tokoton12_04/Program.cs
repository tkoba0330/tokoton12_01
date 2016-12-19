using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace tokoton12_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // todo : スレッドプールの使用可能数の制限がわからない
            int workerThreads, completionPortThreads;
            ThreadPool.GetMinThreads(out workerThreads, out completionPortThreads);
            ThreadPool.SetMinThreads(2, completionPortThreads);

            ThreadPool.QueueUserWorkItem(say, 1);
            ThreadPool.QueueUserWorkItem(say, 2);
            ThreadPool.QueueUserWorkItem(say, 3);
            Console.WriteLine("Type Enter Key to stop!");
            Console.WriteLine(Console.ReadLine());
        }

        private static void say(Object number)
        {
            Console.WriteLine($"Thread is running: {number}");
            Thread.Sleep(1000);
            Console.WriteLine($"Thread is done: {number}");
        }
    }
}
