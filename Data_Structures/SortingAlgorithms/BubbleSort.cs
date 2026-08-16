namespace Sorting;

class BubbleSort
{
    public void bubblesort(int[] arr)
    {
        int n = arr.Length;

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n - i - 1; j++)
            {
                if(arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public void DisplayArray(int[] arr)
    {
        Console.WriteLine("Sorted Using Bubble Sort");

        foreach(int num in arr) Console.Write(num + " ");
        Console.WriteLine();
    }
}