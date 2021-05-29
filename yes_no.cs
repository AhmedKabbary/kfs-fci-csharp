using System;

// NOTE: DON'T RUN THE WHOLE FILE, JUST COPY THE PREFERRED SOLUTION

// logic: replace every "no" with "yes" in a string
// input: i said yes or no
// output: i said yes or yes

//------ Solution #1 (case-sensitive) ------

Console.WriteLine("Enter a string");
string input = Console.ReadLine();
string output = input.Replace("no", "yes");
Console.WriteLine(output);

//------ Solution #2 (case-insensitive) ------

Console.WriteLine("Enter a string");
string input = Console.ReadLine().ToLower();
string output = input.Replace("no", "yes");
Console.WriteLine(output);