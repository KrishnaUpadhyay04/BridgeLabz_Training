using UnitTesting.Classes;

namespace UnitTesting.NUnit
{
    public class Tests
    {
        private Calculator calculator;
        private StringUtils stringutils;
        private ListManager listmanager;
        private List<int> list;
        private ExceptionHandler exceptionhandler;
        private DatabaseConnection connection;
        private NumberChecker numberChecker;
        private PerformanceTester performanceTester;
        private FileProcessor fileProcessor;
        private string filePath;
        private BankAccount bankAccount;
        private PasswordValidator passwordValidator;
        private TemperatureConvertor temperatureConvertor;
        private DateFormatter dateFormatter;
        private UserRegistration userRegistration;


        [SetUp]
        public void Setup()
        {
            calculator = new();
            stringutils = new();
            listmanager = new();
            list = new();
            exceptionhandler = new();
            connection = new();
            connection.Connect();
            numberChecker = new();
            performanceTester = new();
            fileProcessor = new();
            filePath = Path.Combine(
                Path.GetTempPath(),
                "UnitTestingTestFile.txt"
            );
            bankAccount = new();
            passwordValidator = new();
            temperatureConvertor = new();
            dateFormatter = new();
            userRegistration = new();
        }



        // Calculator Tests

        [Test]
        public void AddTwoNumbers()
        {
            int Result = calculator.Add(10, 5);

            Assert.That(Result, Is.EqualTo(15));
        }

        [Test]
        public void SubtractTwoNumbers()
        {
            int Result = calculator.Subtract(10, 5);

            Assert.That(Result, Is.EqualTo(5));
        }

        [Test]
        public void MultiplyTwoNumbers()
        {
            int Result = calculator.Multiply(10, 5);

            Assert.That(Result, Is.EqualTo(50));
        }

