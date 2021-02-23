using System;

namespace HomeworkWeek3_Operators_63120501064
{
    class Program
    {
        static void Main(string[] args)
        {
            int password;
            Console.Write("Input Password : ");
            password = int.Parse(Console.ReadLine());

            string agency;
            Console.Write("Input Agency : ");
            agency = (Console.ReadLine());

            if (password { 1000}, { 10}, { 1})
            agency = "CIA";
            {
                Console.WriteLine("Your Password is True");

             else if (password { 7, 9}, { 2, 4, 6, 7, 8, 9}, { 3, 6, 9})
             agency = "FBI","NSA";

                Console.WriteLine("Your Password is False");
            }

            if (password { 1000}, { 10}, { 1})
            agency = "FBI";
            {
                Console.WriteLine("Your Password is True");

             else if (password { 3, 4}, { 4, 7, 8}, { 3, 9})
             agency = "CIA","NSA";

                Console.WriteLine("Your Password is False");
            }

            if (password { 1000}, { 10}, { 1})
            agency = "NSA";
            {
                Console.WriteLine("Your Password is True");

             else if (password { 2, 7}, { 2, 8, 9}, { 5, 7, 8})
             agency = "CIA","FBI";

                Console.WriteLine("Your Password is False");
            }

            Console.ReadLine();
        }
    }
}
