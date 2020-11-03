using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Synchroon();
            //AsynchroonAPM();
            //AsynchroonTPL();
            //DeHippeManier();
            //MoreFunWithTasks();
            //LessFun();
            //MoreAsync();
            //ParallelAsync();
            YogaLes();

            Console.WriteLine("En verder....");
            Console.ReadLine();
        }

        static object stokje = new object();
        private static void YogaLes()
        {
            int nummer = 0;
            //object stokje = new object();
            List<int> list = new List<int>(); // Geen enkele collectie is veilig. (Thread safe)
            ConcurrentBag<int> bag = new ConcurrentBag<int>();  // Wel thread safe
            
            
            Parallel.For(0, 20, idx => {
                lock (stokje)
                {
                    int tmp = nummer;
                    Task.Delay(500).Wait();
                    nummer = tmp + 1;
                }
            });

            Console.WriteLine(nummer);
        }

        private static void ParallelAsync()
        {
            Random rnd = new Random();

            SemaphoreSlim sema = new SemaphoreSlim(10, 10);

            Parallel.For(0, 200, idx =>{
                Console.WriteLine($"Taak {idx} wacht");
                sema.Wait();
                Console.WriteLine($"Taak {idx} begint");
                Task.Delay(rnd.Next(10000, 20000)).Wait();
                sema.Release();
                Console.WriteLine($"Taak {idx} is klaar");
            });

            //int a = 0;
            //int b = 0;

            //var t1 = AddAsync(1, 2);
            //var t2 = AddAsync(3, 4);
            //Task.WaitAll(t1, t2);

            //Parallel.Invoke(() =>
            //{
            //    Task.Delay(5000).Wait();
            //    a = 42;
            //},
            //() =>
            //{
            //    Task.Delay(2000).Wait();
            //    b = 20;
            //});

            //int result = a + b;
            //Console.WriteLine(result);
        }

        private static async void MoreAsync()
        {
            int a = 0;
            int b = 0;

            var t1 =  Task.Run(() => {
                Task.Delay(5000).Wait();
                a = 42;
            });
            var t2 = Task.Run(() => {
                Task.Delay(2000).Wait();
                b = 20;
            });

            //Task.WaitAny(t1, t2); // Blocking
            await Task.WhenAny(t1, t2); // awaitable

            int result = a + b;
            Console.WriteLine(result);
        }

        private static async void LessFun()
        {
            // Kan niet
            //try
            //{
            //    LessAsync();
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            // Zo heurt het
            //LessAsync().ContinueWith(pt =>
            //{
            //    if (pt.Exception != null)
            //    {
            //        Console.WriteLine(pt.Exception.InnerException.Message);
            //    }
            //});

            // Of...
            try
            {
                await LessAsync();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private static Task LessAsync()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Start!");
                throw new Exception("Oooops");
            });
        }

        private static void MoreFunWithTasks()
        {
            CancellationTokenSource nikko = new CancellationTokenSource();

            FunAsync(nikko.Token);

            Task.Delay(6000).Wait();

            nikko.Cancel();

        }

        private static Task FunAsync(CancellationToken bom)
        {
            return Task.Run(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (bom.IsCancellationRequested)
                    {
                        return;
                    }
                    Console.WriteLine($"Hoi {i}");
                    Task.Delay(300).Wait();
                }
            });
        }

        private static async void DeHippeManier()
        {
            //Task<int> t1 = Task.Run(() => Add(4, 5));

            int res = await AddAsync(2, 3);
            Console.WriteLine("We gaan doorrrrr");

            Console.WriteLine(res);

            res = await AddAsync(4, 5);
            Console.WriteLine("We gaan doorrrrr");
            Console.WriteLine(res);
        }

        private static void AsynchroonTPL()
        {
            Task<int> t1 = new Task<int>(() =>
            {
                int result = Add(2, 3);
                return result;
            });

            t1.ContinueWith(vorigeTaak =>
            {
                Console.WriteLine(vorigeTaak.Result);
            }).ContinueWith(vt => Console.WriteLine("Done"));

            t1.Start();


            Task.Run(() => Add(4, 5))
                .ContinueWith(vorigeTaak =>
                {
                    Console.WriteLine(vorigeTaak.Result);
                }).ContinueWith(vt => Console.WriteLine("Done"));
            //Console.WriteLine(t1.Result);

        }

        // Asynchronous Programming Model (Ouwe meuk)
        private static void AsynchroonAPM()
        {
            Func<int, int, int> m1 = Add;

            //IAsyncResult ar = m1.BeginInvoke(1, 2, RoepAanWanneerKlaar, m1);
            m1.BeginInvoke(1, 2, ar =>
            {
                int result = m1.EndInvoke(ar);
                Console.WriteLine(result);
            }, null);

            //while(!ar.IsCompleted)
            //{
            //    Console.Write(".");
            //    Task.Delay(100).Wait();
            //}

        }

        static void RoepAanWanneerKlaar(IAsyncResult ar)
        {
            Func<int, int, int> m1 = ar.AsyncState as Func<int, int, int>;
            int result = m1.EndInvoke(ar);
            Console.WriteLine(result);
        }

        private static void Synchroon()
        {
            int result = Add(2, 3);
            Console.WriteLine(result);
        }

        static async Task<int> DoeIets()
        {
            //await Task.Delay(0);
            return await Task.FromResult(42);
        }

        static int Add(int a, int b)
        {
            Task.Delay(5000).Wait();
            return a + b;
        }
        static Task<int> AddAsync(int a, int b)
        {
            return Task.Run(() => Add(a, b));
        }
    }
}
