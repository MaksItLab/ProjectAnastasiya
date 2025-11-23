using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Server server = new Server();
            //Logger logger = new Logger();
            //Notifier notifier = new Notifier();

            //server.ClientConnected += logger.LogConnection;
            //server.ClientConnected += notifier.SendWelcomeMessage;

            //server.ConnectClient();

            //Car car = new Car();
            //Wheels wheels = new Wheels();

            //car.CarStarted += () => Console.WriteLine("Машина завелась");
            //wheels.WheelsUnblocked += () => Console.WriteLine("Колеса разблокированы");

            //car.StartCar();
            //wheels.Start();

            //Thread thread = new Thread(Work);
            //thread.Start();
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.WriteLine("-");
            //}

            //int counter = 0;
            //object lockObject = new object();

            //Thread t1 = new Thread(() => 
            //{
            //    for (int i = 0; i < 100_000; i++)
            //    {
            //        Monitor.Enter(lockObject);
            //        try
            //        {
            //            counter++;
            //        }
            //        finally
            //        {
            //            Monitor.Exit(lockObject);
            //        }
            //    }
            //});

            //Thread t2 = new Thread(() =>
            //{
            //    for (int i = 0; i < 100_000; i++)
            //    {
            //        lock (lockObject)
            //        {
            //            counter++;
            //        }
            //    }
            //});

            //t1.Start();
            //t2.Start();


            //t2.Join();

            //Console.WriteLine(counter);

            //object lockA = new object();
            //object lockB = new object();

            //void Thread1()
            //{
            //    if (Monitor.TryEnter(lockB, 1000))
            //    {
            //        try
            //        {
            //            lock (lockA)
            //            {
            //                Console.WriteLine("Thread1: lockA");
            //                Thread.Sleep(100);

            //                lock (lockB)
            //                {
            //                    Console.WriteLine("Thread1: lockB");
            //                }
            //            }
            //        }
            //        finally
            //        {
            //            Monitor.Exit(lockB);
            //        } 
            //    }
            //}

            //void Thread2()
            //{
            //    if(Monitor.TryEnter(lockA, 1000))
            //    {
            //        try
            //        {
            //            lock (lockB)
            //            {

            //                Console.WriteLine("Thread2: lockB");
            //                Thread.Sleep(100);

            //                lock (lockA)
            //                {
            //                    Console.WriteLine("Thread2: lockA");
            //                }
            //            }
            //        }
            //        finally
            //        {
            //            Monitor.Exit(lockA);
            //        }
            //    }
            //}

            //new Thread(Thread1).Start();
            //new Thread(Thread2).Start();

            //Thread lowPriority = new Thread(() =>
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("Low priority executing...");
            //        Thread.Sleep(1000);
            //        Console.WriteLine("End of Low priority thread");
            //    }
            //});

            //lowPriority.Priority = ThreadPriority.Lowest;

            //Thread highPriority = new Thread(() =>
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("High priority executing...");
            //        // практический бесконечный цикл
            //    }
            //});

            //highPriority.Priority = ThreadPriority.Highest;

            //lowPriority.Start();
            //highPriority.Start();
            ReaderWriterLockSlim rw = new ReaderWriterLockSlim();
            var semaphore = new SemaphoreSlim(1, 1);
            //
            void Reader()
            {
                while (true)
                {
                    //while (writerWaiting)
                    //{
                    //    Thread.Sleep(10);
                    //}

                    //rw.EnterReadLock();
                    semaphore.Wait();
                    Console.WriteLine("Reader reading...");
                    Thread.Sleep(100);
                    semaphore.Release();
                    //rw.ExitReadLock();
                }
            }

            void Writer()
            {
                while (true)
                {
                    //writerWaiting = true;
                    //rw.EnterWriteLock();
                    semaphore.Wait();
                    Console.WriteLine("Writer writing...");
                    Thread.Sleep(200);
                    semaphore.Release();
                    //rw.ExitWriteLock();
                    //writerWaiting = false;
                    //Thread.Sleep(200);
                }
            }

            new Thread(Reader).Start();
            new Thread(Reader).Start();
            new Thread(Reader).Start();
            new Thread(Reader).Start();
            new Thread(Writer).Start();

        }

        public static volatile bool writerWaiting = false;


        public static void Work()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Hello!");
            }
        }

    }

    public class Engine
    {
        public event Action Started;

        public void Start()
        {
            Started?.Invoke();
        }
    }

    public class Car : EventArgs
    {
        private Engine engine = new Engine();

        public event Action CarStarted;

        public Car()
        {
            engine.Started += () => CarStarted?.Invoke();
        }

        public void StartCar()
        {
            Console.WriteLine("Запусаем двигатель");
            engine.Start();
        }
    }

    public class Wheels
    {
        private Engine engine = new Engine();

        public event Action WheelsUnblocked;

        public Wheels()
        {
            engine.Started += () => WheelsUnblocked?.Invoke();
        }

        public void Start()
        {
            engine.Start();
        }
    }

    public class Server
    {
        public event Action<string, int> ClientConnected;

        public void ConnectClient()
        {
            Console.WriteLine("Клиент подключился");
            ClientConnected?.Invoke("hello", 10);
            Console.WriteLine("Клиент подключился");
            ClientConnected?.Invoke("hello", 10);
        }
    }

    public class Logger
    {
        public void LogConnection(string mess, int a)
        {
            Console.WriteLine("LOG: Клиент подключен");
        }
    }

    public class Notifier
    {
        public void SendWelcomeMessage(string mess, int a)
        {
            Console.WriteLine("NOTIFY: Добро пожаловать!");
        }
    }

}
