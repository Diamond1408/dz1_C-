//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
System.Console.WriteLine("Введите любое число начиная от 1:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
    while ( count <= number)
    {
       System.Console.WriteLine(count);
       count = count + 2;
    }