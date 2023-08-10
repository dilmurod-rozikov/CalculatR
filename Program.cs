Console.WriteLine("Hello, please enter a number!");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter another number!:");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Addition: {a+b}");

System.Console.WriteLine($"Subtraction: {a-b}");

System.Console.WriteLine($"Multiplication: {a*b}");

System.Console.WriteLine($"Division: {a/b}");

System.Console.WriteLine($"Remainder: {a%b}");

string message = a >= b
        ? "First number is greater than or equal to second nuumber"
        : "Second number is greater than first number.";
System.Console.WriteLine(message);

if(a > 0 && b > 0)
    System.Console.WriteLine("Both numbers are positive numbers");
else if(a == 0 || b == 0)
    System.Console.WriteLine("One of the numbers is zero");
else if(a == 0 && b == 0)
    System.Console.WriteLine("Both of the numbers are zero");
else if(a < 0 || b < 0)
    System.Console.WriteLine("One of the numbers is negative");
else
    System.Console.WriteLine("Numbers are negative");
