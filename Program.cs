using System;

namespace ConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Currency/Temperature Converter!");
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Currency Converter");
                Console.WriteLine("2. Temperature Converter");
                Console.WriteLine("3. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CurrencyConverter();
                        break;
                    case "2":
                        TemperatureConverter();
                        break;
                    case "3":
                        exit = true;
                        Console.WriteLine("Exiting the converter . Goodbye! ");
                        break;
                    deafult:
                        Console.WriteLine("invalid choice , please try again");
                        break;
                }
            }

            static void CurrencyConverter()
            {
                Console.WriteLine("\nCurrency Converter");

                Console.WriteLine("Enter the amount in USD:");
                double amountUSD = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose the currency to convert to:");
                Console.WriteLine("1. EUR (Euro)");
                Console.WriteLine("2. GBP (British Pound)");
                Console.WriteLine("3. JPY (Japanese Yen)");
                string currencyChoice = Console.ReadLine();

                double convertedAmount = 0;
                string currency = "";

                switch (currencyChoice)
                {
                    case "1":
                        convertedAmount = amountUSD * 0.85;
                        Console.WriteLine($"{amountUSD} USD is {convertedAmount} EUR");
                        break;
                    case "2":
                        convertedAmount = amountUSD * 0.75;
                        Console.WriteLine($"{amountUSD} USD is {convertedAmount} GBP");
                        break;
                    case "3": // Convert to JPY
                        convertedAmount = amountUSD * 110;
                        Console.WriteLine($"{amountUSD} USD is {convertedAmount} JPY");
                        break;
                    default: // Handle invalid input
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

            static void TemperatureConverter()
            {
                Console.WriteLine("\nTemperature Converter");

                Console.WriteLine("Choose the conversion:");
                Console.WriteLine("1. Celsius to Fahrenheit");
                Console.WriteLine("2. Fahrenheit to Celsius");
                string tempChoice = Console.ReadLine();

                double convertedTemp = 0;

                switch (tempChoice)
                {
                    case "1":
                        Console.WriteLine("Enter the temperature in Celsius:");
                        double celsius = Convert.ToDouble(Console.ReadLine());
                        convertedTemp = (celsius * 9 / 5) + 32;
                        Console.WriteLine($"{celsius}°C is equal to {convertedTemp}°F");
                        break;
                    case "2":
                        Console.WriteLine("Enter the temperature in Fahrenheit:");
                        double fahrenheit = Convert.ToDouble(Console.ReadLine());
                        convertedTemp = (fahrenheit - 32) * 5 / 9;
                        Console.WriteLine($"{fahrenheit}°F is equal to {convertedTemp}°C");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

        }
    }
}