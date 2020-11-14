﻿using System;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assingment 3");
            IShape[] ShapeList = new IShape[2] { new Circle(), new Square()};
            foreach (var shape in ShapeList)
            {
                shape.Draw();
                shape.Move(3, 3);
                shape.Draw();
            }

            DBConnection connection = new DBConnection;
            connection.Username = "user1";
                connection.Password = "pass1";
        }
    }
}
