using System;
using System.Collections.Generic;
using System.Text;

namespace Example01
{
    public class AbstractChildClass : AbstractClass
    {
        public override void AbstractPublicMethod()
        {
            Console.WriteLine("AbstractChildClass类的方法 AbstractPublicMethod");

            return;
        }

        protected override void AbstractProtectedMethod()
        {
            Console.WriteLine("AbstractChildClass类的方法 AbstractProtectedMethod");

            return;
        }
    }
}
