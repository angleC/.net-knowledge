using System;
using System.Collections.Generic;
using System.Text;

namespace Example01
{
    public abstract class SealedClass
    {
        public void SealedPublicMethod()
        {
            Console.WriteLine("Sealed类的方法 SealedPublicMethod");

            return;
        }

        public abstract void SealedAbstractMethod();

        public virtual void SealedVirtualMethod()
        {
            Console.WriteLine("Sealed类的方法 SealedVirtualMethod");

            return;
        }
    }
}
