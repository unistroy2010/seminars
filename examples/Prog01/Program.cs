/*
Напишите программу которая на вход принимает два числа 
и проверяет, является ли второе число квадратом первого
*/

Console.WriteLine("Введите число 1:");
int UserNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Возможный квадрат");
int UserNumber2 = Convert.ToInt32(Console.ReadLine());

if (UserNumber2 == UserNumber1 * UserNumber1)
{
    Console.WriteLine("true");
}
else
{
   Console.WriteLine("false"); 
}
