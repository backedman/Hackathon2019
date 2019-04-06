using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you a male or a female?");
            String gender = Console.ReadLine();
            if (String.Compare(gender, "male") == 0 || String.Compare(gender, "m") == 0)
            {
                Console.WriteLine("What is your shoe size?");
                decimal x = Convert.ToDecimal(Console.ReadLine());
                decimal footlength = (decimal)0.33 * x + (decimal)7.35;
            }
            if(String.Compare(gender, "female") == 0 || String.Compare(gender, "f") == 0)
            {
                Console.WriteLine("What is your shoe size?");
                decimal x = Convert.ToDecimal(Console.ReadLine());
                decimal footlength = (decimal)0.33 * x + (decimal)7.35;
            }
        }
    }
}
