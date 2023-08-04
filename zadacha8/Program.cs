// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());

int i = 1;
int a = 0;
while (i <= number)
{
a = i % 2 ==0;
Console.WriteLine(a);
i = i+1;
}


