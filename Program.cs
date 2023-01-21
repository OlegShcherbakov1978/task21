// Задача 21

// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] coord1 = new int[3];

int[] coord2 = new int[3];


Console.Write("Введите координату x1: ");
coord1[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y1: ");
coord1[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z1: ");
coord1[2] = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2: ");
coord2[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y2: ");
coord2[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z2: ");
coord2[2] = Convert.ToInt32(Console.ReadLine());

double a = Math.Sqrt(Math.Pow((coord2[0] - coord1[0]), 2) + Math.Pow((coord2[1] - coord1[1]), 2) + Math.Pow((coord2[2] - coord1[2]), 2));

System.Console.WriteLine(Math.Round(a, 2));
