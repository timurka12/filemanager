using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp391
{
    abstract class Filemanager
    {
        public void Info(string name )
        {
            name = Console.ReadLine();

        }
    }
    abstract class CD : Filemanager
    {
        public void cd()
        {
            string filePath = "E:\\Новая папка\\Новая папка\\Новая папка";
            string directoryName;
            int i = 0;

            while (filePath != null)
            {
                directoryName = Path.GetDirectoryName(filePath);
                Console.WriteLine("GetDirectoryName('{0}') returns '{1}'",
                    filePath, directoryName);
                filePath = directoryName;
                if (i == 1)
                {
                    filePath = directoryName + @"\";
                }
                i++;
            }

        }
    }
    abstract class Delete : Filemanager
    {
        public void Del()
        {
            string DeleteThis;
            string pyt;
            Console.WriteLine("Введите имя");
            DeleteThis = Console.ReadLine();
            Console.WriteLine("Введите путь");
            pyt = Console.ReadLine();
            string[] Files = Directory.GetFiles(pyt);

            foreach (string file in Files)
            {
                if (file.ToUpper().Contains(DeleteThis.ToUpper()))
                {
                    File.Delete(file);
                }
            }

        }
    }
    abstract class DelM : Filemanager
    {
        public void delm()
        {
            string DeleteThis1;
            string pyt1;
            Console.WriteLine("Введите маску");
            DeleteThis1 = Console.ReadLine();
            Console.WriteLine("Введите путь");
            pyt1 = Console.ReadLine();
            string[] files = Directory.GetFiles(pyt1, DeleteThis1);
            Console.WriteLine("Всего файлов {0}.", files.Length);
            foreach (string f in files)
            {
                Console.WriteLine(f);
                File.Delete(f);
            }
        }
    }
    abstract class Create : Filemanager
    {
        public void crea()
        {
            string pyt2;
            Console.WriteLine("Введите путь куда создать и имя файла");
            pyt2 = Console.ReadLine();
            File.Create(pyt2);
        }
    }
    abstract class Copy : Filemanager
    {
        public void copy()
        {  
            Console.WriteLine("Введите путь копируемого файла");
            string pathToFile = Console.ReadLine();
            Console.WriteLine("Введите путь куда копировать");
            string pathToFile1 = Console.ReadLine();
            File.Copy(pathToFile, pathToFile1, true);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

