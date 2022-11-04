/*Задача 19 Напишите программу, которая принимает на вход пятизначное
 число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
int NumberReverse(int number, int reverse)
{
    while (number > 0)
    {
        int number1 = number % 10;
        reverse = reverse * 10 + number1;
        number /= 10;
    }
    return reverse;
}
void NumberPalindrome(int number, int number2)
{
    if (number == number2)
    {
        System.Console.WriteLine($" Число: {number} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число: {number} не является палиндромом");
    }
}
Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine()!);
if (number > 9999 && number < 100000)
{
    int reverse = 0;
    int number2 = NumberReverse(number, reverse);
    NumberPalindrome(number, number2);
}
else
{
    System.Console.WriteLine("Ошибка..");
}