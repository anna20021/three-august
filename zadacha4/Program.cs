// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("enter numberA");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter numberB");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter numberC");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA>numberB & numberA>numberC)
{
    Console.WriteLine("numberA");
}
else if (numberB>numberA & numberB>numberC)
{
    Console.WriteLine("numberB");
}
else if (numberC>numberB & numberC>numberA)
{
    Console.WriteLine("numberC");
}
