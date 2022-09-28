using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_Abstract.Entities;
using Exercicio_Abstract.Entities.Enum;

namespace Exercicio_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int nShapes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nShapes; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color - Black, Blue, Red: ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                if(ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, color));
                }

                Console.WriteLine();
                Console.Write("SHAPE AREAS:");
                foreach(Shape shape in list)
                {
                    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
