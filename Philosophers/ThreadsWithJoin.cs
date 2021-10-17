using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Philosophers
{
    
    public class ThreadsWithJoin
    {
        private Thread _philosopher1, _philosopher2, _philosopher3, _philosopher4, _philosopher5;

        public ThreadsWithJoin()
        {
            _philosopher1 = new Thread(Eat) { Name = "Аристотель" };
            _philosopher2 = new Thread(Eat) { Name = "Платон" };
            _philosopher3 = new Thread(Eat) { Name = "Сократ" };
            _philosopher4 = new Thread(Eat) { Name = "Кант" };
            _philosopher5 = new Thread(Eat) { Name = "Ницше" };
        }

        public void Start()
        {
            // Можно же сделать так, что философы перед тем, как есть и думать, договорятся о том, кто и когда будет есть 
            _philosopher1.Start();
            _philosopher1.Join();
            _philosopher2.Start();
            _philosopher2.Join();
            _philosopher3.Start();
            _philosopher3.Join();
            _philosopher4.Start();
            _philosopher4.Join();
            _philosopher5.Start();
            _philosopher5.Join();
        }

        private void Eat()
        {
            Console.WriteLine($"Философ {Thread.CurrentThread.Name} берет вилку справа");
            Thread.Sleep(500);
            Console.WriteLine($"{Thread.CurrentThread.Name} берет вилку слева");
            Thread.Sleep(500);
            Console.WriteLine($"{Thread.CurrentThread.Name} ест");
            Thread.Sleep(500);
            Console.WriteLine($"{Thread.CurrentThread.Name} кладет обе вилки на стол");
        }

    }

}
