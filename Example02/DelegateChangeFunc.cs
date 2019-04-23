using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class DelegateChangeFunc
    {
        #region 协变
        public delegate T Find<out T>();

        static Find<Dog> findDog = () => new Dog();

        public Find<Animal> findAnimal = findDog;
        #endregion

        #region 逆变
        public delegate void Feed<in T>(T target);

        static Feed<Animal> feedAnimal = a => Console.WriteLine(a.GetAnimalName());

        public Feed<Dog> feed = feedAnimal;
        #endregion
    }
}
