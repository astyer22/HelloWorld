using System;

namespace HelloWorld
{
    public class Hello
    {
        private string _name;
        private DateTime _date;

        public Hello(string name)
        {
            _name = name;
            _date = DateTime.Now;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello World, this is {_name}! Today is {_date:MMMM dd, yyyy}");
        }
    }

    class Program
    {
        static void Main()
        {
            Hello hello = new Hello("Austin Styer");
            hello.SayHello();
        }
    }
}
