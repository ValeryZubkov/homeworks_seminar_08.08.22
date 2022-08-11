// Подсчитать сумму цифр в числе
Console.WriteLine("Введите любое целое число: ");
int number = int.Parse(Console.ReadLine());
int Digitsnumber(int numb)   // функция подсчета количества цифр в числе
{
int digitNumber = 1;
while(numb / 10 >= 1 || numb / 10 <= -1)
{
    numb = numb / 10;
    digitNumber = digitNumber + 1;
}
return digitNumber;
}

int Digitindex(int number, int index) // функция находждения любой цифры числа
{
int digitIndex = 0;
int parametr = 1;        
int count = 0;
//index = 1;
while(count < (Digitsnumber(number) - index)) //цифра 3 в условии работает при числе от 3-х цифр, сюда как раз и попадают такие числа; поменяв ее, мы можем найти любую цифру числа.
      {
      parametr = parametr * 10;  // найдена закономерность изменения переменной parametr при увеличении разряда чисел.
      count++;
      }
    if(number > 99)                  //проверка на положительное-отрицательное
    {
    digitIndex = number / parametr % 10;
    }
    else
    {
    digitIndex = -number / parametr % 10;
    } 

return digitIndex;

}
int ind = 5;
int digit = Digitindex(number, ind);
Console.WriteLine(digit);