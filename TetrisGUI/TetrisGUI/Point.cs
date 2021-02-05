using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char C { get; set; }

        public void Draw()
        {
            DrawerProvider.Drawer.DrawPoint(X, Y);

        }

        public Point(int a, int b)
        {
            X = a;
            Y = b;
        }

        public Point(Point point)
        {
            this.X = point.X;
            this.Y = point.Y;

        }

        internal void Hide()
        {
            DrawerProvider.Drawer.HidePoint(X, Y);
        }

        internal void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.Down:
                    Y += 1;
                    break;
                case Direction.Left:
                    X -= 1;
                    break;
                case Direction.Right:
                    X += 1;
                    break;
                case Direction.Up:
                    Y -= 1;
                    break;

            }
        }
    }
}
