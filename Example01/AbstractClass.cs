using System;
using System.Collections.Generic;
using System.Text;

namespace Example01
{
    public abstract class AbstractClass
    {
        public abstract void AbstractPublicMethod();

        protected abstract void AbstractProtectedMethod();

        //private abstract void AbstractPrivateMethod();//抽象方法不允许使用private修饰

        public void AbstractMethod()
        {
            Console.WriteLine("AbstractClass类的方法 AbstractMethod");
        }
    }
}
