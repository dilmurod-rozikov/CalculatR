namespace CALCULATR.classes
{
    public class Calculater
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }

        public void GetInputs()
        {
            Console.WriteLine("Hello, please enter a number!");
            FirstNumber = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter another number!:");
            SecondNumber = Convert.ToInt32(Console.ReadLine());

        }
        public string PrintResult()
        {
                        //switch expression
            return Operation switch 
            {
                "+" => $"Addition: {FirstNumber + SecondNumber}",
                "-" => $"Subtraction: {FirstNumber - SecondNumber}",
                "*" => $"Multiplcation: {FirstNumber * SecondNumber}",
                "/" => $"Division: {FirstNumber / SecondNumber}",
                "%" => $"Reaminder: {FirstNumber % SecondNumber}",
                "0" => "0 - quiting.....",
                _ => "Operation is not found!!!"
            };
        }
        public bool CheckForPositivity()
        {
            return FirstNumber >= SecondNumber;
        }

        public void CheckSign()
        {
            if(FirstNumber > 0 && SecondNumber > 0)
                System.Console.WriteLine("Both numbers are positive numbers");
            else if(FirstNumber == 0 || SecondNumber == 0)
                System.Console.WriteLine("One of the numbers is zero");
            else if(FirstNumber == 0 && SecondNumber == 0)
                System.Console.WriteLine("Both of the numbers are zero");
            else if(FirstNumber < 0 || SecondNumber < 0)
                System.Console.WriteLine("One of the numbers is negative");
            else
                System.Console.WriteLine("Numbers are negative");

        }
    }
}