using System;
using System.Text;
using System.IO;

namespace FileSystemTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            // /Volumes/Macintosh HD/Users/sanya/csharp_study/csharp_source/STEP_classwork/lesson_20/fileSystem
            Console.Write("Enter path to save the file: ");
            string pathToSave = Console.ReadLine();
            Console.Write("Enter file name: ");
            string fileName = Console.ReadLine();
            string pathToFile = pathToSave + "/" + fileName;

            if (!File.Exists(pathToFile))
            {
                //using (var stream = File.Create("/Volumes/Macintosh HD/Users/sanya/csharp_study/csharp_source/STEP_classwork/lesson_20/fileSystem/file")){}
                using (var stream = File.Create(pathToFile)){}
            }

            //using (var stream = new FileStream(path, FileMode.Create)){}
            //var stream = new FileStream(path, FileMode.Create);
            //using (var stream = File.Create("/Volumes/Macintosh HD/Users/sanya/csharp_study/csharp_source/STEP_classwork/lesson_20/fileSystem/file"))

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            //using (var writeStream = new StreamWriter("/Volumes/Macintosh HD/Users/sanya/csharp_study/csharp_source/STEP_classwork/lesson_20/fileSystem/file"))
            using (var writeStream = new StreamWriter(pathToFile))
            {
                /*var bytes = Encoding.UTF8.GetBytes("Name: " + name + "\n");
                stream.Write(bytes, 0, bytes.Length);
                bytes = Encoding.UTF8.GetBytes("Surname: " + surname + "\n");
                stream.Write(bytes, 0, bytes.Length);
                bytes = Encoding.UTF8.GetBytes("Age" + age + "\n");
                stream.Write(bytes, 0, bytes.Length);*/
                writeStream.WriteLine(name);
                writeStream.WriteLine(surname);
                writeStream.WriteLine(age);
            }
        }
    }

}
