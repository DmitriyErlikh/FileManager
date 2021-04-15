using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace FileManager
{
    public class FileTree
    {
           
        public void Tree(string NewPath, int padgeNumber)
        {
            
            string [] list = Directory.GetFileSystemEntries(NewPath);           //Формируем список файлов и директорий
            double padge = list.Length / (double) 20;                           //Считаем кол-во страниц
            var padges =Convert.ToInt16( Math.Ceiling(padge));
            
            int n = 0;
            Console.SetCursorPosition(80, 22);
            Console.Write($"Страница {padgeNumber} из {padges}");
            

            

            if (padgeNumber == 1)
            {
                for (var i = 0; i < 20; i++)                                //Выводим информацию в консоль в зависимости от выбранной страницы
                {
                    
                    Console.SetCursorPosition(1, n + 1);
                    
                    try
                    {
                        if (File.Exists(list[i]))
                        {
                            long size = new FileInfo(list[i]).Length/1024 ;
                            Console.Write(Path.GetFileName(list[i].PadRight(70, '.')) + Convert.ToString(size)+" Kb");
                        }
                        else
                        {
                            Console.Write(Path.GetFileName(list[i]).PadRight(67, '.')+"dir");
                        }
                    }
                    catch { }
                    n++;
                }
            }
            else
            {
                if (padgeNumber == 2)
                {
                    for (var i = 20; i < 40; i++)
                    {
                        
                        Console.SetCursorPosition(1, n + 1);
                        n++;
                        try
                        {
                            if (File.Exists(list[i]))
                            {
                                long size = new FileInfo(list[i]).Length;
                                Console.Write(Path.GetFileName(list[i].PadRight(70, '.')) + Convert.ToString(size) + " byte");
                            }
                            else
                            {
                                Console.Write(Path.GetFileName(list[i]).PadRight(67, '.') + "dir");
                            }
                        }
                        catch { }
                    }
                }
                else
                {
                    for (var i = 40; i < 60; i++)
                    {
                        
                        Console.SetCursorPosition(1, n + 1);
                        n++;
                        try
                        {
                            if (File.Exists(list[i]))
                            {
                                long size = new FileInfo(list[i]).Length;
                                Console.Write(Path.GetFileName(list[i].PadRight(70, '.')) + Convert.ToString(size) + " byte");
                            }
                            else
                            {
                                Console.Write(Path.GetFileName(list[i]).PadRight(60, '.') + "dir");
                            }
                        }
                        catch { }
                    }
                }
            } 
        }
    }
}
