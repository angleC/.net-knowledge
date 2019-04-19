using System;
using System.Collections.Generic;
using System.Text;

namespace Example01
{
    public class SealedChildClass : SealedClass
    {
        public sealed override void SealedAbstractMethod()
        {
            Console.WriteLine("SealedChildClass类的方法 SealedAbstractMethod");
        }

        public sealed override void SealedVirtualMethod()
        {
            Console.WriteLine("SealedChildClass类的方法 SealedVirtualMethod");
        }
    }
}
