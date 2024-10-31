using System;

class Program
{
    string GetUserInput()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        return input ?? "";
    }

    string ReverseString(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        return reversed;
    }

    string CapitalizeFirstLetter(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;

        char firstLetter = char.ToUpper(input[0]);
        return firstLetter + input.Substring(1);
    }

    public static void Main()
    {
        Program program = new Program();

        string userInput = program.GetUserInput();
        Console.WriteLine("You entered: " + userInput);
        Console.WriteLine("Reversed: " + program.ReverseString(userInput));

        string capitalizedInput = program.CapitalizeFirstLetter(userInput);
        Console.WriteLine("Capitalized first letter: " + capitalizedInput);
    }
}
