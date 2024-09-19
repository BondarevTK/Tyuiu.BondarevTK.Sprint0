using Tyuiu.BondarevTK.Sprint0.Task5.V0.Lib;
namespace Tyuiu.BondarevTK.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(5, 10));
            Console.WriteLine("A - B = " + DataService.Subtraction(5, 10));
            Console.WriteLine("A * B = " + DataService.Multiplication(5, 10));
            Console.WriteLine("A / B = " + DataService.Division(5, 0));
            Console.ReadKey();
        }
    }
}