Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
int due = daysUntilExpiration; 
Console.WriteLine($"Your subscription expires in {due} days.");
if (due == 0)
   {
        Console.WriteLine("Your subscription has expired.");
   }
else if ( due == 1 )
   {
        Console.WriteLine($"Your subscription expires within a day! \n Renew now and save 20%!");
        discountPercentage = 20;
   }
else if ( due <= 5)
   {
        Console.WriteLine($"Your subscription expires in 5 days. \n Renew now and save 10%!");
        discountPercentage = 10;

   }
else if (due <= 10)
   {
        
        Console.WriteLine("Your sub will expire soon. Renew now!");
   }
if (discountPercentage > 0) 
   { 
        Console.WriteLine($"You are eligible for a {discountPercentage}% discount!");
   }