using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParallelWorld.Domain.Models
{
    public class ThreadModel
    {
        public string ThreadMaster(string s)
        {
            Thread.Sleep(5000);

            var t1 = new Thread(() =>
            {
                System.Console.WriteLine("hello");
            });

            var t2 = new Thread(() =>
            {
                Writer('B',1000);
            });

            System.Console.WriteLine("fred");

            t1.Start();
            t2.Start();

            t1.Join();
            return s;

            private void Writer(string s, int count)
            {
                for (int i = 0; i < count; i++)
                {
                    System.Console.Write(c);
                }
            }
        }
    }
}
