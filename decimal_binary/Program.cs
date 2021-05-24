using System;

public class decimal_binary
{
    public static void Main(string[] args)
    {
        //Main Menu
        Console.WriteLine("Would you like to convert (Press 1 or 2):\n1.Decimal to Binary?\n-OR-\n2.Binary to Decimal?");
        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                Console.WriteLine("Enter a decimal:");
                Console.WriteLine(ToBinary(int.Parse(Console.ReadLine())));
                break;
            case "2":
                Console.WriteLine("Enter a binary:");
                Console.WriteLine("Decimal is: {0}", ToDecimal(int.Parse(Console.ReadLine())));
                break;
            default:
                break;
        }
    }

    static string ToBinary(int number)
    {
        //Decimal To Binary
        string binary = "";
        int remainder;
        if (number == 0)
            return "Binary is: 0";
        else while (number > 0)
            {
                remainder = number % 2;
                number /= 2;
                binary = remainder.ToString() + binary;
            }
        return ($"Binary is: {binary}");
    }

    static int ToDecimal(int number)
    {
        //Binary To Decimal
        //Initialize the power of 2 at 1, which is 2^0
        int power = 1;
        int result = 0;
        int remainder;
        if (number == 0)
            return 0;
        else while (number > 0)
            {
                remainder = number % 10;
                number /= 10;
                result += remainder * power;
                power *= 2; //by multiplying by 2 each time, we essentially increase the power of 2 by one and achieve the following: 2^0 -> 2^1 -> 2^2 etc
            }
        return result;
    }
}

