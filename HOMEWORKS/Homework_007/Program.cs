// Определить количество цифр в числе
Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
int digitNumber = 1;
while(number / 10 >= 1 || number / 10 <= -1)
{
    number = number / 10;
    digitNumber = digitNumber + 1;
}
Console.WriteLine("Введенное Вами число состоит из " + digitNumber + " цифр(ы).");