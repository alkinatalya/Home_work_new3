/*Задача 23 Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
void CubeNumber()
{
    int index = 1;
    while (index <= number)
    {
        System.Console.WriteLine($"Куб, числа {index} это {index * index * index}");
        index++;
    }
}
CubeNumber();