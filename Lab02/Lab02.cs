/*RABIN GURUNG*/

using System;


namespace Lab02
{
    class Lab02
    {
        static void Main(string[] args)
        {
            string response = null;
            char p = '0', type = '0';
            bool pres = false, glare = false;   
            double prescribed_glass = 40.00;
            double non_prescribed = 25.00;
            double anti_glare = 12.50;
            double brown_tint = 9.99;
            double total;


            Console.WriteLine("Welcome, What kind of glasess would you like?");


            while (p != '1' && p != '2')
            {
                Console.Write("1 --> Precription, 2 --> non-prescription: ");
                response = Console.ReadLine();
                

                p = response[0]; 
            }

            if (p == '1')
            {
                pres = true;
            }
            else
            {
                pres = false;
            }

            response = null;
            

            
            while (type != '1' && type != '2')
            {
                Console.Write("1 --> anti-glare, 2 --> brown tint: ");
                response = Console.ReadLine();
                
 
                
                type = response[0];
            }

            if (type == '1')
            {
                glare = true;
            }
            else
            {
                glare = false;
            }


            
            if (pres)
            {
                if (glare)
                {
                    total = prescribed_glass + anti_glare; 
                }
                else
                {
                    total = prescribed_glass + brown_tint;
                }
            }
            else
            {
                if (glare)
                {
                    total = non_prescribed + anti_glare;
                }
                else
                {
                    total = non_prescribed + brown_tint;
                }
            }

            Console.WriteLine("Your total cost is $" + total);
            Console.ReadLine();

        }
    }
}
