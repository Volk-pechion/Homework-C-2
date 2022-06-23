// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
string param = Console.ReadLine(); 
int N = int.Parse(param); 
if ((N>=99) && (N<=999))
{
    System.Console.WriteLine(N%10);
}
else {
    System.Console.WriteLine("введено не трехзначное число");
}
