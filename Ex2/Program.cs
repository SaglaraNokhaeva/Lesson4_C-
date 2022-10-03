// Вычисление факториала через рекурсию
Console.Clear();  
Console.WriteLine("Введите n");
double n = Convert.ToDouble(Console.ReadLine());

double Factorial (int n)
{
    if(n==1) return 1;
    else return n*Factorial(n-1);
}
for (int i=1; i<=n;i++)
{
    Console.WriteLine($"{i}!={Factorial (i)}");
}
