// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задание 2. Массивы и функции");
int lenght = 10;

// Заполняем массив и выводим на экран
static int[] CreateArray(int lenght)
{
    int[] arr = new int[lenght];
    Random rand = new Random();
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = rand.Next(-10, 10);
    }

    return arr;
}

static void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i].ToString() + " ");
    }
}

int[] arr = CreateArray(lenght);
Console.WriteLine("Исходный массив:");
PrintArray(arr);

// Сортируем по возрастанию первую половину массива и вторую половину массива сортируем по убыванию
static int[] SortArray(int[] arr)
{
    int temp;
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5 - i - 1; j++)
        {
            // Сортировка по возрастанию
            if (arr[j] > arr[j + 1])
            {
                // Присвоим рассматриваемое значение отдельной переменной
                temp = arr[j];

                // Присвоим рассматриваемому члену массива значение следующего члена
                arr[j] = arr[j + 1];

                // Присвоим следующему члену значение рассматриваемого члена массива
                arr[j + 1] = temp;
            }

            //Console.WriteLine("Исходный:");
            //PrintArray(arr);
        }
    }

    for (int i = 4; i < 9; i++)
    {
        // Сортировка по убыванию
        for (int j = 4; j < 9; j++)
        {
            if (arr[j] < arr[j + 1])
            {
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }

            //Console.WriteLine("Исходный массив:");
            //PrintArray(arr);
        }
    }

    return arr;
}

int[] sortArr = SortArray(arr);
Console.WriteLine("\nОтсортированный массив:");
PrintArray(sortArr);

//zdvzdcvzcv