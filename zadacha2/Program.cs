//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter numberA");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter numberB");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA>numberB)
{

    Console.WriteLine("numberA");
}

else if(numberB>numberA)
{
    Console.WriteLine("numberB");
}