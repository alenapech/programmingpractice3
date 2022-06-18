/* Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
 */

Random rand = new Random();
int n = rand.Next(1,10);
int i = 1;
while (i <= n)
{
Console.WriteLine($"{i} --> {Math.Pow(i, 3)}");
i++;
}
