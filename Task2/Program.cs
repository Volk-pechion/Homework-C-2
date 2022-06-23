// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа
int N = new Random().Next(100,999);
System.Console.WriteLine(N);

int result = (N/100)*10+N%10;
System.Console.WriteLine(result);

