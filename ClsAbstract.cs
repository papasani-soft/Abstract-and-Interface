using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
   abstract class ClsAbstract
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
    }
    class AbsChild : ClsAbstract
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x*y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        public void CreateImpInterface()
        {
            AbsChild c = new AbsChild();
            c.Add(10, 5);c.Sub(10, 5);
            c.Mul(10, 5);c.Div(10, 5);
        }
    }
}
