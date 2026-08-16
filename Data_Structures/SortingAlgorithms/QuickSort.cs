namespace Sorting;

class QuickSort
{
    public void quicksort(int[] arr, int left, int right)
    {
        if(left >= right) return;

        int pivot = Partition(arr, left, right);

        quicksort(arr, left, pivot - 1);

        quicksort(arr, pivot + 1, right);
    }

    public int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];

        int i = left - 1;
        for(int j = left; j < right; j++)
        {
            if(arr[j] < pivot)
            {
                i++;

                int temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
        }

        int temp2 = arr[right];
        arr[right] = arr[i + 1];
        arr[i + 1] = temp2;


        return i + 1;
    }

    public void DisplayArray(int[] arr)
    {
        Console.WriteLine("Sorted Using Quick Sort");

        foreach(int num in arr) Console.Write(num + " ");
        Console.WriteLine();
    }
}