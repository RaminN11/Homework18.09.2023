//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8


Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
int even = 2;
while (n >= even)
{
    Console.WriteLine(even + " ");
    even = even + 2;
}
