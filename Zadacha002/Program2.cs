System.Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());


if(a>b && a>c)
{
    System.Console.WriteLine("Максимальное число " + a);
}
else if(b>a && b>c)
{
    System.Console.WriteLine("Максимальное число " + b);
}
else if(c>a && c>b)
{
    System.Console.WriteLine("Максимальное число " + c);
}
else if(a==b && a>c)
{
    System.Console.WriteLine("Максимальные 'a' и 'b' они равны " + b);
}
else if(a==c && c>b)
{
    System.Console.WriteLine("Максимальные 'a' и 'c' они равны " + a);
}
else if(c==b && b>a)
{
    System.Console.WriteLine("Максимальные 'b' и 'c' они равны " + c);
}
else
{
    System.Console.WriteLine("Числа равны");
}