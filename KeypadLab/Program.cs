bool locked = true;
Console.WriteLine("Enter 5 digit combination please: ");
int numberOfTries = 1;
while (locked == true)
{

    int userNumber;
    int.TryParse(Console.ReadLine(), out userNumber);
    
    if (userNumber == 13579)
    {
        Console.WriteLine("Welcome home Mr. Stark");
        locked = false;
    }
    else
    {
        
        if (numberOfTries < 5)
        {
            Console.WriteLine("That combination simply will not do, please try again: ");
            numberOfTries++;
        }
        else if (numberOfTries == 5)
        {
            Console.WriteLine("Final guess before application exits: ");
            numberOfTries++;
        }else if (numberOfTries == 6)
        {
            Console.WriteLine($"maximum number of guesses allowed is {numberOfTries}, please exit and try again");
            break;
        }
        
        
    }
}
