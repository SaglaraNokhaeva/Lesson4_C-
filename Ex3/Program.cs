﻿// Вычисление чисел Фиббоначи
//f(1)=1
//f(2)=1
//f(n)=f(n-1)+f(n-2)
Console.Clear();  
Console.WriteLine("Введите n");
double n = Convert.ToDouble(Console.ReadLine());

double Fibbonachi (int n)
{
    if(n==1||n==2) return 1;
    else return Fibbonachi(n-1)+Fibbonachi(n-2);
}
for (int i=1; i<n;i++)
{
    Console.WriteLine($"f({i})={Fibbonachi(i)}");
}
