using Tyuiu.VyazovES.Sprint4.Task0.V22.Lib;

DataService ds = new DataService();
int s;
int[] a= { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
s = ds.GetSumOddArrEl(a);


Console.WriteLine(s);


Console.ReadKey();
