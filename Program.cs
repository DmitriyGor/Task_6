/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Например:
4 -> да
-3 -> нет
7 -> нет
*/

int Number = 0;
Console.Write("Enter the number:  ");
Number = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 == int.Parse
Console.WriteLine("------------------------");

if (Number % 2 == 0)
{
    Console.WriteLine ("Number " + Number + " is EVEN (четное) ");
}
else
{
    Console.WriteLine ("Number " + Number + " is ODD (нечетное) ");
}
