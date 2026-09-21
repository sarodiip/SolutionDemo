using ClassLibraryDemo;

namespace ConsoleAppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Всем привет!");
            ClassDemo cd = new ClassDemo();

            Console.WriteLine("Введите значение переменной A:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной B:");
            int b = Convert.ToInt32(Console.ReadLine());

            int resultSum = cd.Sum(a, b);
            int resultMinus = ClassDemo.Minus(a, b);

            Console.WriteLine("A+B = " + resultSum);
            Console.WriteLine(a + "-" + b + "=" + resultMinus);

            Console.ReadLine();
        }
    }
}
