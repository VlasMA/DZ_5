// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях;
int[] array = new int[5];
FillArrayRandomNumbers(array);
PrintArray(array);
int sumNotEvenElements = 0;

for (int i = 0; i < array.Length; i+=2 )
    {
        sumNotEvenElements += array[i];
    }
    Console.WriteLine("Сумма элементов, стоящих на нечетных позициях - " + sumNotEvenElements);

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 77);
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