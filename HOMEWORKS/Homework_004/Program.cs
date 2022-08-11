// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Задайте пространство для подсчета расстояния между двумя точками в формате <2D> или <3D>: ");
string obl = Console.ReadLine();
double x1 = 41;
double y1 = 25;
double z1 = 33;
double x2 = -63;
double y2 = -76;
double z2 = 101;
if(obl.ToLower() != "2d" && obl.ToLower() != "3d")
{
   Console.WriteLine("К сожалению, Вы неправильно задали пространство. Повторите попытку.");   
}
else
{
    if(obl.ToLower() == "2d")
   {
    double result = Math.Sqrt((x2 - x1) * (x2-x1) + (y2 - y1) * (y2 - y1));
    Console.WriteLine("Расстояние между точками в пространстве 2D равно: " + result.ToString("0.00"));
   }
   else
   {
    double result = Math.Sqrt((x2 - x1) * (x2-x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    Console.WriteLine("Расстояние между точками в пространстве 3D равно: " + result.ToString("0.00"));
   }
}
