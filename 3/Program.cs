// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число для возведения в куб всех чисел от 1 до введенного числа");
if(!int.TryParse (Console.ReadLine(), out var n))
Console.WriteLine("Введено не целое число");

int count =1;

Console.Write( count*count*count);
count++;
while (count <= n) {
Console.Write(","+ count*count*count);

count++;
}