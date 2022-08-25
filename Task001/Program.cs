// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateArray(int m)
{
    Console.WriteLine($"Введите {m} целых чисел");
    int[] array = new int[m];
    for(int i = 0; i < m; i++)
    {
        Console.Write($"Введите значение {i+1}-го элемента: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int index = 0; index < array.Length; index++)
    {
        if(index > 0) Console.Write(", ");
        Console.Write(array[index]);
    }
    Console.WriteLine("]");
}

void FindPositiveAmount(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) amount++;
    }
    Console.WriteLine($"Количество положительных элементов в данном массиве равно {amount}.");
}

int[] array = CreateArray(3);
PrintArray(array);
FindPositiveAmount(array);
