Console.WriteLine("1)Сложение   6)Найти квадратный корень числа");
Console.WriteLine("2)Вычитание  7)Найти 1 процент от числа");
Console.WriteLine("3)Умножение  8)Найти факториал числа");
Console.WriteLine("4)Деление    9)Выйти из программы");
Console.WriteLine("5)Возведение в степень");
M:
Console.WriteLine("Выберите действие: ");
int func = Convert.ToInt32(Console.Read());
int x, y, z, fact = 1, b;
double d;
float f, g;
while (func != 9)
    if (func >= 10)
        {
            Console.WriteLine("Вы выбрали неправильное действие. Попробуйте снова.");
            goto M;
        }
    else
    {
        switch (func) {
            case 1:
                Console.Write("Введите первое число: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                y = Convert.ToInt32(Console.ReadLine());
                z = x + y;
                Console.Write("Результат: ");
                Console.WriteLine(z);
                goto M;
            case 2:
                Console.Write("Введите первое число:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число:");
                y = Convert.ToInt32(Console.ReadLine());
                z = x - y;
                Console.Write("Результат: ");
                Console.WriteLine(z);
                goto M;
            case 3:
                Console.Write("Введите первое число:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число:");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Результат: ");
                Console.WriteLine(z = x * y);
                goto M;
            case 4:
                Console.Write("Введите первое число:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число:");
                y = Convert.ToInt32(Console.ReadLine());
                if (y == 0) Console.WriteLine("Делить на ноль нельзя");
                else Console.Write("Результат: ");
                Console.WriteLine(z = x / y);
                goto M;
            case 5:
                Console.Write("Введите число:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите степень:");
                y = Convert.ToInt32(Console.ReadLine());
                d = Math.Pow(x, y);
                Console.Write("Результат: ");
                Console.WriteLine(d);
                goto M;
            case 6:
                Console.Write("Введите число:");
                x = Convert.ToInt32(Console.ReadLine());
                d = Math.Sqrt(x);
                Console.Write("Результат: ");
                Console.WriteLine(d);
                goto M;
            case 7:
                Console.Write("Введите число:");
                g = Convert.ToInt32(Console.ReadLine());
                f = g / 100;
                Console.Write("Результат: ");
                Console.WriteLine(f);
                goto M;
            case 8:
                Console.Write("Введите число:");
                b = Convert.ToInt32(Console.ReadLine());
                for (x = 1; x <= b; x++)
                {
                    fact = fact * x;
                }
                Console.Write("Результат: ");
                Console.WriteLine(fact);
                goto M;
        }
    }