﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Philosophers
{
    public class ThreadsWithLock
    {
        private Thread _philosopher1, _philosopher2, _philosopher3, _philosopher4, _philosopher5;

        public ThreadsWithLock()
        {
            _philosopher1 = new Thread(Eat) { Name = "Аристотель" };
            _philosopher2 = new Thread(Eat) { Name = "Платон" };
            _philosopher3 = new Thread(Eat) { Name = "Сократ" };
            _philosopher4 = new Thread(Eat) { Name = "Кант" };
            _philosopher5 = new Thread(Eat) { Name = "Ницше" };
        }

        public void Start()
        {
            _philosopher1.Start();
            _philosopher2.Start();
            _philosopher3.Start();
            _philosopher4.Start();
            _philosopher5.Start();
        }

        private int x = 0;
        private object locker = new object();

        private void Eat()
        {
            lock(locker)
            {
                x = 1;
                Console.WriteLine($"Философ {Thread.CurrentThread.Name} берет вилку справа");
                Thread.Sleep(500);
                Console.WriteLine($"{Thread.CurrentThread.Name} берет вилку слева");
                Thread.Sleep(500);
                Console.WriteLine($"{Thread.CurrentThread.Name} ест");
                Thread.Sleep(500);
                Console.WriteLine($"{Thread.CurrentThread.Name} кладет обе вилки на стол");

                x++;
                Thread.Sleep(1000);
            }
        }
    }
}
