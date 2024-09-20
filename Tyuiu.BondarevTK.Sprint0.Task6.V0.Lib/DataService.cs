namespace Tyuiu.BondarevTK.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] num)
        {
            var total = 0;
            for (var i = 0; i < num.Length; i++)
            {
                total = total + num[i];
            }
            return total;
        }
        public static object SubtractionArray(int[] num)
        {
            var total = 0;
            int index = 0;
            while (index < num.Length)
            {
                total = total - num[index];
                index++;
            }
            return total;
        }
        public static object MultArray(int[] num)
        {
            var total = 1;
            int index = 0;
            do
            {
                total = total * num[index];
                index++;
            }
            while (index < num.Length);
            {
                return total;
            }
        }
    }
}