using System;

class Question8
{
    public static void Solution()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] physics = new double[n];
        double[] chemistry = new double[n];
        double[] maths = new double[n];
        double[] percentage = new double[n];
        string[] grade = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nStudent {i + 1}");

            Console.Write("Physics: ");
            physics[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Chemistry: ");
            chemistry[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Maths: ");
            maths[i] = Convert.ToDouble(Console.ReadLine());

            if (physics[i] < 0 || chemistry[i] < 0 || maths[i] < 0)
            {
                Console.WriteLine("Invalid Marks! Enter Again.");
                i--;
                continue;
            }
        }

        for (int i = 0; i < n; i++)
        {
            percentage[i] = (physics[i] + chemistry[i] + maths[i]) / 3;

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
            Console.WriteLine($"{physics[i]}\t{chemistry[i]}\t{maths[i]}\t{percentage[i]:F2}\t{grade[i]}");
        }
    }
}