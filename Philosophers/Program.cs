using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philosophers
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadsWithJoin threads = new ThreadsWithJoin();
            threads.Start();

            Console.ReadLine();
        }
    }
}
