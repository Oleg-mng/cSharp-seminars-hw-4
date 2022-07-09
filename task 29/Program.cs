//Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

// Вар 1
//Console.WriteLine("Введите массив состоящий из 8-ти элементов");
//int Mas=Convert.ToInt32(Console.ReadLine());

int[] Ar = { 1, 4, 8, 9, 11, 82, 3, 3, 9 };
void PrintarrayM(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//PrintarrayM (Ar);

//Вар 2
int[] array = new int[8];
void FillarrayM(int[] A)
{
    Console.WriteLine("Введите массив состоящий из 8-ти элементов:");

    for (int i = 0; i < 8; i++)
    {
        A[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] A)
{
    foreach (var item in A)
    {
        Console.Write($"{item} ");
    }
}
FillarrayM(array);
PrintArray(array);