using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Everything Happens for a Reason");
            Console.ReadKey();
        }
    }
}

/////////////////////////////////////////////////////

// B
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Name: " + name);
            Console.ReadKey();
        }
    }
}

//c
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("Please enter your age:");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Age: " + age);
            Console.ReadKey();
        }
    }
}
