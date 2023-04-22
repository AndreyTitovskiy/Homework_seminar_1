//Напишите программу, которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"Max = {numberA}");
    Console.WriteLine($"Min = {numberB}");
}
else
{
    Console.WriteLine($"Max = {numberB}");
    Console.WriteLine($"Min = {numberA}"); 
}