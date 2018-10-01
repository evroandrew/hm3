using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    class Mass
    {
        private static Random rng;
        private enum MyWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
        public int fact(int N)
        {
            if (N == 0)
                return 1;
            else
                return N * fact(N - 1);
        }
        public void arr_rng(int[] arr)
        {
            rng = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rng.Next(0, 100);
        }
        public void what_day()
        {
            int day = GetInt("Введите день месяца =>");
            int month = GetInt("Введите месяц (1-январь) =>");
            int year = GetInt("Введите год =>");
            //Преобразуем дату в юлианский календарь
            if (month == 1 || month == 2)
            {
                --year;
            }
            month -= 2;
            if (month < 0)
            {
                month += 12;
            }
            int c = year / 100;
            year %= 100;
            int dayOfWeek = (day + (13 * month - 1) / 5 + year + year / 4 + c / 4 - 2 * c + 777) % 7;
            Console.WriteLine((MyWeek)(dayOfWeek));
        }
        public void arr_f(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i;
        }
        public void Shuffle(int[] arr)
        {
            rng = new Random();
            int n = arr.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = arr[k];
                arr[k] = arr[n];
                arr[n] = value;
            }
        }
        public void show_mass(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr["+i+"]="+arr[i]);
            }
        }
        public int check1()
        {
            for (; ; )
            {
                Console.Write(" : __\b\b");
                string str = Console.ReadLine();
                int a1 = 0;
                if ((!Int32.TryParse(str, out a1)) | (a1 < 0))
                {
                    Console.WriteLine("Try again...");
                }
                else
                    return a1;
            }
        }
        public double agc(int a, int i, int d, int k)
        {
            double ags = Math.Sin(2 * Math.PI * (d + i) / a) * (k);
            return ags;
        }
        public DateTime Get_date(string abc)
        {
            int day, month, year;
            Mass m_a = new Mass();
            Console.Write("Enter day " + abc);
            day = m_a.check1();
            Console.Write("Enter month " + abc);
            month = m_a.check1();
            Console.Write("Enter year " + abc);
            year = m_a.check1();
            DateTime d1 = new DateTime(year, month, day);
            return d1;
        }
        public double check_num(double num)
        {
            double num1 = Math.Round(num, 0);
            if (num1 < num)
                num1++;
            return num1;
        }
        public void randomShuffle()
        {
            int[] arr = new int[52];
            arr_f(arr);
            Shuffle(arr);
            show_mass(arr);
        }
        public int GetInt(string quastion)
        {
            int res;
            do
            {
                Console.Write(quastion);
            } while (!Int32.TryParse(Console.ReadLine(), out res));
            return res;
        }
        public uint GetUint(string quastion)
        {
            uint res;
            do
            {
                Console.Write(quastion);
            } while (!UInt32.TryParse(Console.ReadLine(), out res));
            return res;
        }
        public void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
    class Program
    {
        static int check2()
        {
            for (; ; )
            {
                Console.Write(" : __\b\b");
                string str = Console.ReadLine();
                int a1 = 0;
                if (!Int32.TryParse(str, out a1))
                {
                    Console.WriteLine("Try again...");
                }
                else
                    return a1;
            }
        }
        static void show_s()
        {
            Mass m_a = new Mass();
            Console.WriteLine("Функция для вывода заданной линии на консоль");
            Console.Write("Количество символов в линии");
            int num = m_a.check1();
            Console.Write("Cимвол линии : ");
            char let = Console.ReadLine()[0];
            Console.Write("Вертикальная или горизонтальная линия?(0/1) ");
            int type_l = m_a.check1();
            for (int i = 0; i < num; i++)
            {
                Console.Write(let);
                if (type_l == 0)
                    Console.Write("\n");
            }
        }
        static void sum()
        {
            Mass m_a = new Mass();
            Console.WriteLine("Функция для нахождения суммы всех целых нечетных чисел в диапазоне");
            Console.Write("Введите диапазон:\na");
            int num1 = m_a.check1();
            Console.Write("b");
            int num2 = check2();
            int sum = 0;
            for (int i = num1; i <= num2; i++)
                if (i % 2 == 1)
                    sum += i;
            Console.WriteLine("Сумма:\t" + sum);
        }
        static void factorial()
        {
            Mass m_a = new Mass();
            Console.WriteLine("Функция для вычисления факториала неотрицательных целых чисел n");
            Console.WriteLine("Введите n ");
            int n = m_a.check1();
            Console.WriteLine("Факториал от " + n + " равен " + m_a.fact(n));
        }
        static void length_num()
        {
            Mass m_a = new Mass();
            Console.WriteLine("Функция для вычесления длины числа n");
            Console.Write("Введите число n");
            int n = m_a.check1();
            Console.WriteLine("Длина числа:\t" + (n.ToString()).Length);
        }
        static void back_num()
        {
            Mass m_a = new Mass();
            Console.WriteLine("Функция для получения обратного числа");
            Console.Write("Введите число n");
            int n = m_a.check1();
            Console.Write("Обратное число: ");
            string arr = n.ToString();
            for (int i = arr.Length - 1; i > -1; i--)
                Console.Write(arr[i]);
        }
        static void sum_num()
        {
            Mass m_a = new Mass();
            Console.WriteLine("Функция для получения суммы цифр числа");
            Console.Write("Введите число n");
            int n = m_a.check1();
            Console.Write("Сумма цифр: ");
            string arr = n.ToString();
            int sum = 0;
            for (int i = arr.Length - 1; i > -1; i--)
            {
                sum += Convert.ToInt32(arr[i]) - 48;
            }
            Console.Write(sum);
        }
        static void simple_num()
        {
            Console.WriteLine("Функция для поиска простых чисел");
            int start = 2;
            int end = 1000;
            Console.WriteLine("Список простых чисел в диапазоне " + start + "..." + end);
            for (int i = start; i <= end; i++)
            {
                bool stat = true;
                for (int j = 2; j <= Math.Pow(i, 0.5); j++)
                {
                    if (i % j == 0)
                        stat = false;
                }
                if (i != 2)
                    if (stat)
                        Console.WriteLine(i);
            }
        }
        static void show_f()
        {
            Mass m_a = new Mass();
            Console.WriteLine("Функция для вывода фигуры");
            Console.WriteLine("Введите ширину и высоту фигуры");
            int a = m_a.check1();
            int b = m_a.check1();
            leth_show(a);
            Console.WriteLine();
            for (int i = 1; i < b - 1; i++)
            {
                Console.Write("*");
                for (int j = 1; j < a - 1; j++)
                    Console.Write(" ");
                Console.WriteLine("*");
            }
            leth_show(a);
            Console.WriteLine();
        }
        static void leth_show(int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write("*");
            }
        }
        static void show_calendar()
        {
            Console.WriteLine("Функция для вывода календаря на месяц");
            Console.WriteLine("Пн\tВт\tСр\tЧт\tПт\tСб\tВс");
            int j = 0;
            for (int i = -5; i < 30; i++)
            {
                if (i < 0)
                    Console.Write("\t");
                else
                    Console.Write(i + 1 + "\t");
                if (++j > 6)
                {
                    Console.WriteLine();
                    j = 0;
                }
            }
        }
        static void show_rev_mass()
        {
            Console.WriteLine("Функция показывающая массив наоборот");
            int[] a = new int[4];
            Mass m_a = new Mass();
            m_a.arr_rng(a);
            m_a.show_mass(a);
            for (int i = 0; i < a.Length / 2; i++)
            {
                m_a.swap(ref a[i], ref a[a.Length - 1 - i]);
            }
            Console.WriteLine();
            m_a.show_mass(a);
        }
        static void sum_mass()
        {
            Console.WriteLine("Функция нахождения сумм четных и нечетных элементов массива");
            int[] a = new int[50];
            Mass m_a = new Mass();
            int sumn = 0, sumo = 0;
            m_a.arr_rng(a);
            m_a.show_mass(a);
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                    sumo += a[i];
                else
                    sumn += a[i];
            }
            Console.WriteLine("Сумма четных элементов массива: " + sumo);
            Console.WriteLine("Сумма нечетных элементов массива: " + sumn);
        }
        static void count_elems()
        {
            int[] arr = new int[20];
            Mass m_a = new Mass();
            m_a.arr_rng(arr);
            int[,] arr1 = new int[20, 2];
            for (int i = 0; i < 20; i++)
            {
                arr1[i, 0] = -1;
                arr1[i, 1] = 0;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int key = 0;
                int j = 0;
                while (arr1[j, 0] != -1)
                {
                    if (arr1[j, 0] == arr[i])
                    {
                        key++;
                        arr1[j, 1] += 1;
                        break;
                    }
                    j++;
                }
                if (key == 0)
                {
                    arr1[j, 0] = arr[i];
                    arr1[j, 1] += 1;
                }
            }
            Console.WriteLine("Функция вывода повторяющихся элементов в массиве");
            Console.WriteLine("Повторяющиеся элементы в массиве:");
            m_a.show_mass(arr);
            for (int i = 0; i < 20; i++)
            {
                if (arr1[i, 1] > 1)
                {
                    Console.WriteLine(arr1[i, 0]);
                }
            }
        }
        static void find_min()
        {
            int[] arr = new int[20];
            Mass m_a = new Mass();
            m_a.arr_rng(arr);
            m_a.show_mass(arr);
            int min = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((min == -1) & (arr[i] % 2 == 1))
                    min = arr[i];
                if ((arr[i] < min) & (arr[i] % 2 == 1))
                    min = arr[i];
            }
            Console.WriteLine("min el = "+min);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to count factorial");
            Console.WriteLine("Enter 2 to use reverse mass");
            Console.WriteLine("Enter 3 to find min el mass");
            Console.WriteLine("Enter 4 to find repetitive el");
            Console.WriteLine("Enter 5 to find sum el's");
            Console.WriteLine("Enter 6 to show callendar");
            Console.WriteLine("Enter 7 to print figure");
            Console.WriteLine("Enter 8 to print prime numbers");
            Console.WriteLine("Enter 9 to get sum of num's");
            Console.WriteLine("Enter 10 to get back num");
            Mass m_a = new Mass();
            int key = m_a.check1();
            if (key == 1)
                factorial();
            if (key == 2)
                show_rev_mass();
            if (key == 3)
                find_min();
            if (key == 4)
                count_elems();
            if (key == 5)
                sum_mass();
            if (key == 6)
                show_calendar();
            if (key == 7)
                show_f();
            if (key == 8)
                simple_num();
            if (key == 9)
                sum_num();
            if (key == 10)
                back_num();
            Console.ReadKey();
        }
    }
}