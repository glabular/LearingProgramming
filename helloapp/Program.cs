using System;

namespace helloapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дан произвольный массив с числами. Вывести весь массив.
            // Найти и вывести максимальное и минимальное число в нем.


            //var array1 = new[] { 1, 2, 3, 9, 10 };
            //Console.WriteLine("Дан массив:");
            //for (int i = 0; i <= array1.GetUpperBound(0); i++)
            //{
            //    Console.WriteLine(array1[i]);
            //}

            //Array.Sort(array1);
            //Console.WriteLine("The lowest number in the array is: " + array1[0]);
            //Console.WriteLine("The highest number in the array is: " + array1[^1]);
            //Console.ReadKey();
            //Console.WriteLine();

            //Console.WriteLine("Дан массив:");
            //var array2 = new[] { 10, 2, 3, 1, 9 };
            //foreach (var value in array2)
            //{
            //    Console.WriteLine(value);
            //}

            //int max = 0;
            //for (int i = 0; i <= array2.GetUpperBound(0); i++) 
            //{
            //    if (array2[i] > max)
            //    {                    
            //        max = array2[i];

            //    }

            //}

            //int min = array2[0];
            //for (int i = 0; i <= array2.GetUpperBound(0); i++)
            //{
            //    if (array2[i] < min)
            //    {
            //        min = array2[i];
            //    }

            //}

            //Console.WriteLine("The lowest number in the array is: " + min);
            //Console.WriteLine("The highest number in the array is: " + max);
            //Console.ReadKey();
            //Console.WriteLine();



            //Console.WriteLine("Дан массив:");
            //var array3 = new[] { 12, 8822, 15, 27, 66, 77, 874, 5574, 5, 91 };
            //foreach (var value in array3)
            //{
            //    Console.WriteLine(value);
            //}


            //int max = 0;
            //for (int i = 0; i <= array3.GetUpperBound(0); i++)
            //{
            //    if (array3[i] > max)
            //    {
            //        max = array3[i];
            //    }

            //}

            //int min = array3[0];
            //for (int i = 0; i <= array3.GetUpperBound(0); i++)
            //{
            //    if (array3[i] < min)
            //    {
            //        min = array3[i];
            //    }

            //}

            //Console.WriteLine("The lowest number in the array is: " + min);
            //Console.WriteLine("The highest number in the array is: " + max);
            //Console.ReadKey();
            //Console.WriteLine();


            //Console.WriteLine("Дан массив:");
            //var rnd = new Random();
            //var length = 1000000;
            //var array = new int[length];
            //for (var i = 0; i < length; i++)
            //{
            //    array[i] = rnd.Next(100);
            //}

            //foreach (var value in array)
            //{
            //    //Console.WriteLine(value);
            //}

            //// 1 run
            //var start = DateTime.Now;
            //int max = array[0]; 
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        max = array[i];
            //    }
            //}

            //Console.WriteLine("The highest number in the array is: " + max);
            //Console.WriteLine($"Elapsed O(n) = {(DateTime.Now - start).TotalMilliseconds} ms");

            // n runs
            //start = DateTime.Now;
            //max = array[0];            
            //for (int currentIndex = 0; currentIndex < array.Length; currentIndex++)
            //{
            //    var isMax = true;

            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[currentIndex] < array[i])
            //        {
            //            isMax = false;
            //        }
            //    }

            //    if (isMax)
            //    {
            //        max = array[currentIndex];
            //    }
            //}


            //Console.WriteLine("The highest number in the array is: " + max);
            //Console.WriteLine($"Elapsed O(n*n) = {(DateTime.Now - start).TotalMilliseconds} ms");

            // Sort
            //start = DateTime.Now;
            //Array.Sort(array);
            //Console.WriteLine("The highest number in the array is: " + array[array.Length - 1]);
            //Console.WriteLine($"Elapsed with sorting = {(DateTime.Now - start).TotalMilliseconds} ms");

            //return;

            //int min = array[0];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < min)
            //    {
            //        min = array[i];
            //    }

            //}

            //Console.WriteLine("The lowest number in the array is: " + min);
            //Console.WriteLine("The highest number in the array is: " + max);
            //Console.ReadKey();
            //Console.WriteLine();


            //Console.WriteLine("Дан массив:");
            //var array3 = new[] { 10, 1, 10, 1, 5 };
            //for (int i = 0; i <= array3.GetUpperBound(0); i++)
            //{
            //    Console.WriteLine(array3[i]);
            //}

            //Array.Sort(array3);
            //Console.WriteLine("The lowest number in the array is: " + array3[0]);
            //Console.WriteLine("The highest number in the array is: " + array3[^1]);
            //Console.ReadKey();
            //Console.WriteLine();


            //var rnd = new Random();
            //var array = new int[10];
            //for (var i = 0; i < 10; i++)
            //{
            //    array[i] = rnd.Next(10) + 1;
            //}

            //Console.WriteLine("Дан случайный массив:");
            //foreach (var value in array)
            //{
            //    Console.WriteLine(value);
            //}


            //int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
            //int result = 0; 
            //foreach(int number in numbers)
            //{
            //    if(number > 0)
            //    {
            //        result++;
            //    }
            //}

            //Console.WriteLine($"Число элементов больше нуля: {result}");


            ////Инверсия массива

            //int [] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            //foreach (int i in numbers)
            //{
            //    Console.Write($"{i}     ");
            //}

            //Console.WriteLine();
            //int n = numbers.Length;
            //int k = n / 2;
            //int temp;
            //for(int i = 0; i < k; i++)
            //{
            //    temp = numbers[i];
            //    numbers[i] = numbers[n - i - 1];
            //    numbers[n - i - 1] = temp;
            //}

            //foreach(int i in numbers)
            //{
            //    Console.Write($"{i}     ");
            //}

            int[] nums = { 654, 7, -41, 2, 4, 2, 89, 33, -5, 12, 16, 666, 845, 471, 413 };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} \t");
            }

            Console.WriteLine();

            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;

                        for (int m = 0; m < nums.Length; m++)
                        {
                            Console.Write($"{nums[m]} \t");
                        }

                        Console.WriteLine();
                    }
                }

            Console.WriteLine("Вывод остортированного массива:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} \t");
            }





        }
    }
}