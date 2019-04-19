using System;
using System.Collections.Generic;
using System.Text;

namespace Example01
{
    public class OverrideChildClass : OverrideClass
    {
        public override void OverridePublicMethod()
        {
            Console.WriteLine("OverrideChildClass类的方法 OverridePublicMethod");
        }

        protected override void OverrideProtectedMethod()
        {
            Console.WriteLine("OverrideChildClass类的方法 OverrideProtectedMethod");
        }
    }
}
