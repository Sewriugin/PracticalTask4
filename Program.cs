// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//                                      ПРАКТИЧЕСКОЕ ЗАДАНИЕ 4
// Задача 25: Напишите цикл, который принимает на вход два числа (А и B) и  
// возводит число A в натуральную степень.
//           1) 3, 5 -> 243 (3^5); 2) 2, 4 -> 16

// Задача 25
	Console.WriteLine("Задача 25");
void degree(int a, int b)
{
    int result = 1;
    while (b > 0)
    {
        result = result * a;
        b--;
    }
    Console.WriteLine(result);
}

Console.Write("Input number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number in degree: ");
int numBdegree = Convert.ToInt32(Console.ReadLine());
degree(numA, numBdegree);

// Задача 27: Напишите программу, которая принимает на вход число и  
// выдаёт сумму цифр в числе.
//           1) 452 -> 11; 2) 82 -> 10; 3) 9012 -> 12

// Задача 27
	Console.WriteLine("Задача 27");
    int sum(int numberN)
{
    int result = 0;
    for (int i = 0; numberN != 0; i++)
    {
        result = result + numberN % 10;
        numberN = numberN / 10;
    }
    return result; 
}

System.Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр в числе " + numberN + " = " + sum(numberN));

// Задача 29: Напишите программу, которая задаёт массив   
// из 8 элементов и выводит их на экран.
//           1) 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 2) 6, 1, 33 -> [6, 1, 33]

// Задача 29
Console.WriteLine("Задача 29");
void printArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] array1 = {1, 2, 5, 7, 19};
printArray(array1);
int[] array2 = {6, 1, 33};
printArray(array2);
