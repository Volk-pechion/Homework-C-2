//Задача 4
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели: ");
string param = Console.ReadLine(); 
int d = int.Parse(param); 
if ((d==6 ) || (d==7))
{
        Console.WriteLine("Выходной");
}
else
{
        Console.WriteLine("не выходной");
}
