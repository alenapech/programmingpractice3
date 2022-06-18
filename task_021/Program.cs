/*Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними
 в 3D пространстве.
 */

Random rand = new Random();
int x1 = rand.Next (0,10);
int y1 = rand.Next (0,10);
int z1 = rand.Next (0,10);
int x2 = rand.Next (0,10);
int y2 = rand.Next (0,10);
int z2 = rand.Next (0,10);
double res = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));
Console.WriteLine($"{res} расстояние между двумя точками");

