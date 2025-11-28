using Tyuiu.VyazovES.Sprint4.Task6.V20.Lib;

DataService ds = new DataService();

string[] subjects = { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };
subjects = ds.Calculate(subjects);


Console.WriteLine(s);


Console.ReadKey();
