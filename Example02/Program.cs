using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");

            //父类可以直接通过子类进行实例化
            Animal a = new Dog();

            ////子类无法通过父类进行实例化
            //Dog d = (Dog)new Animal();

            Console.WriteLine("*************************************");
            //数组协变
            //Animal animalArr = new Dog[] { };

            Console.WriteLine("*************************************");
            //委托的协变
            DelegateChange delegateChange = new DelegateChange();
            var v = delegateChange.Dog.Invoke().GetAnimalName();
            Console.WriteLine(v);

            //委托的逆变
            delegateChange.feedDog.Invoke(new Dog());

            Console.WriteLine("*************************************");
            //泛型委托的协变
            DelegateChangeFunc delegateChangeFunc = new DelegateChangeFunc();
            Console.WriteLine(delegateChangeFunc.findAnimal.Invoke().GetAnimalName());

            //泛型委托的逆变
            delegateChangeFunc.feed.Invoke(new Dog());

            Console.WriteLine("*************************************");
            //泛型接口协变
            IFinder<Animal> finder = new Finder<Dog>();
            finder.Find();

            //泛型接口逆变
            IFeed<Dog> feed = new Feed<Animal>();
            feed.Feeder(new Dog());
            Console.WriteLine("*************************************");


            Console.ReadKey();
        }
    }
}
