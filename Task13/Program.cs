/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
Пример: 645 -> 5    78 -> третьей цифры нет     32679 -> 6 */
void Find3Number(int arg1)
{
    string numString = Convert.ToString(arg1);
    int numLen = numString.Length;
    char[] arr;
     arr = numString.ToCharArray(0, numLen);
    Console.Write("Третья цифра - " + arr[2]);
}     
Console.WriteLine("Введите положительное целое число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99) Find3Number(num);
else Console.Write("третьей цифры нет");