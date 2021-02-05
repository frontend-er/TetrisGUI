using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    abstract class Figure
    {
        const int numberPointsFigure = 4;
        public Point[] Points = new Point[numberPointsFigure];

        public void Draw()
        {
            foreach (Point p in Points)
            {
                p.Draw();
            }
        }

        public void Hide ()
        {
            foreach (Point p in Points)
            {
                p.Hide();
            }
        }

        public Result TryMove(Direction dir)
        {
            Hide();
            Move(dir);


            var result = VerifyPosition();
            if (result != Result.SUCCESS)
                Move(Reverse(dir));
            Draw();
            return result;
        }

        private Result VerifyPosition()
        {
            foreach(var p in Points)
            {
                if (p.Y >= Field.Heigth)
                    return Result.DOWN_BORDER_STRIKE;
                else if (p.X >= Field.Width || p.X < 0 || p.Y < 0)
                    return Result.BORDER_STRIKE;
                else if (Field.CheckStrike(p))
                    return Result.HEAP_STRIKE;

            }
            return Result.SUCCESS;
        }

        public void Move(Direction dir)
        {
            foreach (var p in Points)
            {
                p.Move(dir);
            }
        }


        public Direction Reverse(Direction dir)
        {
            switch (dir)
            {
                case Direction.Left:
                    return Direction.Right;
                case Direction.Right:
                    return Direction.Left;
                case Direction.Up:
                    return Direction.Down;
                case Direction.Down:
                    return Direction.Up;
                
            }
            return dir;
        }


        internal Result TryRotate()
        {
            Hide();
            Rotate();

            var result = VerifyPosition();
            if (result != Result.SUCCESS)
                Rotate();


            Draw();

            return result;
        }

        internal bool IsOnTop()
        {
            return Points[0].Y == 0;
        }

        public abstract void Rotate();


    }
}
