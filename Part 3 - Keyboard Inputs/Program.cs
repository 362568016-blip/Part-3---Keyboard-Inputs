string name;
Console.WriteLine("Greeting!, Whats your name?");
name = Console.ReadLine();
Console.WriteLine($"Great! {name} Now, whats your age?");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Awsome {name}, your {age}! Lastly, type in the current year.");
int year = Convert.ToInt32(Console.ReadLine());
int bornYear = (bornYear = (year) - (age));
Console.WriteLine($"Wow {year} That must mean you were born in {bornYear}!");


Console.WriteLine($"Alright {name}, Let's do some math! Start by typing in a number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Nice {name}! Now number 2");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Okay, Just one last number.");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int forthNumber = (forthNumber = (firstNumber) + (secondNumber) + (thirdNumber));
Console.WriteLine($"Sweet! So if I add these numbers together, than you will get {forthNumber}!");


Console.WriteLine($"Alright {name}, Im going to calculate a thing. Start by typing in a travel time in Km's");
int firstKM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Nice {name}! Now number 2");
int secondKM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Okay, Just one last number.");
int thirdKM = Convert.ToInt32(Console.ReadLine());
int kmTotal = (kmTotal = (firstKM + secondKM + thirdKM / 3));
Console.WriteLine($"if I total these numbers together, the average would be {kmTotal} KM!");


//i dont wanna do advance math