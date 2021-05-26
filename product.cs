using System;

// logic: return the product of four integers

//------ Solution ------

Console.WriteLine("Enter the first integer");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second integer");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third integer");
int thirdNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the fourth integer");
int fourthNum = Convert.ToInt32(Console.ReadLine());

int product = firstNum * secondNum * thirdNum * fourthNum;
Console.WriteLine("The product is " + product);