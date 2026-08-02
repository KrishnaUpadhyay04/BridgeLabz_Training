using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("--- ObjectModeling Demo ---\n");

		// Bank
		var bank = new ObjectModeling.Bank.Bank { BankName = "State Bank" };
		var bankCustomer = new ObjectModeling.Bank.Customer("Alice", 5000);
		bank.OpenAccount(bankCustomer);
		bankCustomer.GetBalance();

		Console.WriteLine();

		// Company
		var dept = new ObjectModeling.Company.Department("Engineering");
		var emp = new ObjectModeling.Company.Employee("Bob", dept, 50000);
		dept.AddEmployee(emp);
		var comp = new ObjectModeling.Company.Company();
		comp.AddDepartment(dept);
		comp.DisplayCompanyDetails();

		Console.WriteLine();

		// E-Commerce
		var p1 = new ObjectModeling.ECommerce.Product("Laptop", 70000);
		var p2 = new ObjectModeling.ECommerce.Product("Mouse", 1200);
		var eCustomer = new ObjectModeling.ECommerce.Customer("Krishna");
		var order = new ObjectModeling.ECommerce.Order(101, eCustomer);
		order.AddProduct(p1);
		order.AddProduct(p2);
		eCustomer.PlaceOrder(order);
		eCustomer.DisplayOrders();
		order.DisplayOrder();

		Console.WriteLine();

		// Hospital
		var hospital = new ObjectModeling.Hospital.Hospital("City Hospital");
		var d1 = new ObjectModeling.Hospital.Doctor("Dr. Sharma");
		var patient = new ObjectModeling.Hospital.Patient("Rahul");
		hospital.AddDoctor(d1);
		hospital.AddPatient(patient);
		d1.AddPatient(patient);
		d1.Consult(patient);
		d1.DisplayPatients();
		patient.DisplayDoctors();

		Console.WriteLine();

		// Library
		var library = new ObjectModeling.Library.Library("Central Library");
		var book1 = new ObjectModeling.Library.Book("C# in Depth", "Jon Skeet", 45.0);
		library.AddBook(book1);
		library.DisplayLibraryBooks();

		Console.WriteLine();

		// School
		var school = new ObjectModeling.School.School("Chitkara University");
		var s1 = new ObjectModeling.School.Student("Krishna");
		var course = new ObjectModeling.School.Course("Data Structures");
		school.AddStudent(s1);
		s1.EnrollCourse(course);
		school.ShowStudents();
		s1.ViewCourses();
		course.ShowStudents();

		Console.WriteLine();

		// University Faculties
		var faculty = new ObjectModeling.UniversityFaculties.Faculty("Dr. Gupta");
		var uni = new ObjectModeling.UniversityFaculties.University("Chitkara University");
		uni.AddDepartment("Computer Science");
		uni.AddFaculty(faculty);
		uni.DisplayDepartments();
		uni.DisplayFaculties();
		faculty.Display();

		Console.WriteLine();

		// University Management
		var um = new ObjectModeling.UniversityMgmt.University("Chitkara");
		var student = new ObjectModeling.UniversityMgmt.Student("Aman");
		var prof = new ObjectModeling.UniversityMgmt.Professor("Dr. Rao");
		var umCourse = new ObjectModeling.UniversityMgmt.Course("DBMS");
		um.AddStudent(student);
		um.AddProfessor(prof);
		um.AddCourse(umCourse);
		student.EnrollCourse(umCourse);
		prof.AssignCourse(umCourse);
		um.DisplayStudents();
		um.DisplayProfessors();
		um.DisplayCourses();
		umCourse.DisplayStudents();
		umCourse.DisplayProfessor();

		Console.WriteLine("\n--- Demo complete ---");
	}
}

