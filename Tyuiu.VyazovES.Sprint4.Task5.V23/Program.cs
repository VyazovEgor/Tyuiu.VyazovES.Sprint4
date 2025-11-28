using Tyuiu.VyazovES.Sprint4.Task5.V23.Lib;

DataService ds = new DataService();
int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[a, b];

for (int i = 0; i <= a; i++)
{
    for (int j = 0; j <= b; j++)
    {
        array[i, j] = Convert.ToInt32(Console.ReadLine());
    }

}
array = ds.Calculate(array);

for (int i = 0; i <= a; i++)
{
    for (int j = 0; j <= b; j++)
    {
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();

}

Console.ReadKey();

