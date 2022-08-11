// Найти сумму чисел от 1 до А
Console.WriteLine("Введите целое число А: ");
int numberA = int.Parse(Console.ReadLine());
int sum = 1;
int numberNext = sum + 1;
while(numberNext <= numberA)
{
    sum = sum + numberNext;
    numberNext++;
}
Console.WriteLine("Сумма чисел от 1 до " + numberA + " составляет: " + sum);
