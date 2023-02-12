

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

double[] CreateArrayDouble(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        array[i] += new Random().NextDouble();
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.Write("\n");
}

void PrintArrayDouble(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 2) + " ");
    Console.Write("\n");
}
/* 
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int NumberOfEvenElements(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            result++;
    return result;
}
Console.Write("Enter the array size: ");
int arraySize34 = Convert.ToInt32(Console.ReadLine()); //34 - это номер задачи, если что
int[] myArray34 = CreateArray(arraySize34, 100, 999);
PrintArray(myArray34);
int num34 = NumberOfEvenElements(myArray34);
Console.WriteLine("Number of even elements in array: " + num34);

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int SumOfElementsOnOddPositions(int[] array)
{
    int result = 0;
    if(array.Length > 1)
        for(int i = 1; i < array.Length; i += 2)
            result += array[i];
    return result;
}

Console.Write("Enter the array size: ");
int arraySize36 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum possible value: ");
int arrayMin36 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum possible value: ");
int arrayMax36 = Convert.ToInt32(Console.ReadLine());
int[] myArray36 = CreateArray(arraySize36, arrayMin36, arrayMax36);
PrintArray(myArray36);
int sum36 = SumOfElementsOnOddPositions(myArray36);
Console.WriteLine("Number of elements on odd positions in array: " + sum36);

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
double findMax(double[] array)
{
    double result = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i] > result)
            result = array[i];
    return result;
}

double findMin(double[] array)
{
    double result = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i] < result)
            result = array[i];
    return result;
}

double getMinMaxDiff(double min, double max)
{
    return max - min;
}


Console.Write("Enter the array size: ");
int arraySize38 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum possible value: ");
int arrayMin38 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum possible value: ");
int arrayMax38 = Convert.ToInt32(Console.ReadLine());
double[] myArray38 = CreateArrayDouble(arraySize38, arrayMin38, arrayMax38);
PrintArrayDouble(myArray38);
double min38 = findMin(myArray38);
double max38 = findMax(myArray38);
double minMaxDif38 = getMinMaxDiff(min38, max38);
Console.WriteLine($"The difference of minimal [{Math.Round(min38, 2)}] and maximal [{Math.Round(max38, 2)}] is: {Math.Round(minMaxDif38, 2)}");
