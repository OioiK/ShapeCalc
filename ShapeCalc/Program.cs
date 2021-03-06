using ShapeController;
using ShapeController.Shapes;
using System;

namespace ShapeCalc
{
    class Program
    {
        private partial class Figura : Circle
        {
            public string Description { get; set; }
            public Figura(double radius, string description) : base(radius)
            {
                Description = description;
            }
        }
        static void Main(string[] args)
        {
            var figura = new Figura(15, "Addded Figura's Square");
            Console.Write(string.Format("{0}: {1}", figura.Description, ShapeProcessor.CalculateSquare(figura)));

            Console.ReadKey();
        }
    }
}
