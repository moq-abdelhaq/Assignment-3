using System;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assingment 3");
            //Polymorphism example
            IShape[] ShapeList = new IShape[2] { new Circle(), new Square()};
            foreach (var shape in ShapeList)
            {
                shape.Draw();
                shape.Move(3, 3);
                shape.Draw();
            }



            //Data coupling example
            DBConnection connection = new DBConnection();
            connection.Username = "user1";
            connection.Password = "pass1";

            DatabaseService db = new DatabaseService();
            db.Connect(connection);
        }
    }
}
