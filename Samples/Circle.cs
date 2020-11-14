using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class Circle : IShape
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public int Diameter { get; set; }
        public void Draw()
        {
            //Implements drawing for Rectangle
            Console.WriteLine("Drawing Circle .... " + "X:" + XCoordinate + " Y:" + YCoordinate);
        }

        public void Move(int x, int y)
        {
            XCoordinate += x;
            YCoordinate += y;
            Console.WriteLine("Circle new location : " + XCoordinate + "," + YCoordinate);
        }
    }
}
