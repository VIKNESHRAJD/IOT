//a) Quadrant
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int co1, co2;
            Console.Write("\n\n");
            Console.Write("Find the quadrant in which the coordinate point lies: \n");
            Console.Write("_\t");
            Console.Write("\n\n");
            Console.Write("Input the value for X coordinate: ");
            co1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value for Y coordinate: ");
            co2 = Convert.ToInt32(Console.ReadLine());
            if (co1 > 0 && co2 > 0)
                Console.Write("The coordinate point ({0}, {1}) lies in the First quadrant. \n\n", co1, co2);
            else if (co1 < 0 && co2 > 0)
                Console.Write("The coordinate point ({0}, {1}) lies in the Second quadrant. \n\n", co1, co2);
            else if (co1 < 0 && co2 < 0)
                Console.Write("The coordinate point ({0}, {1}) lies in the Third quadrant. \n\n", co1, co2);
            else if (co1 > 0 && co2 < 0)
                Console.Write("The coordinate point ({0}, {1}) lies in the Fourth quadrant.\n\n", co1, co2);
            else if (co1 == 0 && co2 == 0)
                Console.Write("The coordinate point ({0}, {1}) lies at the origin. \n\n", co1, co2);
            Console.ReadKey();
        }
    }
}

// b) Vowels
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("\n\n");
            Console.Write("Check whether the input alphabet is a vowel or not:\n");
            Console.Write("_\t");
            Console.Write("\n\n");
            Console.Write("Input an alphabet (A-Z or a-z): ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.Write("You entered a number, please enter an alphabet.");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The alphabet is a vowel.");
                        break;
                    case 'i':
                        Console.WriteLine("The alphabet is a vowel.");
                        break;
                    case 'o':
                        Console.WriteLine("The alphabet is a vowel.");
                        break;
                    case 'u':
                        Console.WriteLine("The alphabet is a vowel.");
                        break;
                    case 'e':
                        Console.WriteLine("The alphabet is a vowel.");
                        break;
                    default:
                        Console.WriteLine("The alphabet is a consonant.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}


//c) String Length
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int length = 0;
            Console.Write("\n\nFind the length of a string: ");
            Console.Write("_\t\n");
            Console.Write("Input the string: ");
            str = Console.ReadLine();
            foreach (char chr in str)
            {
                length += 1;
            }
            Console.Write("Length of the string is: {0}\n\n", length);
            Console.ReadKey();
        }
    }
}
