using System;
using System.Dynamic;

namespace Tetris
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.SetWindowSize(30, 40);
            Console.SetBufferSize(30, 40);


            Point p1 = new Point();
            p1.x = 2;
            p1.y = 5;
            p1.c = '*';

            p1.Draw();

            Point p2 = new Point();
            p2.x = 5;
            p2.y = 8;
            p2.c = '*';

            p2.Draw();






            Console.ReadLine();

        }
    
    }
}
