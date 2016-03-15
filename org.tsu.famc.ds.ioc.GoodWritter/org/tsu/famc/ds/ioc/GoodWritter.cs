using System;

namespace org.tsu.famc.ds.ioc
{
    public class GoodWritter : IWritter
    {
        public void Write(string msg)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("You asked me to show a message: " + msg);
            Console.WriteLine("Thank you!");
        }
    }
}
