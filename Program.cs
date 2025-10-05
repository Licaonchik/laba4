// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите конечное число");
double n = Convert.ToDouble(Console.ReadLine());
double g = 0;
double i = 1;
while (i <= n)
{
    g = i * 10 + 1;
    i++;
    
    Console.WriteLine(g);

} 
