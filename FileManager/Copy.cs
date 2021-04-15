using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
    class Copy
    {
        public void CopyDir()   //Копирование директории
        {
            Console.Write("|Введите копируемую директорию:");
            string sourceDir = Console.ReadLine();          //Запрашиваем копируемую директорию
            Console.Write("|Введите конечный адрес:");
            string destinationDir = Console.ReadLine();     //Запрашиваем конечную директорию
            try
            {
                if (sourceDir == null)
                {
                    Console.WriteLine("|Вы не ввели директрию!");
                    CopyDir();
                }
                if (Directory.Exists(destinationDir))      //Если директория уже существует, то копируем все вложенные файлы по заданному пути
                {
                    string[] files = Directory.GetFiles(sourceDir);
                    foreach (string f in files)
                    {
                        var fileName = Path.GetFileName(f);
                        var destFile = Path.Combine(destinationDir, fileName);
                        File.Copy(f, destFile, true);
                    }

                }
                else
                {                                       //Если директория не существует, то создаём её а затем копируем все вложенные файлы по заданному пути
                    Directory.CreateDirectory(destinationDir);
                    string[] files = Directory.GetFiles(sourceDir);
                    foreach (string f in files)
                    {
                        var fileName = Path.GetFileName(f);
                        var destFile = Path.Combine(destinationDir, fileName);
                        File.Copy(f, destFile, true);
                    }
                }
            }
            catch { }
        }

        public void CopyFile()    //Аналогично для копирования файла
        {
            Console.WriteLine("|Введите директорию и имя копируемого файла:");
            string sourceFile = Console.ReadLine();
            Console.WriteLine("|Введите конечный адрес и имя файла:");
            string destinationFile = Console.ReadLine();

            try
            {
                if (sourceFile == null)
                {
                    Console.WriteLine("|Данный файл не существует!");
                    CopyFile();
                }
                if (Directory.Exists(destinationFile))
                {
                    File.Copy(sourceFile, destinationFile);
                }
                
            }
            catch { }
        }
    }
}
