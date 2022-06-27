/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int number = new Random().Next(1, 99999);

if (number < 100)
{
    Console.WriteLine($"{number} -> третей цифры нет");
}

else if (number >= 100)
{
    string result = number.ToString();
    Console.WriteLine($"{number} -> {result[2]}");
}
