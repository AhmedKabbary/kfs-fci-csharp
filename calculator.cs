using System;

Console.WriteLine("WELCOME TO MY CALCULATOR");

while (true)
{

    Console.WriteLine("------------------------------");

    double firstNum = 0;
    double secondNum = 0;

    // we can use (try and catch) to solve non numbers inputs error
    Console.Write("Enter the first number: ");
    firstNum = double.Parse(Console.ReadLine());

    Console.Write("Enter the second number: ");
    secondNum = double.Parse(Console.ReadLine());

    Console.Write("Enter the operator: ");
    string opt = Console.ReadLine();
    Console.WriteLine("");

    switch (opt)
    {
        case "+":
            Console.WriteLine($"Result: {firstNum} + {secondNum} = {firstNum + secondNum}");
            break;
        case "-":
            Console.WriteLine($"Result: {firstNum} - {secondNum} = {firstNum - secondNum}");
            break;
        case "*":
            Console.WriteLine($"Result: {firstNum} * {secondNum} = {firstNum * secondNum}");
            break;
        case "/":
            if (secondNum != 0)
            {
                Console.WriteLine($"Result: {firstNum} / {secondNum} = {firstNum / secondNum}");
            }
            else
            {
                Console.WriteLine("cannot divide by zero");
            }
            break;
        default:
            Console.WriteLine("Invalid operator");
            break;
    }

}
