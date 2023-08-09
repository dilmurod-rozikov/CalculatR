Console.WriteLine("Hello, please enter a number!");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter another number!:");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Addition: {a+b}");

System.Console.WriteLine($"Subtraction: {a-b}");

System.Console.WriteLine($"Multiplication: {a*b}");

System.Console.WriteLine($"Division: {a/b}");

System.Console.WriteLine($"Remainder: {a%b}");

if(a>b)
    System.Console.WriteLine("First number is greater than second number.");
else if(a == b)
    System.Console.WriteLine("First number is equal to second number.");
else
    System.Console.WriteLine("Second number is greater than first number.");

