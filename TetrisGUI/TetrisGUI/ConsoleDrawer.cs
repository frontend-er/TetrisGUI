﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class ConsoleDrawer : IDrawer
    {
        public void DrawPoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('*');
            Console.SetCursorPosition(0, 0);
        }

        public void HidePoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
            Console.SetCursorPosition(0, 0);
        }

        public void InitField()
        {
            Console.SetWindowSize(Field.Width, Field.Heigth);
            Console.SetBufferSize(Field.Width, Field.Heigth);
        }   

        public void WriteGameOver()
        {
            Console.SetCursorPosition(Field.Width / 2 - 8, Field.Heigth / 2);
            Console.WriteLine("G A M E  O V E R");
            Console.SetCursorPosition(0, 0);

        }



    }
}
