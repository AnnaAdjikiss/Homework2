/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
Пример:  6 -> да        7 -> да     1 -> нет */
void DayNum (int num)
{
    if (num == 6 || num == 7) Console.WriteLine("это выходной!");
    else Console.WriteLine("это будний день"); 
}   
    
Console.WriteLine("Введите целое число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
DayNum(num);