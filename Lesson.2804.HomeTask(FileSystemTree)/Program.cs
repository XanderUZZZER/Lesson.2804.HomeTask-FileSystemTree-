using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson._2804.HomeTask_FileSystemTree_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 2804 HomeTask\n");

            string path = Directory.GetCurrentDirectory();
            FileSystemTree fst = new FileSystemTree();

            //fst.ShowDirs();
            fst.ShowDirRecurs();

            //DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Xander_UZZZER\Documents\Visual Studio 2015\Projects\Lesson.2804.HomeTask(FileSystemTree)\Lesson.2804.HomeTask(FileSystemTree)\bin\Debug");
            //Console.WriteLine("============Список каталогов=============");
            //foreach (var item in dir.GetDirectories())
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine("==Список подкаталогов==");
            //    foreach (var it in item.GetDirectories())
            //        Console.WriteLine(it.Name);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("==============Список файлов==============");
            //foreach (var item in dir.GetFiles())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //using (var fileStream = File.OpenWrite("file.txt"))
            //{
            //    using (var writer = new StreamWriter(fileStream))
            //    {
            //        for (int i = 0; i < 50; i++)
            //        {
            //            writer.WriteLine(i);
            //        }
            //    }
            //}

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
