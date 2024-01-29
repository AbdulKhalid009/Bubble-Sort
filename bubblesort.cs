int[] array = {1, 4, 5, 9, 0, 2, 3, 7, 6, 8};


bubbleSort(array);

printArray(array);




static void bubbleSort(int[] arr)
{
    int n = arr.Length;


    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++) 
        {
            if (arr[j] > arr[j+ 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
                  

            }
        }
    }
}


static void printArray(int[] arr)
{
    foreach (int number in arr)
    {
        Console.WriteLine(number + "");
    }
}