using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
    class Delete
    {
        public void deleteDir()         //Удаление директории
        {
            Console.WriteLine("Введите удаляемую директорию:");
            string sourceDir = Console.ReadLine();              //Запрашиваем адрес удаляемой директории
            DirectoryInfo dir = new DirectoryInfo(sourceDir);
            if (Directory.Exists(sourceDir))
            {
                Console.Clear();
                Console.WriteLine("Вы действительно хотите удалить директорию и все вложенные файлы? (Y/N)");           //Спросим подтверждние
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Y":
                        dir.Delete(true);                   
                        Console.WriteLine("Директория успешно удалена");
                        break;
                    case "N":
                        break;
                    default:
                        break;
                }       
            }
            else
            {
                Console.WriteLine("Данной директории не существует!");
                deleteDir();
            }
            
        }

        public void deleteFile()         //Аналогично для удаления файла
        {
            Console.WriteLine("Введите директорию и имя удаляемого файла:");
            string sourceFile = Console.ReadLine();

            if (Directory.Exists(sourceFile))
            {
                Console.Clear();
                Console.WriteLine("Вы действительно хотите удалить файл? (Y/N)");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Y":
                        File.Delete(sourceFile);
                        Console.WriteLine("Директория успешно удалена");
                        break;
                    case "N":
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Данного файла не существует!");
                deleteFile();
            }
            
        }
    }
}
