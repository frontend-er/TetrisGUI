using System;

namespace Tetris
{
    internal class FirureGenerator
    {
        private int _x;
        private int _y;

        private Random _rand = new Random();

        public FirureGenerator(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Figure GetNewFigure()
        {
            if(_rand.Next(0,2) == 0)
            {
                return new Square(_x, _y);
            }
            else
            {
                return new Line(_x, _y);
            }
        }
    }
}