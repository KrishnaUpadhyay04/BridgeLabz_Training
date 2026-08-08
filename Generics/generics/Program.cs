class Program
{
    public static void Main()
    {
        Console.WriteLine("Generics Demo Menu");
        Console.WriteLine("1. Smart Warehouse Management System");
        Console.WriteLine("2. Dynamic Online Marketplace");
        Console.WriteLine("3. Multi-Level University Course Management System");
        Console.WriteLine("4. Personalized Meal Plan Generator");
        Console.WriteLine("5. AI-Driven Resume Screening System");
        Console.WriteLine("6. Exit");
        while (true)
        {            
            Console.Write("Select an option: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Storage<Electronics> electronicsStorage =
                new Storage<Electronics>();

                electronicsStorage.AddItem(
                    new Electronics("E01", "Laptop", 75000)
                );

                electronicsStorage.AddItem(
                    new Electronics("E02", "Smartphone", 35000)
                );


                // Create Groceries storage
                Storage<Groceries> groceriesStorage =
                    new Storage<Groceries>();

                groceriesStorage.AddItem(
                    new Groceries("G01", "Rice", 1200)
                );

                groceriesStorage.AddItem(
                    new Groceries("G02", "Milk", 70)
                );


                // Create Furniture storage
                Storage<Furniture> furnitureStorage =
                    new Storage<Furniture>();

                furnitureStorage.AddItem(
                    new Furniture("F01", "Dining Table", 15000)
                );

                furnitureStorage.AddItem(
                    new Furniture("F02", "Office Chair", 5000)
                );


                // Display all items

                Console.WriteLine("===== ELECTRONICS =====");
                electronicsStorage.DisplayItems();

                Console.WriteLine("\n===== GROCERIES =====");
                groceriesStorage.DisplayItems();

                Console.WriteLine("\n===== FURNITURE =====");
                furnitureStorage.DisplayItems();
            }

            else if (choice == 2)
            {
                 BookCategory bookCategory = new BookCategory();

                ClothingCategory clothingCategory = new ClothingCategory();


                Product<BookCategory> book =
                    new Product<BookCategory>(
                        "C# Programming",
                        1000,
                        bookCategory
                    );


                Product<ClothingCategory> shirt =
                    new Product<ClothingCategory>(
                        "Cotton Shirt",
                        2000,
                        clothingCategory
                    );


                Console.WriteLine("BEFORE DISCOUNT");

                book.DisplayProduct();

                Console.WriteLine();

                shirt.DisplayProduct();


                // Apply discounts

                Marketplace.ApplyDiscount(book, 10);

                Marketplace.ApplyDiscount(shirt, 20);


                Console.WriteLine("\nAFTER DISCOUNT");

                book.DisplayProduct();

                Console.WriteLine();

                shirt.DisplayProduct();
            }

            else if(choice == 3)
            {
                List<Course> courses = new List<Course>();


                // Exam-based course

                Course<ExamCourse> oop =
                    new Course<ExamCourse>(
                        "CS101",
                        "Object Oriented Programming",
                        "Computer Science",
                        new ExamCourse()
                    );


                // Assignment-based course

                Course<AssignmentCourse> softwareEngineering =
                    new Course<AssignmentCourse>(
                        "CS102",
                        "Software Engineering",
                        "Computer Science",
                        new AssignmentCourse()
                    );


                courses.Add(oop);
                courses.Add(softwareEngineering);


                // Display all courses

                foreach (Course course in courses)
                {
                    course.DisplayCourse();
                }
            }

            else if(choice == 4)
            {
                VegetarianMeal vegetarian =
                MealPlanGenerator.GenerateMealPlan<VegetarianMeal>();


                // Generate Vegan meal

                VeganMeal vegan =
                    MealPlanGenerator.GenerateMealPlan<VeganMeal>();


                // Generate Keto meal

                KetoMeal keto =
                    MealPlanGenerator.GenerateMealPlan<KetoMeal>();


                // Generate High-Protein meal

                HighProteinMeal highProtein =
                    MealPlanGenerator.GenerateMealPlan<HighProteinMeal>();


                // Put them into generic Meal objects

                Meal<VegetarianMeal> vegetarianMeal =
                    new Meal<VegetarianMeal>(vegetarian);

                Meal<VeganMeal> veganMeal =
                    new Meal<VeganMeal>(vegan);

                Meal<KetoMeal> ketoMeal =
                    new Meal<KetoMeal>(keto);

                Meal<HighProteinMeal> highProteinMeal =
                    new Meal<HighProteinMeal>(highProtein);


                // Display

                vegetarianMeal.Display();

                veganMeal.Display();

                ketoMeal.Display();

                highProteinMeal.Display();
            }

            else if(choice == 5)
            {
                 Resume<SoftwareEngineer> softwareResume =
                    new Resume<SoftwareEngineer>(
                    "Krishna",
                    new SoftwareEngineer()
                );


                Resume<DataScientist> dataResume =
                    new Resume<DataScientist>(
                        "Rahul",
                        new DataScientist()
                    );


                // Generic method

                ResumeScreening.ScreenResume(softwareResume);

                ResumeScreening.ScreenResume(dataResume);


                // Screening pipeline

                List<Resume> screeningPipeline =
                    new List<Resume>();

                screeningPipeline.Add(softwareResume);
                screeningPipeline.Add(dataResume);


                Console.WriteLine("SCREENING PIPELINE");
                Console.WriteLine();

                foreach (Resume resume in screeningPipeline)
                {
                    resume.DisplayResume();
                }
            }

            else if(choice == 0)
            {
                Console.WriteLine("Exiting...");
                Environment.Exit(0);
            }

            else Console.WriteLine("Inavlaid Input! Try Again.");
        }
    }
}