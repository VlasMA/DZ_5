// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = new int[10];
int evenNumber = 0;
FillArrayRandomNumbers(array);
PrintArray(array);
EvenNumber(array);

// Метод подсчета колличества четных чисел в массиве
void EvenNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i] % 2 == 0)
        evenNumber ++;
    }
    Console.WriteLine("Количество чётных чисел в массиве - " + evenNumber);
}

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}

// Метод вывода массива в строку
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}