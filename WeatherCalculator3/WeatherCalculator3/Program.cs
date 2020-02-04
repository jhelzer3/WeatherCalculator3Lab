using System;

namespace BrötherMayIHaveSomeLööps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###BasicWeatherCalculator3###");




            
            bool quityesno = true;

            while (quityesno == true) {
                Console.WriteLine("Enter the temperature");


                int temperature = int.Parse(Console.ReadLine());

                if (temperature > 50)
                {

                    Console.WriteLine("Enter the relative humidity");

                    int relativeHumidity = int.Parse(Console.ReadLine());
                    double heatIndex = 0.5 * (temperature + 61.0 + ((temperature - 68.0) * 1.2) + (relativeHumidity * 0.094));


                    Console.WriteLine("The heat index is " + heatIndex);
                }
                else
                {

                    Console.WriteLine("Enter the wind speed");





                    int windSpeed = int.Parse(Console.ReadLine());


                    double windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);


                    Console.WriteLine("The wind chill is " + windChill);
                }
                    Console.WriteLine("Would you like more weather? Enter strictly yes or no.");
                string yesno = Console.ReadLine();
                    if (yesno == "yes")
                    {
                        quityesno = true;
                    }
                    else if (yesno == "no")
                    {
                        quityesno = false;
                    }
                    else
                    {
                        Console.WriteLine("I JUST SAID 'Enter strictly yes or no'.  Why are you like this? Just for that, you get more weather.");
                        quityesno = true;
                    }
                
               
                    
            }
            
            Console.WriteLine("Program has ended...No more weather!");

        }

       
        
    }
}