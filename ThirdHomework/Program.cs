using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Tasks();
                Console.Write("\n\nВыберите задание: ");
                int choice = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (choice)
                {
                    case 1: Task1(); break;
                    case 2: Task2(); break;
                    case 3: Task3(); break;
                    case 4: Task4(); break;
                    case 5: Task5(); break;
                    default:
                        Console.WriteLine("Ошибочный выбор!!!"); break;
                }
                Console.Write("\nНажмите ENTER чтобы продолжить...");
                Console.ReadKey();
                Console.Clear();
            }
        }
//******************************************************************************************
        static void Task1()
        {
            Console.WriteLine("Введите любой текст ('.' to END):");
            char dot = '.', symbol;
            int counter = 0;

            while(dot != (symbol = Convert.ToChar(Console.Read())))
            {
                if (symbol == ' ') counter++;
            }

            Console.WriteLine("Количество пробелов - " + counter);
            Console.ReadLine();
        }
//******************************************************************************************
        static void Task2()
        {
            Console.Write("Введите 6-значное число: ");
            int temp;
            int number = temp = int.Parse(Console.ReadLine());
            int size = 0, sum = 0, sum2 = 0;

            while (temp > 0) {
                size++;
                temp /= 10;
            }

            if (size == 6)
            {
                for (int i = 0; i < size; i++)
                {
                    if(i < size / 2)
                    {
                        sum += number % 10;
                    }
                    else
                    {
                        sum2 += number % 10;
                    }
                    number /= 10;
                }
                Console.WriteLine(sum==sum2 ? "Число счастливое!" : "Число не счастливое!");
            }
            else
            {
                Console.WriteLine("Вы ввели неправильное число");
            }
        }
//******************************************************************************************
        static void Task3()
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();

            Console.WriteLine("\nСтрока после конвертации:");
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i] <= 90) Console.Write(char.ToLower(str[i]));
                else if (str[i] >= 97 && str[i] <= 122) Console.Write(char.ToUpper(str[i]));
                else Console.Write(str[i]);
            }
        }
//******************************************************************************************
        static void Task4()
        {
            Random rnd = new Random();

            int beginOfRange = rnd.Next(3, 5);
            Console.WriteLine("Начало диапазона: " + beginOfRange);

            int endOfRange = rnd.Next(5, 8);
            Console.WriteLine("Конец диапазона: " + endOfRange);

            for (int i = beginOfRange; i < endOfRange + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }
        }
//******************************************************************************************
        static void Task5()
        {
            Console.Write("Введите целое число больше нуля: ");
            int number = int.Parse(Console.ReadLine());
            int[] numbArray = new int[1];

            for (int i = 0; number > 0; i++)
            {
                if (numbArray.Length == i) Array.Resize(ref numbArray, i + 1);
                numbArray[i] = number % 10;
                number /= 10;
            }
            number = 0;
            for (int i = 0; i < numbArray.Length; i++)
            {
                number += numbArray[i] * (int)Math.Pow(10, numbArray.Length - i - 1);
            }

            Console.WriteLine("\nОбратное число: " + number);

            /* Альтернативный вариант
            numbArray.Reverse(); 
            for (int i = 0; i < numbArray.Length; i++)
            {
                Console.Write(numbArray[i]);
            }*/
        }
//******************************************************************************************
        static void Tasks()
        {
            Console.WriteLine("1. Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. " +
"\n   Программа должна сосчитать количество введенных пользователем пробелов." +
"\n2. Ввести с клавиатуры номер трамвайного билета(6 - значное число) и проверить является ли данный билет счастливым" +
"\n   (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, " +
"\n   то этот билет считается счастливым)." +
"\n3. Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра " +
"\n   на величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все " +
"\n   символы нижнего регистра в символы верхнего регистра и наоборот."+
"\n4. Даны целые положительные числа A и B(A < B). Вывести все целые числа от A до B включительно; каждое число должно " +
"\n   выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное его значению. " +
"\n   Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:"+
		"\n\t3 3 3"+
        "\n\t4 4 4 4"+
        "\n\t5 5 5 5 5"+
        "\n\t6 6 6 6 6 6"+
        "\n\t7 7 7 7 7 7 7"+"" +
"\n5. Дано целое число N(> 0), найти число, полученное при прочтении числа N справа налево. Например, если было введено " +
"\n   число 345, то программа должна вывести число 543.");
        }
    }
}
