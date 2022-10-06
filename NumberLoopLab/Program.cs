bool playAgain = true;
while (playAgain == true)
{
    Console.WriteLine("Enter a number please");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    for (int i = userNumber; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
    for (int i = 0; i <= userNumber; i++)
    {
        Console.WriteLine(i);
    }
    
    Console.WriteLine("Would you like to keep going? y/n");
    string userChoice = Console.ReadLine().ToLower();
    switch (userChoice)
    {
        case "n":
        case "no":
            Console.WriteLine("GoodBye");
            playAgain = false;
            break;
        default:
            playAgain = true;
            break;
    }



}
