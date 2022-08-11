// Найти кубы чисел от 1 до N
Console.WriteLine("Введите целое число N: ");
int number = int.Parse(Console.ReadLine());
int indexCube = 1;
Console.WriteLine("Таблица кубов чисел от 1 до " + number + ":");
while (indexCube <= number)
{
    Console.WriteLine(indexCube * indexCube * indexCube);
    indexCube++;
}


