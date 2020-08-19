using System;
using System.IO;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // /Volumes/Macintosh HD/Users/sanya/csharp_study/csharp_source/STEP_classwork/lesson_20/fileSystem/homework
            Console.Write("Enter path to file: ");
            string pathToFile = Console.ReadLine();
            if (!File.Exists(pathToFile))
            {
                Console.WriteLine("Wrong path to file");
                while (!File.Exists(pathToFile))
                {
                    Console.Write("Enter path to file again: ");
                    pathToFile = Console.ReadLine();
                }
            }

            var textToWrite = "0 1 1 2 3 5";
            //using (var stream = File.Create("/Volumes/1"))
            using (var stream = new FileStream(pathToFile, FileMode.OpenOrCreate))
            {
                var bytes = Encoding.UTF8.GetBytes(textToWrite);
                //System.Text.Encoding.UTF8.GetBytes(textWrite);
                stream.Write(bytes, 0, bytes.Length);
            }

            int number1 = 0;
            int number2 = 0;
            string str;
            char ch = ' ';
            //string number1;
            using (var stream = new FileStream(pathToFile, FileMode.Open))
            {
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                var text = Encoding.UTF8.GetString(bytes);
                for (int i = 0; i < text.Length; i++)
                {
                    Console.WriteLine($"{text[i]}");
                    number2 = number1;
                    if (i + 1 < text.Length)
                    {
                        if (text[i + 1] == ' ')
                        {
                            Console.WriteLine("Fucking slaves");
                            ch = text[i];
                            Console.WriteLine($"{ch}");
                            //number1 = stream.Read(bytes, i, i);
                            number1 = int.Parse(ch);
                            //Console.WriteLine($"{number1}");
                        }
                        /*else if (text[i + 1] != ' ' && text[i] != ' ')
                        {
                            number1 = text[i];
                            //str = text[i] + text[i + 1];
                            number1 *= 10;
                            number1 += text[i + 1];
                        }*/
                    }
                    //number1 = text[i];
                    //number = int.TryParse(text[i]);
                }
                Console.WriteLine($"{number1}");
                Console.WriteLine($"{number2}");
            }

            //int number = 3;
            //Console.WriteLine($"{Fibonacci(number)}");
        }

        static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }

            return a;
        }
    }
}
