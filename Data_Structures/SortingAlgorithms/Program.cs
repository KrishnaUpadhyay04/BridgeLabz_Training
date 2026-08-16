namespace Sorting;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("You can execute any of the following programs");
        Console.WriteLine("1. Sort Student Marks(Bubble Sort).");
        Console.WriteLine("2. Sort Employee Ids(Insertion Sort).");
        Console.WriteLine("3. Sort an array of Book Prices(Merge Sort).");
        Console.WriteLine("4. Sort Product Prices(Quick Sort).");
        Console.WriteLine("5. Sort Exam Scores(Selection Sort).");
        Console.WriteLine("6. Sort Job Applicants by Salary(Heap Sort).");
        Console.WriteLine("7. Sort Student Ages(Counting Sort).");
        Console.WriteLine("0. Exit Program");
        
        
        while (true)
        {
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                Console.Write("Enter the number of students: ");
                int number = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[number];
                Console.WriteLine("Enter the marks of students: ");
                for(int i = 0; i < number; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                BubbleSort bubble = new();

                bubble.bubblesort(arr);

                bubble.DisplayArray(arr);
            }

            else if(choice == 2)
            {
                Console.Write("Enter the number of employees: ");
                int number = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[number];
                Console.WriteLine("Enter the Ids of employees: ");
                for(int i = 0; i < number; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                InsertionSort insertion = new();

                insertion.insertionsort(arr);

                insertion.DisplayArray(arr);
            }

            else if(choice == 3)
            {
                Console.Write("Enter the number of books: ");
                int number = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[number];
                Console.WriteLine("Enter the prices of books: ");
                for(int i = 0; i < number; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }


                MergeSort merge = new();

                merge.mergesort(arr, 0, number - 1);

                merge.DisplayArray(arr);
            }

            else if(choice == 4)
            {
                Console.Write("Enter the number of products: ");
                int number = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[number];
                Console.WriteLine("Enter the prices of products: ");
                for(int i = 0; i < number; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }


                QuickSort quick = new();

                quick.quicksort(arr, 0, number - 1);

                quick.DisplayArray(arr);
            }

            else if(choice == 5)
            {
                Console.Write("Enter the number of students: ");
                int number = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[number];
                Console.WriteLine("Enter the marks of students: ");
                for(int i = 0; i < number; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                SelectionSort selection = new();

                selection.selectionsort(arr);

                selection.DisplayArray(arr);
            }

            else if(choice == 6)
            {
                Console.Write("Enter the number of Applicants: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the expected salaries of each applicant: ");
                int[] arr = new int[number];
                for(int i = 0; i < number; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                HeapSort heap = new();

                heap.heapsort(arr);

                heap.DisplayArray(arr);
            }

            else if(choice == 7)
            {
                Console.Write("Enter the number of students: ");
                int number = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[number];

                Console.WriteLine("Enter the ages of students: ");
                for(int i = 0; i < number; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                CountingSort counting = new();

                counting.countingsort(arr);

                counting.DisplayArray(arr);
            }

            else if(choice == 0)
            {
                Console.WriteLine("Exiting...");
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Invalid Choice! Try again");
            }
        }
    }
}