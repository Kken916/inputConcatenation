using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inputConcatenation

{
    class Program
    {
        static void Main(string[] args)
        {
            //Define Variables first
            string firstName, lastName, fullName;

            Console.WriteLine("Please enter your first name.");
            firstName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("please enter your last name.");
            lastName = Convert.ToString(Console.ReadLine());

            //concatenation
            fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            Console.Read();
        }
    }
}
