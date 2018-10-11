using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace gc_lab7
{
    class Program
    {
        static void Main(string[] args)
        {

          
           validName(@"^[A-Z][a-z]{0,29}$", "Please Enter valid Name:");
           validName(@"[A-Za-z1-9]{0,29}@[A-Za-z1-9]{5,10}\.[A-Za-z]{2,3}", "Please Enter valid Email:");
            validName(@"[0-9]{3}-[0-9]{3}-[0-9]{4}", "Please Enter valid Phone Number, including area code:");
            validName(@"[0-1][0-9][/][0-3][0-9][/][1-2][0-9][0-9][0-9]", "Please Enter valid date:");
            validName(@"[<][A-Za-z1-9]{0,10}[>][<][/][A-Za-z1-9]{0,10}[>]", "Please Enter valid HTML:");

            Console.WriteLine("You have validated your data\nPress any key to end");
            Console.ReadKey();
        }



         public static void validName(string check, string prompt)
        {
            //max 30 char, letters only and start w/ a capitol letter 
            Console.WriteLine(prompt);
            string answer = Console.ReadLine();

            while (!Regex.IsMatch(answer, check))
            {
                Console.WriteLine("Not a match");
                Console.WriteLine("Try again");
                answer = Console.ReadLine();

            }
           if (Regex.IsMatch(answer, check))
            {
               Console.WriteLine("Is a match!");
            }
        }



    }
}

