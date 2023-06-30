// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

 int[] CreateRandomArray(int size, int minValue, int maxValue)
 {
     int[] array = new int[size];
     for (int i = 0; i < size; i++)
     {
         array[i] = new Random().Next(minValue, maxValue + 1);
     }
     return array;
 }
 void PrintArray(int[] array)
 {
     for (int i = 0; i < array.Length; i++)
     {
         System.Console.Write(array[i] + " ");
     }
     System.Console.WriteLine();
 }
 System.Console.WriteLine("Input array size: ");
 int size = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("Input minimal elements of array: ");
 int minValue = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("Input maximal elements of array: ");
 int maxValue = Convert.ToInt32(Console.ReadLine());
 PrintArray(CreateRandomArray(size, minValue, maxValue));
