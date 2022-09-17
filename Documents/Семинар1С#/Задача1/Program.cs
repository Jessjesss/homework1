Console.Clear();

Console.Write("Введите 1 число: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);
Console.Write("Введите 2 число: ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);
if (number2 == (number1 / number2))
Console.WriteLine("Число 1 является квадратом числа 2!");
else
{
    Console.WriteLine("Число 1 не является квадратом числа 2!");
}