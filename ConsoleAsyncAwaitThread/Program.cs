using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAsyncAwaitThread
{
    internal class Program
    {
        public static object locker = new object();

        public static int i1 = 100;

        // Дэд лок
        #region Dead LOCK
        //static void M1()
        //{
        //    for (int i = 0; i <= i1; i++)
        //    {

        //    }            
        //}
        //static void M2()
        //{
        //    for (int i = i1; i >= i1; i--)
        //    {

        //    }      
        //}
        #endregion

        static void Main(string[] args)
        {
            // Потоки
            #region THREAD
            //// Поток без параметра
            //Thread thread = new Thread(new ThreadStart(DoWork));            
            //thread.Start();

            //// Поток с параметром
            //Thread thread2 = new Thread(new ParameterizedThreadStart(DoWork2));
            //thread2.Start(int.MaxValue);

            //int j = 0;

            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    j++;

            //    if (j % 10000 == 0)
            //    {
            //        Console.WriteLine("Do work main");
            //    }
            //}
            #endregion
            // Асинхронность
            #region async/await
            //DoWorkAsync();

            //int j = 0;

            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    j++;

            //    if (j % 10000 == 0)
            //    {
            //        Console.WriteLine("Do work");
            //    }
            //}
            #endregion
            // Задачи
            #region Task
            //var result = SaveFileAsync("test.txt");
            //var input = Console.ReadLine();
            //Console.WriteLine(result.Result);
            #endregion

            
        }

        static async Task<bool> SaveFileAsync(string path)
        {
            var result = await Task.Run(() => SaveFile(path));

            return result;
        }

        static bool SaveFile(string path) 
        {
            lock (locker)
            {
                Random rnd = new Random();
                string text = "";
                for (int i = 0; i < 50000; i++)
                {
                    text += rnd.Next();
                }
            }
                
            using (var sw = new StreamWriter(path,false,Encoding.UTF8))
            {
                sw.WriteLine();

            }

            return true;
        }

        static async Task DoWorkAsync()
        {
            await Task.Run(() => DoWork());
            Console.WriteLine("Do work Async");
        }

        static void DoWork() 
        {
            int j = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                j++;

                if (j%10000==0)
                {
                    Console.WriteLine("Do work!!!");
                }
            }
        }
        
        static void DoWork2(object max) 
        {

            int j = 0;

            for (int i = 0; i < (int)max; i++)
            {
                j++;
            

                if (j % 10000 == 0)
                {
                    Console.WriteLine("Do work-2");
                }
            }
        }

    }
}
