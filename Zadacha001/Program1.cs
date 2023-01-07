System.Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

if(a > b)
{
    System.Console.WriteLine("максимальное число - " + a);
}
else
{
    System.Console.WriteLine("максимальное число - " + b);

}