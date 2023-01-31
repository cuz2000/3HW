// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("Введите координату точки А на оси Х:");
if(!int.TryParse (Console.ReadLine(), out var x1))
Console.WriteLine("Введено не целое число");

Console.WriteLine ("Введите координату точки А на оси Y:");
if(!int.TryParse (Console.ReadLine(), out var y1))
Console.WriteLine("Введено не целое число");

Console.WriteLine ("Введите координату точки А на оси Z:");
if(!int.TryParse (Console.ReadLine(), out var z1))
Console.WriteLine("Введено не целое число");

Console.WriteLine ("Введите координату точки B на оси Х:");
if(!int.TryParse (Console.ReadLine(), out var x2))
Console.WriteLine("Введено не целое число");

Console.WriteLine ("Введите координату точки B на оси Y:");
if(!int.TryParse (Console.ReadLine(), out var y2))
Console.WriteLine("Введено не целое число");

Console.WriteLine ("Введите координату точки B на оси Z:");
if(!int.TryParse (Console.ReadLine(), out var z2))
Console.WriteLine("Введено не целое число");

double distance = Math.Sqrt( Math.Pow(x2-x1,2) - Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
Console.WriteLine($"Расстояние между точками А и В: {distance}");
