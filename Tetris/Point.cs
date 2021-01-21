using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Point
    {
        public int x, y;
        public char c;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);

        }



    }
}
