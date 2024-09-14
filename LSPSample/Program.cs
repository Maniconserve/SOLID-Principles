using System;

namespace SOLID_PRINCIPLES.LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            // LSP Example - Square
            Rectangle rect = new Square();
            Console.WriteLine($"Square Area: {rect.GetPerimeter(5, 6)}");  
        }
    }

    public class Rectangle
    {
        // Calculate area by passing width and height as parameters
        public virtual int GetPerimeter(int length, int breadth)
        {
            return (2 * (length + breadth));
        }
    }

    public class Square : Rectangle
    {
        // Override to handle the square's unique area calculation
        public override int GetPerimeter(int side, int unused)
        {
            return 4 * side;  // Since all sides of a square are equal
        }
    }
}
