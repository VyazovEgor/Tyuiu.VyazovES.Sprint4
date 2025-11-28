using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VyazovES.Sprint4.Task6.V20.Lib
{
    public class DataService : ISprint4Task6V20
    {
        public string[] Calculate(string[] array)
        {
            List<string> resultList = new List<string>();

            Array.ForEach(array, subject =>
            {
                if (subject.Length < 10)
                    resultList.Add(subject);
            });

            return resultList.ToArray();
        }
    }
}

