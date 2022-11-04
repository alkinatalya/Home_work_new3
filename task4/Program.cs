/* Напишите программу, которая принимает на вход число (N) и выдает 
таблицу простых чисел от 1 до N
11 -> 2, 3, 5 , 7, 11*/
Console.WriteLine("Введите второе число диапазона от 1 до N:");
int number = int.Parse(Console.ReadLine()!);
void PrimeNumbers(int value)
{
    int i = 2;
 while (value % i != 0)
 {
   i++; 
 }
 if (value == i)
 {
    System.Console.Write($"{i}, ");
 }
}
void AllPrime(int number)
{
 int value = 2;
 while (value < number+1)
  {
   PrimeNumbers(value);
   value++;
  }
}
if (number == 1)
{
   System.Console.WriteLine("В простых чисел нет");  
}
else
{
  AllPrime(number);  
}
System.Console.WriteLine();