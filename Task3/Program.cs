// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
int prompt(string message)
{
Console.WriteLine(message);
string param = Console.ReadLine(); 
int a = int.Parse(param); 
return a;
}
int a = prompt("введите число");
if (a<100)
{
    System.Console.WriteLine("не трехзначное число");
}  
else
{
    while (a>1000)
    {
    a = a / 10;
    }
    a = a % 10;
    System.Console.WriteLine("Третья цифра числа: " + a);
}