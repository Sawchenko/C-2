// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a>99)
{
 while (true)
 {
    a=a/10;
 }
 Console.Write("Третья по счету цифра: {0}" , a%10);
}
else Console.Write("Третьей цифры нет");
