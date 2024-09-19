using Tyuiu.BondarevTK.Sprint0.Task4.V0.lib;
namespace Tyuiu.BondarevTK.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(5, 10));
            Console.WriteLine(DataService.Subtraction(5, 10));
            Console.WriteLine(DataService.Multiplication(5, 10));
            Console.WriteLine(DataService.Division(5, 5));
            Console.ReadKey();
        }
    }
}
