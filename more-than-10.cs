using System;

// logic: accepts two numbers (where they both not greater than 10 or ask for new ones)

//------ Solution ------

while (true)
{
    Console.WriteLine("Enter the first number");
    double firstNum = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    double secondNum = double.Parse(Console.ReadLine());

    if (firstNum > 10 && secondNum > 10)
    {
        Console.WriteLine("Cannot accept two numbers where they are both greater than 10");
        Console.WriteLine("-------------------------------------------------------------");
        continue;
    }
    else
    {
        Console.WriteLine("The first number " + firstNum);
        Console.WriteLine("The second number " + secondNum);
        break;
    }

}