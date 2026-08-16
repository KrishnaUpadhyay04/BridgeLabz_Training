namespace Sorting;

class InsertionSort
{
    public void insertionsort(int[] arr)
    {
        int n = arr.Length;

        for(int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while(j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }

    public void DisplayArray(int[] arr)
    {
        Console.WriteLine("Sorted Using Insertion Sort");

        foreach(int num in arr) Console.Write(num + " ");
        Console.WriteLine();
    }
}