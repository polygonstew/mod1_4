
// Decision logic challenge

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin") && level >= 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (permission.Contains("Admin") && level < 55)
{ 
    Console.WriteLine("Welcome, Admin user.");
}

else if (permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine("Contact an Admin for access.");
}
else if (permission.Contains("Manager") && level > 20)
{ 
    Console.WriteLine("You do not have sufficient privileges.");
}
if (!permission.Contains("Manager") && !permission.Contains("Admin"))
{
    Console.WriteLine("You do not have sufficient privileges.");
}

// LEARN: Correct Code
//string permission = "Admin|Manager";
//int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}