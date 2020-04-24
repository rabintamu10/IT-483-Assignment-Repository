/*RABIN GURUNG*/

using System;

namespace Lab01
{
    class Lab01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CS 201 Restaurant Guide\n");
            string response;
            char s, f;
            bool spicy, fancy;


            Console.WriteLine("Do you like spicy food? (y / n) : ");


            response = Console.ReadLine();


            s = response[0];
            if (s == 'y' || s == 'Y')
            {
                spicy = true;
            }
            else
            {
                spicy = false;
            }


            Console.WriteLine("Do you want to go to a fancy restaurant? (y / n) : ");
            

            response = Console.ReadLine();


            f = response[0];
            if (f == 'y' || f == 'Y')
            {
                fancy = true;
            }
            else
            {
                fancy = false;
            }


            if (spicy)
            {
                if (fancy)
                {
                    Console.WriteLine("I suggest you go to Thai Garden Palace.");
                }
                else
                {
                    Console.WriteLine("I suggest you go to Alberto's Tacqueria.");
                }
            }
            else
            {
                if (fancy)
                {
                    Console.WriteLine("I suggest you go to Chez Paris.");
                }
                else
                {
                    Console.WriteLine("I suggest you go to Joe's Diner.");
                }
            }
            Console.ReadLine();
        }
    }
}
