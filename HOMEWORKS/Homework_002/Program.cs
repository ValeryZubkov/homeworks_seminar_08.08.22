// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Ведите Первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите Второе число: ");
int numberB = int.Parse(Console.ReadLine());
if(numberA == numberB * numberB || numberB == numberA * numberA)
{
  Console.WriteLine("Ура! Одно из чисел является квадратом другого.");
}
else
{
  Console.WriteLine("К сожалению, ни одно из чисел не является квадратом другого.");
}