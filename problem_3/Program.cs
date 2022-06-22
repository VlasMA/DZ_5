// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива;
// [3 7 22 2 78] -> 76;
int[] array = new int[10];
FillArrayRandomNumbers(array);
PrintArray(array);
 
// Сортировка массива
int temp;
for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
PrintArray(array);

int diffMaxMin;
diffMaxMin = array[array.Length - 1] - array[0];
Console.WriteLine("Разница между макс и мин элементом массива : " + diffMaxMin); 
 

// Метод вывода массива в строку
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}