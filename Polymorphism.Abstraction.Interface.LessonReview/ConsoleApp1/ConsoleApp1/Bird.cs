using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Bird :Animal
    {
        
        public override void Sound()
        {
            Console.WriteLine("Bird sound");
        }
        public override void Eat()
        {
            Console.WriteLine("Bird eating");
        }

    }
}
