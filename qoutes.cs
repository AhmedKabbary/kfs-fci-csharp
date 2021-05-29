using System;

// NOTE: DON'T RUN THE WHOLE FILE, JUST COPY THE PREFERRED SOLUTION

// logic: place double qoutes around each word in a string
// input: my name is ahmed
// output: "my" "name" "is" "ahmed"

//------ Solution #1 ------

Console.WriteLine("Enter a string");
string input = Console.ReadLine();

// split the input string into an array of words (seperated by spaces)
string[] words = input.Split(" ");

string output = "";

for (int i = 0; i < words.Length; i++)
{
    output += '"' + words[i] + '"';

    // check if it isn't the last word to add a space after it
    if (i != words.Length - 1)
    {
        output += " ";
    }
}
Console.WriteLine(output);

//------ Solution #2 (by using arrays) (advanced) ------

Console.WriteLine("Enter a string");
string input = Console.ReadLine();

string[] words = input.Split(" ");

string[] outputArr = new string[words.Length];

for (int i = 0; i < words.Length; i++)
{
    outputArr[i] = '"' + words[i] + '"';
}

// join the array words in a string with spaces between them
string output = String.Join(' ', outputArr);
Console.WriteLine(output);