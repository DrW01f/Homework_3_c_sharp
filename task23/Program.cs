// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N

Console.Clear();

Console.WriteLine ("Введите число");
int count = int.Parse(Console.ReadLine()!);
int i = 1;
while (i < count)
{
    double result = Math.Pow(i,3);
    Console.Write(result + ", ");
    i ++;
}
Console.Write(Math.Pow(i,3)); //для выведения последнего числа без запятой