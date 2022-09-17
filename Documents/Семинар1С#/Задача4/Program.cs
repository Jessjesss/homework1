Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if((number < 1000) & (number > 99))
{
    Console.Write(number % 10);
}
else
{
    Console.Write("Число не соответствует условию");
}