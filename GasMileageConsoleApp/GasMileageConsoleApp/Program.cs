using System;

namespace GasMileageConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles = 0;
            int gallons = 0;
            int totalMiles = 0;
            int totalGallons = 0;
            double milesPerGallon;
            double totalMilesPerGallon;

            Console.Write("Enter miles (-1 to quit): ");
            miles = Convert.ToInt32(Console.ReadLine());

            while (miles != -1)
            {
                Console.Write("Enter gallons: ");
                gallons = Convert.ToInt32(Console.ReadLine());
                
                milesPerGallon = (double)miles / gallons;
                Console.WriteLine("MPG this tankful: {0:0.00}", milesPerGallon);
                
                totalMiles += miles;
                totalGallons += gallons;

                totalMilesPerGallon = (double)totalMiles / totalGallons;
                Console.WriteLine("Total MPG: {0:0.00}", totalMilesPerGallon);
                Console.WriteLine();
                Console.Write("Enter miles (-1 to quit): ");
                miles = Convert.ToInt32(Console.ReadLine());
            }


            

        

            









            

            



            


        }
    }
}
