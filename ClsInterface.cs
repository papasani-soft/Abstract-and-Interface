using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    interface ITestInterface1
    {
        void Add(int a, int b);
    }
    interface ITestInterface2 :ITestInterface1
    {
        void Sub(int a, int b);
    }
    class ImplementationClass : ITestInterface2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        public void CreateInterface()
        {
            ImplementationClass ic = new ImplementationClass();
            //ic.Add(100,30);ic.Sub(100,20);
            ITestInterface2 i = ic;
            i.Add(100,50);i.Sub(200,50);
        }
    }
}

