using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            ConsoleKeyInfo k;
            int x = 80;
            int y = 40;
            do
            {
                Console.SetCursorPosition(x, y);
                Console.Write((char)2);
                k = Console.ReadKey(true);
                if (k.Key == ConsoleKey.LeftArrow && x > 0)
                    x--;
                if (k.Key == ConsoleKey.DownArrow && y < 80)
                    y++;
                if (k.Key == ConsoleKey.UpArrow && y > 0)
                    y--;
                if (k.Key == ConsoleKey.RightArrow && x < 160)
                    x++;
                Console.Clear();
            }
            while (k.Key != ConsoleKey.Escape);
        }
    }
}
