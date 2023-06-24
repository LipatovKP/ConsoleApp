using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// открыть поток
// прочитать\записать
// закрыть
namespace ConsoleFileAndStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание текстового файла
            using (var sw = new StreamWriter("test.txt", true, Encoding.UTF8))
            {
                sw.WriteLine("Hello, World");
                sw.WriteLine("Hello User");
                sw.WriteLine("Привет Кирилл");
            }
            // Чтение из текстового файла
            using(var sr = new StreamReader("test.txt", Encoding.UTF8))
            {
                // по сточное чтение
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine() + "^^^^");
                }

                sr.DiscardBufferedData();
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                // чтение всего файла
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }


        }
    }
}
