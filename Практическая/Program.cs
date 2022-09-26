Console.Write("Введите номер операции: 1. Сложить 2 числа 2. Вычесть первое из второго 3. Перемножить два числа 4. Разделить первое на второе 5. Возвести в степень N первое число 6. Найти квадратный корень из числа 7. Найти 1 процент от числа 8. Найти факториал из числа 9. Выйти из программы ");
int oper = Convert.ToInt32(Console.ReadLine());
while (oper == 9)
{
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
            int nm1 = Convert.ToInt32(Console.ReadLine());
            int nm2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nm2 - nm1);
            break;
        case 3:
            Console.WriteLine("Напишите два числа");
            int nm1 = Convert.ToInt32(Console.ReadLine());
            int nm2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nm1 * nm2);
            break;
        case 4:
            Console.WriteLine("Напишите два числа");
            int nm1 = Convert.ToInt32(Console.ReadLine());
            int nm2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nm1 / nm2);
            break;
        case 5:
            Console.WriteLine("Напишите два числа");
            int nm1 = Convert.ToInt32(Console.ReadLine());
            int nm2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{nm1}^{nm2} = {(long)Math.Pow(nm1, nm2):N0} (0x{(long)Math.Pow(nm1, nm2):X})");
            break;
        case 6:
            Console.WriteLine("Напишите число");
            Console.ReadLine()
            int nm1 = Convert.ToInt32(Math.Sqrt(5.25));
            Console.WriteLine(nm1);
            break;
        case 7:
            int nm1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nm1 % 1);
            break;
        case 8:
            int nm1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nm1 * nm2);
            break;
        case 9:
            Console.WriteLine("Завершение программы.");
            break;
    }
}