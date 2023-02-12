

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
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
