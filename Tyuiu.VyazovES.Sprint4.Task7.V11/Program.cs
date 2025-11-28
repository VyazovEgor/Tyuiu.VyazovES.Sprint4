using Tyuiu.VyazovES.Sprint4.Task7.V11.Lib;

DataService ds = new DataService();
string str = "56789012";
int rows = 4, cols = 2;
int a = ds.Calculate(rows, cols, str);


Console.WriteLine(a);


Console.ReadKey();
