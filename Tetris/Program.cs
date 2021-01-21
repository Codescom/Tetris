using System;
using System.Dynamic;

namespace Tetris
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!**");

            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
            
            int x1 = 2, y1 = 3;
            char c1 = '*';

            Draw(x1, y1, c1);

            int x2 = 2, y2 = 3;
            char c2 = '#';


            Draw(x2, y2, c2);




            Console.ReadLine();

        }
    
        static void Draw(int x, int y, char ch)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(ch);

        }
    
    }
}
