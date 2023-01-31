// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом (НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine ("Введите пятизначное число");
int.TryParse (Console.ReadLine(), out int n);

if (n < 9999 || n > 99999) {
Console.WriteLine("Число должно быть пятизначным");
return;
}

int temp = n;
int rev = 0;

while(n > 0)
   {    int dig = n % 10;
        rev = rev * 10 + dig;
        n = n / 10;
    }

if(temp == rev)
    Console.WriteLine ("Это палиндром!");

else
    Console.WriteLine("Это не палиндром!");
