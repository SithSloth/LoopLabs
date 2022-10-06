bool playAgain = true;


do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue (y/n)?");
    string userChoice = Console.ReadLine().ToLower();
    switch (userChoice)
    {
        case "yes":
        case "y":
        case "yea":
            playAgain = true;
            break;
        case "no":
        case "n":
        case "nah":
            Console.WriteLine("See ya later! Thanks for playing");
            playAgain = false;
            break;
    }
} while (playAgain == true);