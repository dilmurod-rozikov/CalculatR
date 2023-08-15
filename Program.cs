using CALCULATR.classes;


Calculater calc= new Calculater();
calc.GetInputs();

do
{
    System.Console.WriteLine("Enter operation(+,-,*,/,%), 0 - quit");
    calc.Operation = Console.ReadLine();
    System.Console.WriteLine(calc.PrintResult());

}while(calc.Operation != "0");

string message = calc.CheckForPositivity()
            ? "First number is greater than or equal to second nuumber"
            : "Second number is greater than first number.";
Console.WriteLine(message);

calc.CheckSign();