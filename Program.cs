using CALCULATR.classes;

Console.WriteLine("Hello, please enter a number!");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter another number!:");
int b = Convert.ToInt32(Console.ReadLine());

Calculater calc= new Calculater(a, b);
string operation;
do
{
    System.Console.WriteLine("Enter operation(+,-,*,/,%), 0 - quit");
    operation = Console.ReadLine();
    calc.GetOperation(operation);

}while(operation != "0");

Console.WriteLine(calc.Compare());

calc.CheckSign();