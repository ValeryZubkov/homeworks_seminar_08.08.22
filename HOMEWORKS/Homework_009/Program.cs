// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Ведите число N: ");
int number = int.Parse(Console.ReadLine());
//int index = 0;
int result = 1;
int numberNext = result + 1;
while(numberNext <= number)
{
  result = result * numberNext;
  numberNext++;
}
Console.WriteLine("Результат произведения чисел от 1 до " + number + " равен: " + result);