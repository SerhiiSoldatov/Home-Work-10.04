//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a, b, c;
a = 10;
b = 10;
c = 10;
if (a > b && a > c)
{
    System.Console.WriteLine($"Число {a} максимальное.");
}
else if (b > a && b > c)
{
    System.Console.WriteLine($"Число {b} максимальное.");
} 
else if (c > a && c > b)
{
    System.Console.WriteLine($"Число {c} максимальное.");
}
else if (a == b && b == c && c == a)
{
    System.Console.WriteLine($"Все числа равнозначны");
}