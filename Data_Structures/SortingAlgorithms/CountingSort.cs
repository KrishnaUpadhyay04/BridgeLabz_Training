namespace Sorting;

class CountingSort
{
    public void countingsort(int[] arr)
    {
        int[] freq = new int[arr.Max() + 1];

        foreach(int num in arr) freq[num]++;

        int index = 0;

        for(int value = 0; value < freq.Length; value++)
        {
            while(freq[value] > 0)
            {
                arr[index++] = value;
                freq[value]--;
            }
        }
    }


    public void DisplayArray(int[] arr)
    {
        Console.WriteLine("Sorted Using Counting Sort");

        foreach(int num in arr) Console.Write(num + " ");
        Console.WriteLine();
    }
}