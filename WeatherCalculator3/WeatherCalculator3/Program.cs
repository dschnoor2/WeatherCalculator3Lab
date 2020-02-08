using System;

namespace WeatherCalculator3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 3 ###");

            int temperature;
            int windSpeed;
            double windChill;
            int relativeHumidity;
            double heatIndex;
            string input = "";

            bool userChoice = true;
            
            while (userChoice)
            {
            // Get the temperature from the User
            Console.WriteLine("Enter the Temperature");

            input = Console.ReadLine();

            // convert "input" string variable  to an integer and store in "temperature" variables
            temperature = int.Parse(input);

                if (temperature > 50)
                {
                    // Get the relative humidity from the User
                    Console.WriteLine("Enter the Relative Humidity");

                    // NOTE: reusing the "input" variable to get the Relative Humidity
                    input = Console.ReadLine();

                    // convert "input" string variable to an integer and store in "relativeHumidity" variable
                    relativeHumidity = int.Parse(input);

                    // Calculate the heat index
                    // 0.5 * (T + 61.0 + ((T-68.0)*1.2) + (RH*0.094))
                    heatIndex = 0.5 * (temperature + 61.0 + ((temperature - 68.0) * 1.2) + (relativeHumidity * 0.094));

                    // Write the heat index out to the console
                    Console.WriteLine("The heat index is " + heatIndex);
                }
                else
                {
                    // Get the wind speed from the User
                    Console.WriteLine("Enter the wind speed");

                    // NOTE: reusing the "input" variable to get the Wind Speed
                    input = Console.ReadLine();

                    // convert "input" string variable to an integer and store in "windSpeed" variable
                    windSpeed = int.Parse(input);

                    // Calculate the wind chill
                    windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                    // Write the windchill out to the console
                    Console.WriteLine("The Wind Chill is " + windChill);
                }
                    //Ask User if the wish to continue  //Print line to console
                    Console.WriteLine("Do you wish to do more Calculations? Enter yes or no");
                    input = Console.ReadLine();

                    if (input == "yes")
                    {
                        continue;
                    }
                    else 
                    {
                        userChoice = false;
                        //Print Line to console "Program has Ended"
                        Console.WriteLine("Program has ended...Thank You");
                        
                    }
            }
        }
    }
}
            
           