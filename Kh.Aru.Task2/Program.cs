using System;


    class Program
{
    static void Main(string[] args)
    {
        //// Exercize 1
        //Console.WriteLine("Exercise 1:");
        //Console.Write("Enter first number: ");
        //double n1 = Convert.ToDouble(Console.ReadLine());
        //Console.Write("Enter second number: ");
        //double n2 = Convert.ToDouble(Console.ReadLine());

        //if (n1 == n2)
        //{
        //    Console.WriteLine("The numbers are equal.");
        //}
        //else if (n1 > n2)
        //{
        //    Console.WriteLine("The first number is greater than the second.");
        //}
        //else
        //{
        //    Console.WriteLine("The first number is less than the second.");
        //}
        //Console.WriteLine("--------------------");

        //Exercize 2
        //Console.WriteLine("Exercise 2:");
        //Console.Write("Enter a number: ");
        //double num2 = Convert.ToDouble(Console.ReadLine());

        //if (num2 > 5 && num2 < 10)
        //{
        //    Console.WriteLine("The number is greater than 5 and less than 10");
        //}
        //else
        //{
        //    Console.WriteLine("Unknown number");
        //}
        //Console.WriteLine("--------------------");

        //// Exercize 3
        //Console.WriteLine("Exercise 3:");
        //Console.Write("Enter a number: ");
        //double num3 = Convert.ToDouble(Console.ReadLine());

        //if (num3 == 5 || num3 == 10)
        //{
        //    Console.WriteLine("The number is either 5 or 10");
        //}
        //else
        //{
        //    Console.WriteLine("Unknown number");
        //}
        //Console.WriteLine("--------------------");

        // Exercize 4
        Console.WriteLine("Exercise 4:");
        Console.Write("Enter deposit amount: ");
        double money = Convert.ToDouble(Console.ReadLine());
        double percent = 0;

        if (money < 100)
        {
            percent = 0.05;
        }
        else if (money >= 100 && money <= 200)
        {
            percent = 0.07;
        }
        else
        {
            percent = 0.10;
        }

        double result4 = money + (money * percent);
        Console.WriteLine("Deposit amount including interest: " + result4);
        Console.WriteLine("--------------------");

        // Exercize 5
        Console.WriteLine("Exercise 5:");
        double bonus = 15;
        double result5 = result4 + bonus;
        Console.WriteLine("Final amount including interest and bonus (15): " + result5);
        Console.WriteLine("--------------------");

        // Exercize 6
        Console.WriteLine("Exercise 6:");
        Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Addition");
                break;
            case 2:
                Console.WriteLine("Subtraction");
                break;
            case 3:
                Console.WriteLine("Multiplication");
                break;
            default:
                Console.WriteLine("Operation is undefined");
                break;
        }
        Console.WriteLine("--------------------");

        // Exercize 7
        Console.WriteLine("Exercise 7:");
        Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
        int op = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter first value: ");
        double v1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second value: ");
        double v2 = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.WriteLine("Result: " + (v1 + v2));
                break;
            case 2:
                Console.WriteLine("Result: " + (v1 - v2));
                break;
            case 3:
                Console.WriteLine("Result: " + (v1 * v2));
                break;
            default:
                Console.WriteLine("Operation is undefined");
                break;
        }

        Console.WriteLine("\nDone!");
        Console.ReadLine();
    }
}

