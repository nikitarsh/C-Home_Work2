﻿/* Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/


Console.Write("Введите число: ");

int Num = Convert.ToInt32(Console.ReadLine());

string NumStr = Convert.ToString(Num);

if (NumStr.Length > 2)

{

Console.WriteLine("третья цифра -> " + NumStr[2]);

}

else

{
  Console.WriteLine("-> третьей цифры нет");

}