namespace CALCULATR.classes
{
    public class Calculater
    {
        public int a;
        public int b;
        public Calculater(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void GetOperation(string op)
        {
                    //switch expression
        string result = op switch 
        {
            "+" => $"Addition: {a + b}",
            "-" => $"Subtraction: {a - b}",
            "*" => $"Multiplcation: {a * b}",
            "/" => $"Division: {a / b}",
            "%" => $"Reaminder: {a % b}",
            "0" => "0 - quiting.....",
            _ => "Operation is not found!!!"
        };
        System.Console.WriteLine(result);
        }

        public string Compare()
        {
            string message = a >= b
                    ? "First number is greater than or equal to second nuumber"
                    : "Second number is greater than first number.";
            return message;
        }
        public void CheckSign()
        {
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

        }
    }
}