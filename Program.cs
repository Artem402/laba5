using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class OrdinaryCalc
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Mul(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            return x / y;
        }

    }
    class AdvancedCalc : OrdinaryCalc
    {
        public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0;
            var ord = new OrdinaryCalc();
            var adv = new AdvancedCalc();
            while (true)
            {
                Console.WriteLine("1 - Обычный калькулятор\n2 - Продвинутый калькулятор\nДругое - выход");
                var r = Console.ReadLine();
                if (r == "1")
                {
                    try
                    {
                        Console.WriteLine("Выберите действие +, - , *, / ");
                        var a = Console.ReadLine();
                        Console.WriteLine("Введите первое число: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        if (a == "+") Console.WriteLine($"Ответ: {ord.Add(x, y)}");
                        else if (a == "-") Console.WriteLine($"Ответ: {ord.Sub(x, y)}");
                        else if (a == "*") Console.WriteLine($"Ответ: {ord.Mul(x, y)}");
                        else if (a == "/")
                        {
                            if (y == 0) throw new Exception();
                            Console.WriteLine($"Ответ: {ord.Div(x, y)}");
                        }
                        else Console.WriteLine("Действие выбрано неверно");
                    }
                    catch { Console.WriteLine("Числа введены неверно"); }
                }
                else if (r == "2")
                {
                    Console.WriteLine("Выберите действие +, -, *, /, sqrt ");
                    var a = Console.ReadLine();
                    try
                    {
                        if (a == "sqrt")
                        {
                            Console.WriteLine("Введите число: ");
                            x = Convert.ToDouble(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Введите первое число: ");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            y = Convert.ToDouble(Console.ReadLine());
                        }
                        if (a == "+") Console.WriteLine($"Ответ: {adv.Add(x, y)}");
                        else if (a == "-") Console.WriteLine($"Ответ: {adv.Sub(x, y)}");
                        else if (a == "*") Console.WriteLine($"Ответ: {adv.Mul(x, y)}");
                        else if (a == "/")
                        {
                            if (y == 0) throw new Exception();
                            Console.WriteLine($"Ответ: {adv.Div(x, y)}");
                        }
                        else if (a == "sqrt") Console.WriteLine($"Ответ: {adv.Sqrt(x)}");
                        else Console.WriteLine("Действие выбрано неверно");
                    }
                    catch { Console.WriteLine("Числа введены неверно"); }
                }
                else break;
            }
        }
    }
}
