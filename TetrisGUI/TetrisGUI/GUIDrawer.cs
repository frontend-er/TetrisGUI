using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;


namespace Tetris
{
    class GUIDrawer : IDrawer
    {

        const int SIZE = 20;
        public void DrawPoint(int x, int y)
        {
            GraphicsWindow.PenColor = "DarKBlue";
            GraphicsWindow.PenWidth = 2;
            GraphicsWindow.DrawRectangle(x * SIZE, y * SIZE, SIZE, SIZE);
        }

        public void HidePoint(int x, int y)
        {
            GraphicsWindow.PenColor = "LIghtBlue";
            GraphicsWindow.PenWidth = 2;
            GraphicsWindow.DrawRectangle(x * SIZE, y * SIZE, SIZE, SIZE);
        }

        public void InitField()
        {
            GraphicsWindow.BackgroundColor = "LIghtBlue";
            GraphicsWindow.Width = Field.Width * SIZE;
            GraphicsWindow.Height = Field.Heigth * SIZE;
        }

        public void WriteGameOver()
        {
            GraphicsWindow.BrushColor = "Red";
            GraphicsWindow.FontSize = 20;
            GraphicsWindow.DrawText((Field.Width / 2 - 4 )* SIZE,( Field.Heigth / 2) * SIZE, " G A M E  O V E R");
        }
    }
}
