using System.Security.Cryptography;

namespace ConsoleApp2
{
    internal class Program

    {
        static void Main(string[] args)
        {
        nachalo:
            Console.Write("Выберите операцию:\r\n1. Сложить 2 числа\r\n2. Вычесть второе из первого\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Очистить консоль\r\n10. Выйти из программы\r\n");
            int Choise = Convert.ToInt32(Console.ReadLine());
            do
            {

                if (Choise == 1)                //Сложение - предельно просто
                {
                    Console.WriteLine("Выбрана операция сложения");
                    Console.WriteLine("Введите первое число");
                    double num1 = Convert.ToDouble(Console.ReadLine()); // Double - с плавающей точкой
                    Console.WriteLine("Введите второе число");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат операции = " + (num1 + num2));
                    goto nachalo;
                }
                else if (Choise == 2)                //Вычитание - предельно просто
                {
                    Console.WriteLine("Выбрана операция вычитания");
                    Console.WriteLine("Введите первое число");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат операции = " + (num1 - num2));
                    goto nachalo;
                }
                else if (Choise == 3)                //Умножение - предельно просто
                {
                    Console.WriteLine("Выбрана операция умножения");
                    Console.WriteLine("Введите первое число");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат операции = " + num1 * num2);
                    goto nachalo;
                }
                else if (Choise == 4)                //Деление - предельно просто
                {
                    Console.WriteLine("Выбрана операция деления");
                    Console.WriteLine("Введите первое число");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат операции = " + num1 / num2);
                    goto nachalo;
                }
                else if (Choise == 5)                //возведение в степень Math.Pow (number, stepan)
                {
                    Console.WriteLine("Выбрана операция возыедения в степень");
                    Console.WriteLine("Введите первое число");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат операции = " + Math.Pow(num1, num2));
                    goto nachalo;
                }
                else if (Choise == 6)                //Квадратный корень все равно что возведение в степень на 0.5
                {
                    Console.WriteLine("Выбрана операция вычисления квадратного корня");
                    double num2;
                    num2 = 0.5;
                    Console.WriteLine("Введите число");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат операции = " + Math.Pow(num1, num2));
                    goto nachalo;
                }
                else if (Choise == 7)                //Процент
                {
                    Console.WriteLine("Выбрана операция нахождения процента от числа");
                    Console.WriteLine("Введите число");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат операции = " + num1 / 100);
                    goto nachalo;
                }
                else if (Choise == 8)                 //Факториал
                {
                    Console.WriteLine("Выбрана операция факториала числа");
                    Console.WriteLine("Введите число");
                    int value = Convert.ToInt32(Console.ReadLine());
                    for (int i = value - 1; i >= 1; i--)
                    {
                        value = value * i;
                    }
                    Console.WriteLine("Результат операции = " + value);
                    goto nachalo;
                }
                else if (Choise == 9)
                {
                    Console.Clear();
                    goto nachalo; //очень надеюсь что вы не говоили про то что goto нельзя использовать)))
                }
            } while (Choise != 10);
        }
    }
}