        [Test]
        public void Divide_ShouldReturnCorrectAnswer()
        {
            double result = calculator.Divide(10, 5);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Divide_ByZero_ShouldThrowArithmeticException()
        {
            Assert.Throws<ArithmeticException>(() =>
            {
                calculator.Divide(10, 0);
            });
        }


        // StringUtils Tests

        [Test]
        public void ReverseTheString()
        {
            string Result = stringutils.ReverseTheString("krishna");

            Assert.That(Result, Is.EqualTo("anhsirk"));
        }

        [Test]
        public void CheckIfTheStringISPalindrome()
        {
            bool Result = stringutils.CheckPalindrome("racecar");

            Assert.That(Result, Is.True);
        }

        [Test]
        public void ConvertStringToUpperCase()
        {
            string Result = stringutils.ToUpperCase("krishna");

            Assert.That(Result, Is.EqualTo("Krishna"));
        }


        // List Manager Tests

        [Test]
        public void AddElement_ShouldAddElement()
        {
            listmanager.AddElement(list, 10);

            Assert.That(list, Does.Contain(10));
        }

        [Test]
        public void RemoveElement_ShouldRemoveElement()
        {
            list.Add(10);
            list.Add(20);

            listmanager.RemoveElement(list, 10);

            Assert.That(list, Does.Not.Contain(10));
        }

        [Test]
        public void GetSize_ShouldReturnCorrectSize()
        {
            list.Add(10);
            list.Add(20);
            list.Add(30);

            int result = listmanager.GetSize(list);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Size_ShouldDecreaseAfterRemoval()
        {
            list.Add(10);
            list.Add(20);

            listmanager.RemoveElement(list, 10);

            Assert.That(listmanager.GetSize(list), Is.EqualTo(1));
        }


        // Exception Handler Tests

        [Test]
        public void Divide_ShouldReturnCorrectResult()
        {
            int result = exceptionhandler.Divide(10, 2);

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void DivideByZero_ShouldThrowArithmeticException()
        {
            Assert.Throws<ArithmeticException>(() =>
            {
                exceptionhandler.Divide(10, 0);
            });
        }


        // Databse Connection Tests
        [TearDown]
        public void TearDown()
        {
            connection.Disconnect();
        }

        [Test]
        public void Connection_ShouldBeEstablished()
        {
            Assert.That(connection.IsConnected, Is.True);
        }

        [Test]
        public void Connection_ShouldBeClosed()
        {
            connection.Disconnect();

            Assert.That(connection.IsConnected, Is.False);
        }


        // Number Checker Tests

        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(6, true)]
        [TestCase(7, false)]
        [TestCase(9, false)]
        public void IsEven_ShouldReturnCorrectResult(int number, bool expected)
        {
            bool result = numberChecker.IsEven(number);

            Assert.That(result, Is.EqualTo(expected));
        }


        // Performance Tester Tests

        [Test]
        [Timeout(2000)]          // Test will fail as the methd gives 3 second timeout and we are giving 2 second
        public void LongRunningTask_ShouldFinishWithinTwoSeconds()
        {
            string result = performanceTester.LongRunningTask();

            Assert.That(result, Is.EqualTo("Task Completed"));
        }


        // File Processor Tests

        [TearDown]
        public void TearDownTheTest()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        [Test]
        public void WriteToFile_ShouldCreateFile()
        {
            fileProcessor.WriteToFile(filePath, "Hello World");

            Assert.That(File.Exists(filePath), Is.True);
        }

        [Test]
        public void WriteAndRead_ShouldReturnCorrectContent()
        {
            fileProcessor.WriteToFile(filePath, "Hello World");

            string result = fileProcessor.ReadFromFile(filePath);

            Assert.That(result, Is.EqualTo("Hello World"));
        }

        [Test]
        public void ReadFromNonExistingFile_ShouldThrowIOException()
        {
            Assert.Throws<IOException>(() =>
            {
                fileProcessor.ReadFromFile(filePath);
            });
        }


        // Bank Account Tests

        [Test]
        public void Deposit_ShouldIncreaseBalance()
        {
            bankAccount.Deposit(1000);

            Assert.That(bankAccount.GetBalance(), Is.EqualTo(1000));
        }

        [Test]
        public void Withdraw_ShouldDecreaseBalance()
        {
            bankAccount.Deposit(1000);

            bankAccount.Withdraw(400);

            Assert.That(bankAccount.GetBalance(), Is.EqualTo(600));
        }

        [Test]
        public void WithdrawWithInsufficientFunds_ShouldThrowException()
        {
            bankAccount.Deposit(500);

            Assert.Throws<InvalidOperationException>(() =>
            {
                bankAccount.Withdraw(600);
            });
        }

        [Test]
        public void Balance_ShouldRemainSameAfterFailedWithdrawal()
        {
            bankAccount.Deposit(500);

            Assert.Throws<InvalidOperationException>(() =>
            {
                bankAccount.Withdraw(600);
            });

            Assert.That(bankAccount.GetBalance(), Is.EqualTo(500));
        }


        // Password Validator Tests

        [Test]
        public void ValidPassword_ShouldReturnTrue()
        {
            bool result = passwordValidator.IsValid("Password1");

            Assert.That(result, Is.True);
        }

        [Test]
        public void PasswordTooShort_ShouldReturnFalse()
        {
            bool result = passwordValidator.IsValid("Pass1");

            Assert.That(result, Is.False);
        }

        [Test]
        public void PasswordWithoutUppercase_ShouldReturnFalse()
        {
            bool result = passwordValidator.IsValid("password1");

            Assert.That(result, Is.False);
        }

        [Test]
        public void PasswordWithoutDigit_ShouldReturnFalse()
        {
            bool result = passwordValidator.IsValid("Password");

            Assert.That(result, Is.False);
        }


        // Temperature Convertor

        [Test]
        public void CelsiusToFahrenheit_ShouldConvertCorrectly()
        {
            double result = temperatureConvertor.CelsiusToFahrenheit(0);

            Assert.That(result, Is.EqualTo(32));
        }

        [Test]
        public void CelsiusToFahrenheit_ShouldConvert100Correctly()
        {
            double result = temperatureConvertor.CelsiusToFahrenheit(100);

            Assert.That(result, Is.EqualTo(212));
        }

        [Test]
        public void FahrenheitToCelsius_ShouldConvertCorrectly()
        {
            double result = temperatureConvertor.FahrenheitToCelsius(32);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void FahrenheitToCelsius_ShouldConvert212Correctly()
        {
            double result = temperatureConvertor.FahrenheitToCelsius(212);

            Assert.That(result, Is.EqualTo(100));
        }


        // Date Formatter Tests

        [Test]
        public void FormatDate_ShouldConvertDateCorrectly()
        {
            string result = dateFormatter.FormatDate("2026-08-08");

            Assert.That(result, Is.EqualTo("08-08-2026"));
        }

        [Test]
        public void FormatDate_ShouldConvertAnotherDateCorrectly()
        {
            string result = dateFormatter.FormatDate("2025-12-25");

            Assert.That(result, Is.EqualTo("25-12-2025"));
        }

        [Test]
        public void FormatDate_InvalidFormat_ShouldThrowException()
        {
            Assert.Throws<FormatException>(() =>
            {
                dateFormatter.FormatDate("08-08-2026");
            });
        }

        [Test]
        public void FormatDate_InvalidDate_ShouldThrowException()
        {
            Assert.Throws<FormatException>(() =>
            {
                dateFormatter.FormatDate("2026-99-99");
            });
        }


        // User Resgistration Tests

        [Test]
        public void RegisterUser_ValidDetails_ShouldNotThrowException()
        {
            Assert.DoesNotThrow(() =>
            {
                userRegistration.RegisterUser(
                    "Krishna",
                    "krishna@example.com",
                    "Password123"
                );
            });
        }

        [Test]
        public void RegisterUser_EmptyUsername_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                userRegistration.RegisterUser(
                    "",
                    "krishna@example.com",
                    "Password123"
                );
            });
        }

        [Test]
        public void RegisterUser_EmptyEmail_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                userRegistration.RegisterUser(
                    "Krishna",
                    "",
                    "Password123"
                );
            });
        }

        [Test]
        public void RegisterUser_EmptyPassword_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                userRegistration.RegisterUser(
                    "Krishna",
                    "krishna@example.com",
                    ""
                );
            });
        }
    }
}
