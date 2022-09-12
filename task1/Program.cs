// Задача 19 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int reverse = 0;
int buffer = number;
while (buffer > 0)
	{
		reverse *= 10;		        
		reverse += buffer % 10;    
		buffer /= 10;
	}
if (number == reverse)
	{
		Console.Write($"Число {number} палиндром");
	}
	else
	{
		Console.Write($"Число {number} НЕ палиндром");
	}