int oper;
do
{
    Console.Write("Введите номер операции: 1. Сложить 2 числа 2. Вычесть первое из второго 3. Перемножить два числа 4. Разделить первое на второе 5. Возвести в степень N первое число 6. Найти квадратный корень из числа 7. Найти 1 процент от числа 8. Найти факториал из числа 9. Выйти из программы ");
    oper = Convert.ToInt32(Console.ReadLine());
    switch (oper)
    {     
        case 1:
            Console.WriteLine("Напишите два числа");
            int nm1 = Convert.ToInt32(Console.ReadLine());
            int nm2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nm1 + nm2);
            break;
        case 2:
            Console.WriteLine("Напишите два числа");
            int nm3 = Convert.ToInt32(Console.ReadLine());
            int nm4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nm4 - nm3);
            break;
        case 3:
            Console.WriteLine("Напишите два числа");
            int nm5 = Convert.ToInt32(Console.ReadLine());
            int nm6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nm5 * nm6);
            break;
        case 4:
            Console.WriteLine("Напишите два числа");
            int nm7 = Convert.ToInt32(Console.ReadLine());
            int nm8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nm7 / nm8);
            break;
        case 5:
            Console.WriteLine("Напишите два числа");
            int nm9 = Convert.ToInt32(Console.ReadLine());
            int nm10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{nm9}^{nm10} = {(long)Math.Pow(nm9, nm10):N0} (0x{(long)Math.Pow(nm9, nm10):X})");
            break;
        case 6:
            Console.WriteLine("Напишите число");
            int nm11 = Convert.ToInt32(Math.Sqrt(5.25));
            Console.WriteLine(nm11);
            break;
        case 7:
            int sot = 100;
            Console.WriteLine("Напишите число");
            float nm12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nm12 / sot);
            break;
        case 8:
            Console.WriteLine("Напишите число");
            int result = 1;
            int fact = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= fact; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
            break;
        case 9:
            Console.WriteLine("Завершение программы.");
            break;
    }
} while (oper != 9);