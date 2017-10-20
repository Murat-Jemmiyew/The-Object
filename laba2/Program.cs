using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определение и инициализация примитивных типов 

            int number = -10;
            uint number2 = 10;
            long number3 = 20;
            ulong number4 = 400000000;
            short number5 = 32767;
            ushort number6 = 65535;
            char s = 'W';
            byte number7 = 255;
            sbyte number8 = -1;
            bool value = true;
            float number9 = 123.12F;
            double number10 = 2134.23132;
            decimal number11 = 1.233222M;

            number2 = number6;
            number = (int)number10;
            number7 = (byte)number8;


            int x = 5;
            Object obj = x;//упоковка x 
            long n = (long)(int)x;



            string str1 = "Hello world ";
            string str2 = "Hello everybody ";
            string str3 = "Just the third line ";
            if (str1 == str2)
            {
                Console.WriteLine("Строки равны");
            }
            else
            {
                Console.WriteLine("Строки не равны");
            }

            string str4 = string.Concat(str1, str2, str3);
            Console.WriteLine("Результат сцепления 3 строк:{0}", str4);

            str3 = string.Copy(str2);
            Console.WriteLine("Копирование строк:{0}", str3);

            str1 = str1.Substring(6);
            Console.WriteLine(str1);

            string[] str5 = null;
            str5 = str4.Split();
            foreach (string word in str5)
            {
                Console.WriteLine(word);
            }

            str1 = str1.Insert(2, " Вставка подстроки! ");
            Console.WriteLine(str1);

            //Работа с массивами 

            int[,] myarray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + myarray[i, j]);
                }
                Console.WriteLine();
            }
            string[] info = new string[3] { "Фамилия", "Имя", "Отчество" };

            Console.WriteLine("Содержимое массива строк:");
            foreach (string element in info)
            {
                Console.Write(" " + element);
            }

            Console.WriteLine("\n Длинна массива  " + info.Length);
            Console.WriteLine("Введите позицию для изменения содержимого массива");
            int index = int.Parse(Console.ReadLine());
            if (index <= 3 && index >= 0)
            {
                Console.WriteLine("Внисите изменения:");
                info[index] = Console.ReadLine();
                Console.WriteLine("Результат выполнения");
                foreach (string element in info)
                {
                    Console.Write(" " + element);
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не правильный индекс");
            }

            //Ступенчатый массив 
            double[][] arrayNumbers = { new double[2], new double[3], new double[4] };
            Console.WriteLine("\n Заполните ступенчатый массив:");
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                for (int j = 0; j < arrayNumbers[i].Length; j++)
                {
                    arrayNumbers[i][j] = double.Parse(Console.ReadLine());
                }
            }
            foreach (double[] b in arrayNumbers)
            {
                foreach (double a in b)
                {
                    Console.Write("  " + a);
                }
                Console.WriteLine();
            }

            //Неявно типизированная переменная для хранения массива 
            var array1 = new[] { 1, 2, 5.5 };
            Console.WriteLine("Тип массива   " + array1.GetType());
            //Неявно типизированнная переменнная для хранения строки 
            var my_str = "My string";

            Console.WriteLine(my_str);

            //Создание кортежа 
            (int age, string name, string surname, int group) student = (18, "Иван", "Иванов", 2);
            Console.WriteLine("Вывод содержимого первого кортежа:");
            Console.WriteLine(student.age);
            Console.WriteLine(student.name);
            Console.WriteLine(student.surname);
            Console.WriteLine(student.group);
            (int age, string name, string surname, int group) student_2 = (18, "Андрей", "Иванов", 2);
            if (student.Equals(student_2))
            {
                Console.WriteLine("Кортежи равны");
            }
            else
            {
                Console.WriteLine("Кортежи не равны");
            }

            int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8 };
            string my_string = "My string!!!";
            //Создана локальная функция возвращающая кортеж 
            (int, int, int, char) local_function(int[] m, string str)
            {
                int max = m.Max();
                int min = m.Min();
                int sum_mas = m.Sum();
                char first_letter = str[0];
                return (max, min, sum_mas, first_letter);
            }
            (int max_elem, int min_elem, int sum_elements, char firstLetter) my_cortage_3 = local_function(mas, my_string);
            Console.WriteLine("Получившийся кортеж: " + my_cortage_3);
            Console.WriteLine(my_cortage_3.min_elem);
        }
    }
}
