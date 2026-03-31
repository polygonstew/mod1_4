// Dice Roll

Random dice = new Random();
int roll = dice.Next(1, 7);
// int players = 0;
Console.WriteLine(" .----------------.  .----------------.  .----------------.  .----------------. ");
Console.WriteLine("| .--------------. || .--------------. || .--------------. || .--------------. |");
Console.WriteLine("| |  ________    | || |     _____    | || |     ______   | || |  _________   | |");
Console.WriteLine("| | |_   ___ `.  | || |    |_   _|   | || |   .' ___  |  | || | |_   ___  |  | |");
Console.WriteLine("| |   | |   `. \\ | || |      | |     | || |  / .'   \\_|  | || |   | |_  \\_|  | |");
Console.WriteLine("| |   | |    | | | || |      | |     | || |  | |         | || |   |  _|  _   | |");
Console.WriteLine("| |  _| |___.' / | || |     _| |_    | || |  \\ `.___.'\\  | || |  _| |___/ |  | |");
Console.WriteLine("| | |________.'  | || |    |_____|   | || |   `._____.'  | || | |_________|  | |");
Console.WriteLine("| |              | || |              | || |              | || |              | |");
Console.WriteLine("| '--------------' || '--------------' || '--------------' || '--------------' |");
Console.WriteLine(" '----------------'  '----------------'  '----------------'  '----------------' ");
Console.WriteLine("");
Console.WriteLine("Welcome to the Dice Roller!!! - Choose how many players! [1-4]");
Console.Write("[ 1 - 4 ] ");
//string pInput = Console.ReadLine();
//int players = Convert.ToInt32(pInput);


Console.WriteLine($"You rolled a {roll}!");

Console.WriteLine("Ready Player One?");
Console.WriteLine("Press any key to see the dice face...");
//Console.ReadKey();

switch (roll)
{
    case 1:
        Console.WriteLine(" ------- \n|       |\n|   o   |\n|       |\n ------- ");
        break;
    case 2:
        Console.WriteLine(" ------- \n|   o   |\n|       |\n|   o   |\n ------- ");
        break;
    case 3:
        Console.WriteLine(" ------- \n| o     |\n|   o   |\n|     o |\n ------- ");
        break;
    case 4:
        Console.WriteLine(" ------- \n| o   o |\n|       |\n| o   o |\n ------- ");
        break;
    case 5:
        Console.WriteLine(" ------- \n| o   o |\n|   o   |\n| o   o |\n ------- ");
        break;
    case 6:
        Console.WriteLine(" ------- \n| o   o |\n| o   o |\n| o   o |\n ------- ");
        break;
    
}

