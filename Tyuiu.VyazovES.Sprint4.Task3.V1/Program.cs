using Tyuiu.VyazovES.Sprint4.Task3.V1.Lib;

DataService ds = new DataService();
int s;
int[,] array = new int[,] {
            { 3, 4, 3, 4, 1 },
            { 8, 1, 6, 6, 9 },
            { 9, 8, 5, 1, 3 },
            { 1, 8, 7, 1, 2 },
            { 9, 9, 7, 5, 6 } };
s = ds.Calculate(array);


Console.WriteLine(s);


Console.ReadKey();
