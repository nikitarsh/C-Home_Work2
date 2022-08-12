/*
Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет,
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int DayOfWeek = new int();
Console.WriteLine("Введите день недели: ");

DayOfWeek = Convert.ToInt32(Console.ReadLine());

if (DayOfWeek == 6 || DayOfWeek == 7)
{
    Console.WriteLine("Этот день недели выходной");
} 
else if (DayOfWeek < 1 || DayOfWeek > 7) {
    Console.WriteLine("В неделе всего 7 дней! ");

}
else Console.WriteLine("Этот день недели рабочий");


