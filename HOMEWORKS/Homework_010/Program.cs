// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите целое число для нахождения в его пределах кубов, заканчивающихся на четную цифру: ");
int number = int.Parse(Console.ReadLine());
int index = 1;
Console.WriteLine("Кубы чисел от 1 до " + number + ", заканчивающиеся на четную цифру:");
while (index <= number)
{  int result = index * index * index;
   if(result % 2 == 0)
    { 
    Console.WriteLine(index + "^3 = " + result);
    }
index++;   
}
