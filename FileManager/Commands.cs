using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class Commands
    {
        public void drawCommands()              //Отображаем список текущий команд
        {
            Console.SetCursorPosition(0, 24);
            Console.WriteLine("|Commands: 1 - Перейти к указанной директории; 2 - Копировать директорию; 3 - Копировать файл; 4 - Создать директорию;");
            Console.WriteLine("|5 - Удалить директорию; 6 - Удалить файл; n - след. страница;  p - пред. страница; 0 - Выход.");
        }
    }
}
