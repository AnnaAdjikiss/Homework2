/* Задача 10: Напишите программу, которая принимает на вход
 трёхзначное число и на выходе показывает вторую цифру этого числа.
 Примеры: 456 -> 5       782 -> 8        918 -> 1*/

 int FindSecondNum(int num)
 {
    int result = (num / 10) % 10;
    return result;
 }

Console.WriteLine("Введите целое трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вторая цифра числа - " + FindSecondNum(num));
