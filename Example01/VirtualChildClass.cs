using System;
using System.Collections.Generic;
using System.Text;

namespace Example01
{
    public class VirtualChildClass : VirtualClass
    {
        public override void VirtualPublicMethod()
        {
            Console.WriteLine("VirtualChildClass类的 VirtualPublicMethod");
        }
    }
}
