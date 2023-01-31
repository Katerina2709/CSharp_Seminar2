// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 == 0)
{
    Console.WriteLine("В заданном числе третьей цифры нет.");
}
else
{
   int result = 0;
   int count = Math.Abs(number); // число может быть отрицательным
   while (count >= 100)
   {
     result = count % 10;
     count = count / 10;
   }
   Console.WriteLine($"Третья цифра числа = {result}");
}
