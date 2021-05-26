using System;

// NOTE: DON'T RUN THE WHOLE FILE, JUST COPY THE PREFERRED ANSWER

// logic: return the string in reverse order
// input: my name is ahmed
// output: demha si eman ym

//------ Solution #1 (reversed loop) ------

Console.WriteLine("Enter a string");
string input = Console.ReadLine();
char[] charactersArray = input.ToCharArray();
char[] reversedArray = new char[charactersArray.Length];

int n = 0;
for (int i = charactersArray.Length - 1; i >= 0; i--) // starting from the end of the array
{
    /*
        add the last item from old array (i)
        into the first item in the new array (n)
        that's why n starts from 0 and i from last index
    */
    reversedArray[n] = charactersArray[i];
    n++;
}
string output = new String(reversedArray);
Console.WriteLine(output);

//------ Solution #2 (normal loop) ------

Console.WriteLine("Enter a string");
string input = Console.ReadLine();
char[] charactersArray = input.ToCharArray();
char[] reversedArray = new char[charactersArray.Length];

for (int i = 0; i < charactersArray.Length; i++) // starting from the beginning of the array
{
    /*
        array index starts from zero
        so the last item index is (length of array - 1)
        i starts from zero
        that's why we will use [ length - (i + 1) ] to get items in reverse
        first case when i = 0, it will get the last item [length - (0 + 1)]
    */
    reversedArray[i] = charactersArray[charactersArray.Length - (i + 1)];
}
string output = new String(reversedArray);
Console.WriteLine(output);

//------ Solution #3 (using predefined methods) ------

Console.WriteLine("Enter a string");
string input = Console.ReadLine();
char[] charactersArray = input.ToCharArray();
Array.Reverse(charactersArray);
string output = String.Concat(charactersArray);
Console.WriteLine(output);