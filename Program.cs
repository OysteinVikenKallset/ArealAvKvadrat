using System;

class Program
{
    static void Main(string[] args)
    {
        // Inform the user about the purpose of the program
        Console.WriteLine("Hei, vi skal beregne arealet av et rektangel. Derfor kan du skrive inn lengde og bredde. ");

        // Use the GetInput method to get the length and width from the user
        // The GetInput method will print the prompt, read the user's input, try to convert it to an int, and return the int or null
        int? lengde = GetInput("Skriv inn lengde: ");
        int? bredde = GetInput("Skriv inn bredde: ");

        // If both length and width are not null (i.e., the user entered valid integers for both), calculate the area
        if (lengde != null && bredde != null)
        {
            // Calculate the area and print it to the console
            int areal = lengde.Value * bredde.Value;
            Console.WriteLine($"Arealet er {areal}");
        }
        else
        {
            // If either length or width is null (i.e., the user did not enter a valid integer for one or both), print an error message
            Console.WriteLine("Det er noe feil med input");
        }
    }

    static int? GetInput(string prompt)
    {
        // Print the prompt to the console
        Console.WriteLine(prompt);
        // Try to parse the user's input as an int
        // If the input can be parsed, return the int
        // If the input cannot be parsed, print an error message and return null
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Ingen gyldig verdi ble skrevet inn.");
            return null;
        }
    }
}

/*using System;

class Program
{
    static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hei, vi skal beregne arealet av et rektangel. Derfor kan du skrive inn lengde og bredde. ");

        // Create a string variable and get user input from the keyboard and store it in the variable
        int? lengde;
        int? bredde;
        int? areal;

        Console.WriteLine($"Skriv inn lengde: ");
        lengde = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"Skriv inn Bredde: ");
        bredde = Int32.Parse(Console.ReadLine());

        if (lengde != null && bredde != null)
        {
            areal = lengde * bredde;
            Console.WriteLine($"Arealet er {areal}");
        }
        else
        {
            Console.WriteLine("Det er noe feil med input");
        }
    }
}*/
