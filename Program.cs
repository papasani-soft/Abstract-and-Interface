using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter program no. to execute");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    AbsChild obj1 = new AbsChild();
                    obj1.CreateImpInterface();
                    break;
                case 2:
                    ImplementationClass obj2 = new ImplementationClass();
                    obj2.CreateInterface();
                    break;
                case 3:
                    MultipleInheritanceTest obj3 = new MultipleInheritanceTest();
                    obj3.CreateMultipleInheritance();
                    break;
                case 4:
                    TestAbstract obj4 = new TestAbstract();
                    obj4.CreateAbstraction();
                    break;
                case 5:
                    DerivedC obj5 = new DerivedC();
                    obj5.CreateMethod();
                    break;
                default:
                    break;
            }
            Console.Read();
        }
    }
}
