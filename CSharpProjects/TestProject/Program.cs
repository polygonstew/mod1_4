Random dice = new Random();

int roll1 = dice.Next(1, 7); // <-- So 0 will include 1 and 6, but not 7. It's a 5 sided die at the moment.
int roll2 = dice.Next(0, 7);
int roll3 = dice.Next(0, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (total > 14)
{
    Console.WriteLine("You win!");
}
if (total < 15)
{
    Console.WriteLine("You lose!");
}