Console.WriteLine("Hello, please enter a number!");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter another number!:");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter operation(+,-,*,/,%)");
string operation = Console.ReadLine();

switch (operation){
    case "+": 
        System.Console.WriteLine($"Addition: {a + b}"); 
        break;
    case "-": 
        System.Console.WriteLine($"Subtraction: {a - b}");
        break;
    case "*":
        System.Console.WriteLine($"Multiplcation: {a * b}");
        break;
    case "/":
        System.Console.WriteLine($"Division: {a / b}");
        break;
    case "%":
        System.Console.WriteLine($"Reaminder: {a % b}");
        break;
    default:
        System.Console.WriteLine("Operation is not found!!!");
        break;
}

// System.Console.WriteLine($"Addition: {a+b}");

// System.Console.WriteLine($"Subtraction: {a-b}");

// System.Console.WriteLine($"Multiplication: {a*b}");

// System.Console.WriteLine($"Division: {a/b}");

// System.Console.WriteLine($"Remainder: {a%b}");

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
