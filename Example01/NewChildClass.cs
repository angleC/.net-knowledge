using System;
using System.Collections.Generic;
using System.Text;

namespace Example01
{
    public class NewChildClass : NewClass
    {
        public new void NewPublicMethod()
        {
            Console.WriteLine("NewChildClass类的 NewPublicMethod");
        }
    }
}
