/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
Console.WriteLine("Введите пятизначное число:");
int number=Convert.ToInt32(Console.ReadLine());
CheckPalindromNumber(number);

void CheckPalindromNumber(int number)
{
    if (number > 9999 & number < 100000)
    {
        int division1 = number / 10000;
        int remainder1 = number % 10;

        if (division1 == remainder1)
        {
            number = number / 10;
            int division2 = (number / 100) % 10;
            int remainder2 = number % 10;
            if (division2 == remainder2)
                Console.WriteLine("Да");
        }
        else
            Console.WriteLine("Нет");

    }
    else
        Console.WriteLine("Некорректное число!");
}


