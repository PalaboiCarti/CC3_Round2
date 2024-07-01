using System;

public class Skibidi
{
    static void kmToMi()
    {
        Console.WriteLine("Enter distance in Kilometers (km):");
        double km = Convert.ToDouble(Console.ReadLine());
        double miles = km * 0.62;
        Console.WriteLine($"{km} kilometers is equal to {miles} miles.");
    }

    static void miToKm()
    {
        Console.WriteLine("Enter distance in Miles (mi):");
        double miles = Convert.ToDouble(Console.ReadLine());
        double km = miles * 1.6;
        Console.WriteLine($"{miles} miles is equal to {km} kilometers.");
    }

    static void celToFah()
    {
        Console.WriteLine("Enter temperature in Celsius (°C):");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F.");
    }

    static void fahToCel()
    {
        Console.WriteLine("Enter temperature in Fahrenheit (°F):");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit}°F is equal to {celsius}°C.");
    }

    static void usdToPhp()
    {
        Console.WriteLine("Enter amount in USD:");
        double usd = Convert.ToDouble(Console.ReadLine());
        double php = usd * 58.83;
        Console.WriteLine($"{usd} USD is equal to {php} PHP.");
    }

    static void phpToUsd()
    {
        Console.WriteLine("Enter amount in PHP:");
        double php = Convert.ToDouble(Console.ReadLine());
        double usd = php / 58.83;
        Console.WriteLine($"{php} PHP is equal to {usd} USD.");
    }

    public static void Main(string[] args)
    {
        int choice = 0;
        
        while (choice != 7)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Convert Kilometers to Miles");
            Console.WriteLine("2. Convert Miles to Kilometers");
            Console.WriteLine("3. Convert Celsius to Fahrenheit");
            Console.WriteLine("4. Convert Fahrenheit to Celsius");
            Console.WriteLine("5. Convert USD to PHP");
            Console.WriteLine("6. Convert PHP to USD");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Enter your choice:");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    kmToMi();
                    break;
                case 2:
                    miToKm();
                    break;
                case 3:
                    celToFah();
                    break;
                case 4:
                    fahToCel();
                    break;
                case 5:
                    usdToPhp();
                    break;
                case 6:
                    phpToUsd();
                    break;
                case 7:
                    Console.WriteLine("Sige, salamat...");
                    break;
                default:
                    Console.WriteLine("Please select a whole integer between 1 and 7. Salamat.");
                    break;
            }
        }
    }
}
