// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write ("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int ost = 0;
if ((Math.Abs(number) < 100) || (Math.Abs(number) > 999)) 
{  
    Console.WriteLine("Число не соответствует условию.");
}
else
{    
    if (number > 0) ost = number % 100;
    else ost = Math.Abs(number) % 100;
    Console.WriteLine($"Вторая цифра числа = {ost / 10}");
}