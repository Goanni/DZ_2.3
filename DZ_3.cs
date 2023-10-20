using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2._3
{
    internal class DZ_3
    {
        public static int[] initialization_Array()
        {
            Console.WriteLine("Введите размер масива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[size];

            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                m[i] = rnd.Next(100);
            }
            /*Console.Write("Исходный массив: ");
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write(m[i] + " ");
            }
            Console.WriteLine();*/
            return m;
        }

        public static int[] sum_Array(int[] a, int[]b)
        {
            int[] arr_sum = new int[a.Length];
            if (a.Length != b.Length)
                Console.WriteLine("Нельзя сложить массивы разной длины");
            else
            {
                for(int i = 0; i < a.Length; i++)
                {
                    arr_sum[i] = a[i] + b[i];   
                }
            }
            return arr_sum;
        }

        public static int[] multiplication_Arr(int[] a)
        {
            Console.WriteLine("Введите число, на которое умножим массив.");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] arr_mult = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                arr_mult[i] = a[i] * number;
            }
            return arr_mult;
        }

        public static int[] search(int[] a, int[] b)
        {
            int index = 0;
            int[] result = new int[0] ; 
            for (int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < b.Length; j++)
                {
                    if(a[i] == b[j])
                    {
                        for (int x = 0; x < result.Length; x++)
                        {
                            if (result[x] == a[i])
                            {
                                break;
                            }
                        }
                        Array.Resize(ref result, result.Length + 1);
                        result[index] = a[i];
                        index++;
                        break;
                    }

                }
            }
            return result;

        }

        public static void write_Arr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        public static void sort_Arr(int[] a)
        {
            for (int i = 1; i < a.Length; ++i)
            {
                for (int r = 0; r < a.Length - i; r++)
                {
                    if (a[r] < a[r + 1])
                    {
                        // Обмен местами
                        int temp = a[r];
                        a[r] = a[r + 1];
                        a[r + 1] = temp;
                    }
                }
            }
        }
        
        public static int max_Arr(int[] a)
        {
            int max_number = a[0];
            for(int i=0; i < a.Length; i++)
            {
                if(a[i] > max_number)
                {
                    max_number = a[i];
                }
            }
            return max_number;
        }

        public static int min_Arr(int[] a)
        {
            int min_number = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min_number)
                {
                    min_number = a[i];
                }
            }
            return min_number;
        }

        public static int average_Arr(int[] a)
        {
            int sum_namber = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum_namber = sum_namber + a[i];
            }
            int average = sum_namber / a.Length;
            return average;
        }
        static void Main()
        {
            //ПЕРВАЯ ФУНКЦИЯ
            /* int[] m1 = initialization_Array();
             write_Arr(m1);

             int[] m2 = initialization_Array();
             write_Arr(m2);*/

            //ВТОРАЯ ФУНКЦИЯ
            /* int[] m3 = sum_Array(m1, m2);
             write_Arr(m3);*/

            //ТРЕТЬЯ ФУНКЦИЯ
            /* int[] m4 = multiplication_Arr(m1);
             write_Arr(m4);*/

            //ЧЕТВЁРТАЯ ФУНКЦИЯ
            int[] a = { 25, 55, 2, 13, 48 };
            int[] b = { 63, 55, 13, 55};
            int[] result = search(a, b);
            write_Arr(result);

            //ШЕСТАЯ ФУНКЦИЯ
            int[] c = { 25, 55, 2, 13, 48 };
            sort_Arr(c);
            write_Arr(c);
            int max_ = max_Arr(c);
            int min_ = min_Arr(c);
            int average_ = average_Arr(c);
            Console.WriteLine("Максимальное = " + max_ + "\nМинимальное = " + min_ + "\nСреднее = " + average_);

        }
    }
}
