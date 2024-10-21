// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter your name.");
string userName = Console.ReadLine();
bool continueRunning = true;

while (continueRunning)
{
    Console.WriteLine("Enter an integer between 1 and 100 inclusive");

    string numberInString = Console.ReadLine();
    bool isValidNumber = int.TryParse(numberInString, out int number);


    if (isValidNumber && number >= 1 && number <= 100)
    {
        if (number % 2 != 0 && number < 60)
        {
            Console.WriteLine($"{number} is Odd and less than 60.");
        }
        else if (number % 2 == 0 && number >= 2 && number <= 24)
        {
            Console.WriteLine("Even and less than 25.");
        }
        else if (number % 2 == 0 && number >= 26 && number <= 60)
        {
            Console.WriteLine("Even and between 26 and 60 inclusive.");
        }
        else if (number % 2 == 0 && number > 60)
        {
            Console.WriteLine($"{number} is Even and greater than 60.");
        }
        else if (number % 2 != 0 && number > 60)
        {
            Console.WriteLine($"{number} is Odd and greater than 60.");
        }
    }
    else
    {
        Console.WriteLine($"Invalid Input, {userName}.");
    }

    Console.WriteLine("Do you want to stop the program? (yes/no)");
    string userResponse = Console.ReadLine()?.ToLower();

    if (userResponse == "yes")
    {
        continueRunning = false;
    }
    else if (userResponse == "no")
    {
        continueRunning = true;
    }
    else
    {
        Console.WriteLine("Error 404");
    }
}




