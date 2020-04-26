using System;

namespace Interface1
{
    interface IMovable
    {
        void Move();
    }
    class Person : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The person goes");
        }
    }
    struct Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car goes");
        }
    }
    class Program
    {
        static void Action(IMovable movable)
        {
            movable.Move();
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            Car car = new Car();
            Action(person);
            Action(car);
            Console.Read();
        }
    }
}
