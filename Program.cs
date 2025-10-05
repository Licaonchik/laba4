Console.WriteLine("Введите конечное число");
double n = Convert.ToInt32(Console.ReadLine());
double g = 0;
for (int i = 1; i <= n; i++)
{
    g = i*10+1;
    Console.WriteLine(g);

}

