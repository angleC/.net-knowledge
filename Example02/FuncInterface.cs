using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    #region 泛型接口协变
    public interface IFinder<out T>
    {
        T Find();
    }

    public class Finder<T> : IFinder<T>
    {
        public T Find()
        {
            Console.WriteLine("泛型接口的协变");

            return default(T);
        }
    }

    #endregion

    #region 泛型接口逆变
    public interface IFeed<in T>
    {
        void Feeder(T t);
    }

    public class Feed<T> : IFeed<T>
    {
        public void Feeder(T t)
        {
            Console.WriteLine("泛型接口逆变");
        }
    }
    #endregion
}
