using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
    public class Info
    {   
        
        public void writeInfo(string path)
        {
            
            var disc = DriveInfo.GetDrives();               //Собираем спиок текущих дисков
            string currentDisk = Path.GetPathRoot(path);    //Смотрим текущий диск
            

            for (var i = 0; i <disc.Length; i++)
            {
                if(Convert.ToString(disc[i]).Equals(currentDisk))           //Выводим информацию о текущем диске
                {
                    Console.SetCursorPosition(96, 1);
                    Console.Write($"Name: {disc[i].Name}");
                    Console.SetCursorPosition(96, 2);
                    Console.Write($"Format: {disc[i].DriveFormat}");
                    Console.SetCursorPosition(96, 3);
                    Console.Write("Total Size: " + disc[i].TotalSize/ 1024 / 1024 / 1024 + " Gb");
                    Console.SetCursorPosition(96, 4);
                    Console.Write("Free Space: " + disc[i].TotalFreeSpace/1024 / 1024 +" Mb");
                }
            }
            
            
            Console.WriteLine("");
        }
    }
}
