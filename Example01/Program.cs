using System;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClassTest();

            Console.WriteLine("\n\t");

            NewClassTest();

            Console.WriteLine("\n\t");

            OverrideClassTest();

            Console.WriteLine("\n\t");

            SealedClassTest();

            Console.WriteLine("\n\t");

            VirtualClassTest();

            Console.ReadKey();
        }

        private static void AbstractClassTest()
        {
            Console.WriteLine("**************测试 Abstract 的使用*****************");

            //AbstractClass abstractClass = new AbstractClass();//抽象类无法直接实例化
            Console.WriteLine("实例化方式： AbstractClass abstractClass = new AbstractChildClass()");
            AbstractClass abstractClass = new AbstractChildClass();

            abstractClass.AbstractPublicMethod();
            abstractClass.AbstractMethod();

            Console.WriteLine("**************测试 Abstract 结束*******************");
        }

        private static void NewClassTest()
        {
            Console.WriteLine("**************测试 New 的使用*****************");

            Console.WriteLine("实例化方式： NewClass newClass = new NewClass()");
            NewClass newClass = new NewClass();
            newClass.NewPublicMethod();
            Console.WriteLine("\n\t");

            Console.WriteLine("实例化方式： NewChildClass newChildClass = new NewChildClass()");
            NewChildClass newChildClass = new NewChildClass();
            newChildClass.NewPublicMethod();
            Console.WriteLine("\n\t");

            Console.WriteLine("实例化方式： NewClass newClass2 = new NewChildClass()");
            NewClass newClass2 = new NewChildClass();
            newClass2.NewPublicMethod();

            //Console.WriteLine("实例化方式： NewChildClass newChildClass2 = (NewChildClass)new NewClass()");
            //NewChildClass newChildClass2 = (NewChildClass)new NewClass();
            //newChildClass2.NewPublicMethod();

            Console.WriteLine("**************测试 New 结束*******************");
        }

        private static void OverrideClassTest()
        {
            Console.WriteLine("**************测试 Override 的使用*****************");

            Console.WriteLine("实例化方式： OverrideClass overrideClass = new OverrideClass()");
            OverrideClass overrideClass = new OverrideClass();
            overrideClass.OverridePublicMethod();
            Console.WriteLine("\n\t");

            Console.WriteLine("实例化方式： OverrideChildClass overrideChildClass = new OverrideChildClass()");
            OverrideChildClass overrideChildClass = new OverrideChildClass();
            overrideChildClass.OverridePublicMethod();
            Console.WriteLine("\n\t");

            Console.WriteLine("实例化方式： OverrideClass overrideClass2 = new OverrideChildClass()");
            OverrideClass overrideClass2 = new OverrideChildClass();
            overrideClass2.OverridePublicMethod();

            //Console.WriteLine("实例化方式： OverrideChildClass overrideChildClass2 = (OverrideChildClass)new OverrideClass()");
            //OverrideChildClass overrideChildClass2 = (OverrideChildClass)new OverrideClass();
            //overrideChildClass2.OverridePublicMethod();

            Console.WriteLine("**************测试 Override 结束*******************");
        }

        private static void SealedClassTest()
        {
            Console.WriteLine("**************测试 Sealed 的使用*****************");

            Console.WriteLine("实例化方式： SealedChildClass sealedChildClass = new SealedChildClass()");
            SealedChildClass sealedChildClass = new SealedChildClass();
            sealedChildClass.SealedAbstractMethod();
            sealedChildClass.SealedPublicMethod();
            sealedChildClass.SealedVirtualMethod();
            Console.WriteLine("\n\t");

            Console.WriteLine("实例化方式： SealedChildOfChildClass sealedChildOfChildClass = new SealedChildOfChildClass()");
            SealedChildOfChildClass sealedChildOfChildClass = new SealedChildOfChildClass();
            sealedChildOfChildClass.SealedAbstractMethod();
            sealedChildOfChildClass.SealedPublicMethod();
            sealedChildOfChildClass.SealedVirtualMethod();
            Console.WriteLine("\n\t");

            Console.WriteLine("实例化方式： SealedClass sealedClass = new SealedChildClass()");
            SealedClass sealedClass = new SealedChildClass();
            sealedClass.SealedAbstractMethod();
            sealedClass.SealedPublicMethod();
            sealedClass.SealedVirtualMethod();
            Console.WriteLine("\n\t");

            Console.WriteLine("实例化方式： SealedClass sealedClass2 = new SealedChildOfChildClass()");
            SealedClass sealedClass2 = new SealedChildOfChildClass();
            sealedClass2.SealedAbstractMethod();
            sealedClass2.SealedPublicMethod();
            sealedClass2.SealedVirtualMethod();

            Console.WriteLine("**************测试 Sealed 结束*******************");
        }

        private static void VirtualClassTest()
        {
            Console.WriteLine("**************测试 Virtual 的使用*****************");

            Console.WriteLine("实例化方式： VirtualClass virtualClass = new VirtualClass()");
            VirtualClass virtualClass = new VirtualClass();
            virtualClass.VirtualPublicMethod();
            Console.WriteLine("\n\t");

            Console.WriteLine("实例化方式： VirtualChildClass virtualChildClass = new VirtualChildClass()");
            VirtualChildClass virtualChildClass = new VirtualChildClass();
            virtualChildClass.VirtualPublicMethod();
            Console.WriteLine("\n\t");

            Console.WriteLine("实例化方式： VirtualClass virtualClass2 = new VirtualChildClass()");
            VirtualClass virtualClass2 = new VirtualChildClass();
            virtualClass2.VirtualPublicMethod();

            //Console.WriteLine("实例化方式： VirtualChildClass virtualChildClass2 = (VirtualChildClass)new VirtualClass()");
            //VirtualChildClass virtualChildClass2 = (VirtualChildClass)new VirtualClass();
            //virtualChildClass2.VirtualPublicMethod();

            Console.WriteLine("**************测试 Virtual 结束*******************");
        }
    }
}
