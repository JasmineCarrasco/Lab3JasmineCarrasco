//  while loop

int playersNumber = 9;
string input = Console.ReadLine();
while (playersNumber < 10 || playersNumber > 99)
{
    Console.WriteLine("Enter a number between 10 and 99: ");
    string playerResponse = Console.ReadLine();
    playersNumber = Convert.ToInt32(playerResponse);
    if (playersNumber % 23 == 0)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Green;
    }
    else
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Red;
    }

    if (input == "exit")
    {
        Console.WriteLine("Thank you for playing.");
        break;
    }
}


//Do while loop
do
{
    Console.WriteLine("Enter a number between 10 and 99");
    string playersResponse = Console.ReadLine();
    playersNumber = Convert.ToInt32(playersResponse);
}

while (playersNumber < 10 || playersNumber > 99);
if (playersNumber % 34 == 0)
{
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Green;
}
else
{
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Red;
}
if (input == "exit")
{
    Console.WriteLine("Thank you for playing.");
    Environment.Exit(1);
}
while (true) ;


//for loop
for (; ; )
{


    if (playersNumber % 33 == 0)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Green;
    }
    else
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Red;
    }
    {
        if (input == "exit")

            Console.WriteLine("Thank you for playing.");
        break;
    }


    while (true)
    {

        Console.WriteLine("Which route would you like to choose, +, -, *, /, or exit to end game?");
        string Guestinput = Console.ReadLine();

        switch (Guestinput)
        {
            case "add":
                Console.WriteLine("Enter your first number.");
                int AddnumberOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number.");
                int AddnumberTwo = int.Parse(Console.ReadLine());
                int Addresult = AddnumberOne + AddnumberTwo;
                Console.WriteLine("AddnumberOne + AddnumberTwo = Addresult");
                break;

            case "subtract":
                Console.WriteLine("Enter your first number.");
                int SubnumberOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number.");
                int SubnumberTwo = int.Parse(Console.ReadLine());
                int Subresult = SubnumberOne + SubnumberTwo;
                Console.WriteLine("SubnumberOne + SubnumberTwo = Subresult");
                break;

            case "multiply":
                Console.WriteLine("Enter your first number.");
                int MultinumberOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number.");
                int MultinumberTwo = int.Parse(Console.ReadLine());
                int Multiresult = MultinumberOne + MultinumberTwo;
                Console.WriteLine("MultinumberOne + MultinumberTwo = Multiresult");
                break;

            case "divide":
                Console.WriteLine("Enter your first number.");
                int DivnumberOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number.");
                int DivnumberTwo = int.Parse(Console.ReadLine());
                int Divresult = DivnumberOne + DivnumberTwo;
                Console.WriteLine("DivnumberOne + DivnumberTwo = Divresult");
                break;


            case "exit":
                Console.WriteLine("Thank you for playing!");
                Environment.Exit(1);
                break;
          
        }
    
        break;
     }
}    




















