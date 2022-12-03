/*Задача 43: Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double b1 = ReadInt("Введите b1: ");
double k1 = ReadInt("Введите k1: ");
double b2 = ReadInt("Введите b2: ");
double k2 = ReadInt("Введите k2: ");
double x=0;
double y=0;

if (k1!=k2)
{
   x=(b2-b1)/(k1-k2);
   y=k1*x+b1; 
   Console.WriteLine($" -> ( {x} ; {y})");
}
else if (b1!=b2)
{Console.WriteLine("Прямые параллельны");}
else {Console.WriteLine("Прямые накладываются друг на друга");}


int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}