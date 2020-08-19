using System;
using System.IO;
using System.Text;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Укажите путь на файл: ");
            //string path = Console.ReadLine();
            string path = "/Volumes/Macintosh HD/Users/sanya/csharp_study/csharp_source/STEP_classwork/lesson_19/test";
            //int number = 0;
            char symbol = (char)0;
            int count = 0;
            using (var stream = new FileStream(path, FileMode.Open))
            {
                var bytes = new byte[stream.Length];
                //var text = Encoding.UTF8.GetString(bytes);
                var text = Encoding.UTF8.GetString(bytes);
                for (int i = 0; i < 256; i++)
                {
                    for (int j = 0; j < stream.Length; j++)
                    {
                        if ((char)text[j] == symbol)
                        {
                            count++;
                        }
                    }

                    if (count != 0)
                    {
                        Console.WriteLine($"Number {symbol} = {count}");
                    }
                    symbol++;
                    count = 0;
                }
            }
        }
    }
}
