using System;
using System.Collections.Generic;
using System.Text;

namespace Example01
{
    public class OverrideClass
    {
        public virtual void OverridePublicMethod()
        {
            Console.WriteLine("OverrideClass类的方法 OverridePublicMethod");
        }

        protected virtual void OverrideProtectedMethod()
        {
            Console.WriteLine("OverrideClass类的方法 OverrideProtectedMethod");
        }

        //private virtual void OverridePrivateMethod()//虚方法不允许private修饰
        //{
        //    Console.WriteLine("OverrideClass类的方法 OverridePublicMethod");
        //}
    }
}
