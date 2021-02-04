using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TetrisGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.Width = 100;
            GraphicsWindow.Height = 100;

            GraphicsWindow.BackgroundColor = "LightBlue";

            GraphicsWindow.DrawRectangle(20, 20, 5, 5);
        }
    }
}
