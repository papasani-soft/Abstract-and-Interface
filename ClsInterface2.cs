using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    interface Interface1
    {
        void Test();
        void Show();
    }
    interface Interface2
    {
        void Test();
        void Show();
    }
    class MultipleInheritanceTest : Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("interface method implemeted in child class");
        }
        void Interface1.Show()
        {
            Console.WriteLine("declared in interface1 and implemented in class");
        }
        void Interface2.Show()
        {
            Console.WriteLine("declared in interface2 and implemented in class");
        }
        public void CreateMultipleInheritance()
        {
            MultipleInheritanceTest mh = new MultipleInheritanceTest();
            mh.Test();
            Interface1 i1 = mh;
            Interface2 i2 = mh;
            i1.Show();
            i2.Show();
             
        }
    }
}
