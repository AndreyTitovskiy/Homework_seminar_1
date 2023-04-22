//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int maxNumber = numberC;
if (numberB > maxNumber)
{
Console.WriteLine($"Max = {numberB}");
}
else if (numberA > maxNumber)
{
    Console.WriteLine($"Max = {numberA}");
}
else
{
    Console.WriteLine($"Max = {numberC}");
}
    