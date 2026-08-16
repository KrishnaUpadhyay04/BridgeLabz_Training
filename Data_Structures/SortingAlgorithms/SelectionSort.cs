namespace Sorting;

class SelectionSort
{
    public void selectionsort(int[] arr)
    {
        int n = arr.Length;

        for(int i = 0; i < n; i++)
        {
            int MinIndex = i;

            for(int j = i + 1; j < n; j++)
            {
                if(arr[j] < arr[MinIndex]) MinIndex = j;
            }

            int temp = arr[i];
            arr[i] = arr[MinIndex];
            arr[MinIndex] = temp;

        }
    }

    public void DisplayArray(int[] arr)
    {
        Console.WriteLine("Sorted Using Selection Sort");

        foreach(int num in arr) Console.Write(num + " ");
        Console.WriteLine();
    }
}