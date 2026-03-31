/*
string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}
*/


Random dice = new Random();

int roll1 = dice.Next(1, 7); // <-- So 0 will include 1 and 6, but not 7. It's a 5 sided die at the moment.
int roll2 = dice.Next(0, 7);
int roll3 = dice.Next(0, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (total > 14)
{
    Console.WriteLine("You win!");
    if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))


}
if (total < 15)
{
    Console.WriteLine("You lose!");
}
if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
    }
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}
if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled the mark of the beast! +666 bonus to total!");
    total += 666;
}
Console.WriteLine($"Total: {total}");
