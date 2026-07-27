using System;

class Question9
{
    public static void Solution()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[,] marks = new double[n, 3];
        double[] percentage = new double[n];
        string[] grade = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nStudent {i + 1}");

            Console.Write("Physics: ");
            marks[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Chemistry: ");
            marks[i, 1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Maths: ");
            marks[i, 2] = Convert.ToDouble(Console.ReadLine());

            if (marks[i,0] < 0 || marks[i,1] < 0 || marks[i,2] < 0)
            {
                Console.WriteLine("Invalid Marks! Enter Again.");
                i--;
                continue;
            }
        }

        for (int i = 0; i < n; i++)
        {
            percentage[i] = (marks[i,0] + marks[i,1] + marks[i,2]) / 3;

            if (percentage[i] >= 90)
                grade[i] = "A+";
            else if (percentage[i] >= 80)
                grade[i] = "A";
            else if (percentage[i] >= 70)
                grade[i] = "B";
            else if (percentage[i] >= 60)
                grade[i] = "C";
            else if (percentage[i] >= 50)
                grade[i] = "D";
            else
                grade[i] = "F";
        }

        Console.WriteLine("\nPhy\tChem\tMath\t%\tGrade");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{marks[i,0]}\t{marks[i,1]}\t{marks[i,2]}\t{percentage[i]:F2}\t{grade[i]}");
        }
    }
}