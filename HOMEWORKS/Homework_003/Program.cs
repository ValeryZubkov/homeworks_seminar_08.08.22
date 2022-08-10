// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Задайте номер четверти декартовой системы координат: ");
int number = int.Parse(Console.ReadLine());
string range = "";
if(number == 1) range = "x>0, y>0";
if(number == 2) range = "x<0, y>0";
if(number == 3) range = "x<0, y<0";
if(number == 4) range = "x>0, y<0";
Console.WriteLine("Диапазон координат (x,y) для " + number + "-й четверти будет принимать следующее значение: " + range +".");
