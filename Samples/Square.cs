using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class Square : IShape
    {
        public int XCoordinate { get; set; } = 0;
        public int YCoordinate { get; set; } = 0;
        public int Length { get; set; }
        public void Draw()
        {
            //Implements drawing for Square
            Console.WriteLine("Drawing Square .... " + "X:" + XCoordinate + " Y:" + YCoordinate);
        }

        public void Move(int x,int y)
        {
            XCoordinate += x;
            YCoordinate += y;
            Console.WriteLine("Square new location : " + XCoordinate + "," + YCoordinate);
        }
    }
}
