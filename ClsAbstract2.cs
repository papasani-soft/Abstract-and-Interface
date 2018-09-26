using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{ 
    public abstract class Shape
    {
        public abstract void draw();
    }
    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
    public class TestAbstract
    {
        public void CreateAbstraction()
        {
            Shape s;
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
        }
    } 
}