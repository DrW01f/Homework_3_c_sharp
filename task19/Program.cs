// Задача 19 Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

Console.Clear();

while (true)
{
    Console.WriteLine("Введите пятизначное число");
    int count = int.Parse(Console.ReadLine()!);

    if (count > 9999 && count < 100000)
    //Проверка на пятизначное число
    {
        int count1 = count % 10;
        int count5 = count / 10000;
        if (count1 == count5) //Если первая и пятая цифры равны
        {
            int count2 = count % 100 / 10;
            int count4 = count % 10000 / 1000;
            if (count2 == count4) //Если вторая и четвертая цифры равны
            {
                Console.WriteLine($"Число {count} является палиндромом");
                break;
            }
            Console.WriteLine($"Число {count} не является палиндромом");
            break;
        }
        Console.WriteLine($"Число {count} не является палиндромом");
        break;
    }
    else
    {
         Console.WriteLine("Это не пятизначное число. Попробуйте снова.");
    }
}

