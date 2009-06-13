using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using console_app.library;

namespace console_app {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            if (name.Validate())
                Console.WriteLine("Your name is {0}", name);
            else
                Console.WriteLine("Error: name cannot contain numerical digits.");
            Console.ReadLine();
        }
    }
}
