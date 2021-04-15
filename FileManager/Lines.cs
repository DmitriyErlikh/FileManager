using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class Lines
    {
        public void drawLines()      //Отрисовываем рамку
        {
            drawHorizont(1, 0);          
            drawHorizont(1, 23);
            drawHorizont(1, 26);
            drawVertical(0, 1);
            drawConner(0, 0, 'Т');
            drawConner(95, 0, 'Т');
            drawConner(119, 0, 'Т');
            drawVertical2(95, 1);
            drawVertical(119, 1);
            

        }
        public void drawHorizont(int x, int y)
        {
            for (int i = x; i <= 119; i++)
            {
                Console.SetCursorPosition(i, y);
                Console.Write('_');
            }
        }
        public void drawVertical(int x, int y)
        {
            for (int i = y; i <= 26; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write('|');
            }
        }
        public void drawVertical2(int x, int y)
        {
            for (int i = y; i <= 23; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write('|');
            }
        }
        public void drawConner(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
