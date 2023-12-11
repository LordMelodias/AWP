using System;

namespace unviersity_8a
{
    interface IDrawable
    {
        void Draw();
    }

    // Define the second interface
    interface IResizable
    {
        void Resize(int width, int height);
    }

    class Shape : IDrawable, IResizable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing the shape");
        }

        public void Resize(int width, int height)
        {
            Console.WriteLine($"Resizing the shape to width {width} and height {height}");
        }
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape myShape = new Shape();

            // Use methods from both interfaces
            myShape.Draw();
            myShape.Resize(100, 150);
        }
    }
}
