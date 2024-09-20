using Tyuiu.BondarevTK.Sprint0.Task6.V0.Lib;
namespace Tyuiu.BondarevTK.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("сумма элементов массива = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("разность элементов массива =" + DataService.SubtractionArray(numsArray));
            Console.WriteLine("произведение элементов массива =" + DataService.MultArray(numsArray));
            Console.ReadKey();
        }
    }
}
