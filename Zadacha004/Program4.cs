System.Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

if(N<=1)
{
    System.Console.WriteLine("Введите число больше 1");
    return;
}


    System.Console.WriteLine("Все числа от 1 до " + N);
    for(int i = 1; i <= N; i++)
    {
        System.Console.Write(i + ",");
    }
