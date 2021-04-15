using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace FileManager
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string defPath = @"C:\";        //Начальный путь
            int padgeNumber = 1;            //Старт с 1ой страницы
            Console.BackgroundColor = ConsoleColor.Cyan;        //Задаём цвет консоли
            Console.ForegroundColor = ConsoleColor.Black;
            Program man = new Program();
            man.Manager(defPath, padgeNumber);          //Вызываем менеджер
            


        }

        public void Manager(string Path, int padgeNumber)
        {
            string jsonPath = JsonSerializer.Serialize(Path);
            File.WriteAllText("Path.json", jsonPath);
            Console.Clear();
            Console.CursorVisible = false;
            
            Lines Line = new Lines();           //Отрисовываем рамку
            Line.drawLines();

            FileTree Tree = new FileTree();     //Формируем дерево директорий и объектов
            Tree.Tree(Path, padgeNumber);

            Info WriteInfo = new Info();        //Формируем информацию о текущем диске
            WriteInfo.writeInfo(Path);

            Commands drawCommand = new Commands();  //Отображаем список доступных команд
            drawCommand.drawCommands();

            Copy copy = new Copy();

            Create newDir = new Create();

            Delete del = new Delete();

            Console.SetCursorPosition(1, 27);
            string newPath;
            
            string input = Console.ReadLine();      //Запрос на ввод команды
                        
            switch (input)
            {
                case "1":                                                       //Переход в директорию
                    Console.Write("|Введите адрес директории:");
                    newPath = Console.ReadLine();
                    Manager(newPath, padgeNumber);
                    break;
                case "2":                                                       //Копирование директории
                    copy.CopyDir();
                    Manager(Path, padgeNumber);
                    break;
                case "3":                                                       //Копирование файла
                    copy.CopyFile();
                    Manager(Path, padgeNumber);
                    break;
                case "4":                                                       //Создание новой директории
                    Console.Write("|Введите название директории:");
                    newPath = Console.ReadLine();
                    newDir.NewDir(newPath);
                    Manager(newPath, padgeNumber);
                    break;
                case "5":                                                       //Удаление директории
                    del.deleteDir();
                    Manager(Path, padgeNumber);
                    break;
                case "6":                                                       //Удаление файла
                    del.deleteFile();
                    Manager(Path, padgeNumber);
                    break;
                case "n":                                                       //Следущая станица списка
                    padgeNumber++;
                    Manager(Path, padgeNumber);
                    break;
                case "p":                                                       //Предыдущая станица списка
                    padgeNumber--;
                    Manager(Path, padgeNumber);
                    break;
                case "0":                                                       //Выход
                    Environment.Exit(0);                  
                    break;
            }
        }       
    }
}
