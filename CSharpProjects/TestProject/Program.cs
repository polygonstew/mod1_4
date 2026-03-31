Random rnum = new Random();
int total = 0;
int bob = rnum.Next(100);

Console.WriteLine($"Bob is {bob}");
bob = rnum.Next(100);
Console.Write("Name, please...");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}... is that Latin?");
Console.Write($"Well {name}, your number is {bob}");