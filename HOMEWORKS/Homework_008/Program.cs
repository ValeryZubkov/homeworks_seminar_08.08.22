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

int Digitindex(int number, int index) // функция нахождения любой цифры числа(работает в связке с функцией Digitsnumber)
{
int digitIndex = 0;
int parametr = 1;        
int count = 0;
while(count < (Digitsnumber(number) - index)) //  меняя index, мы можем найти любую цифру числа.
      {
      parametr = parametr * 10;  // найдена закономерность изменения переменной parametr при увеличении разряда чисел.
      count++;
      }
if(number > 0)                  //проверка на положительное-отрицательное, т.к. будем считать сумму цифр не зависимо от знака числа.
   {
    digitIndex = number / parametr % 10;
   }
    else
   {
    digitIndex = -number / parametr % 10;
   } 

return digitIndex;
}
int sum = 0;
int ind = 1;
while(ind <= Digitsnumber(number))
{
sum = sum + Digitindex(number, ind);
ind++;
}
Console.WriteLine("Сумма всех цифр введенного Вами числа составляет: " + sum);