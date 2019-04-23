using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class DelegateChange
    {
        #region 委托协变
        public delegate Animal GetAnimal();

        public static Dog FromDog()
        {
            return new Dog();
        }

        public GetAnimal Dog = FromDog;
        #endregion

        #region 委托逆变
        public delegate void FeedDog(Dog target);

        private static void FromAnimal(Animal target)
        {
            var v = target.GetAnimalName();

            Console.WriteLine(v);
        }

        public FeedDog feedDog = FromAnimal;
        #endregion
    }
}
