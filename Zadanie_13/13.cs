// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write ("Введите целое число ");
string chislo = Console.ReadLine();
int dlina_chisla = chislo.Length; 
int N = Convert.ToInt32(chislo); 
int i = 0;

if (dlina_chisla >= 3)
{
    while (i < (dlina_chisla - 3)) //пока i не дойдет третьей цифры , делим N на 10
        {
            N = N/10;
            i++;
        }

Console.WriteLine(N % 10);
}
else  Console.WriteLine ("третьей цифры нет");


