using Tyuiu.VyazovES.Sprint4.Task1.V2.Lib;

DataService ds = new DataService();
int s;
int len;
len = Convert.ToInt32(Console.ReadLine());
int[] a = new int[len];


for (int i = 0; i <= len; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}

s = ds.Calculate(a);


Console.WriteLine(s);


Console.ReadKey();
