double GetNumber()
{
    Console.Write("Enter a number: ");
    double number = Convert.ToDouble(Console.ReadLine());

    return number;
}

try
{
    double number1 = GetNumber();
    double number2 = GetNumber();
    Console.Clear();

    Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
    Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
    Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
    Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
}
catch (FormatException)
{
    Console.WriteLine("Number was not valid!");
}
catch (OverflowException)
{
    Console.WriteLine("Number is too big!");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Division by zero is not possible!");
}
catch (Exception)
{
    Console.WriteLine("Unknown Exceptoin!");
}

