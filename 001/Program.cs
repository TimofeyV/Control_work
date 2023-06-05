// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


 string[] CreateArray(string message1) // Создание массива + вывод сообщений
{
    Console.Write(message1);
    int number = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[number];
    return arr;
}

void FillArray(string[] arr) // Заполнение массива
{
    int count = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
            Console.Write($"Введите  для элемента {count}: ");
            count++;
            arr[i] = Convert.ToString(Console.ReadLine());
    }
}

 void PrintArray(string[] arr) // Вывод массива в терминал
{
    for (int i = 0; i < arr.Length-1; i++)
    {
            Console.Write(arr[i] + " | ");
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine();
}

string[] SortArray(string[] arr) //Сортировка массива
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3) count += 1;
    }

    string [] new_arr = new string[count];
    int j = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3) 
        {
            new_arr[j] = arr[i];
            j++;
        }
    }
    return new_arr;
}

string[] arr = CreateArray("Введите длину массива: ");
FillArray(arr);
PrintArray(arr);
string [] new_arr = SortArray(arr);
PrintArray(new_arr);