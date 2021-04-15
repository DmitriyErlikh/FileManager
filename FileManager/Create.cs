using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
    public class Create
    {
        public void NewDir(string path)         //Создание директории
        {            
            Directory.CreateDirectory(path);
            Console.WriteLine("Директория успешно создана");
        }
    }
}
