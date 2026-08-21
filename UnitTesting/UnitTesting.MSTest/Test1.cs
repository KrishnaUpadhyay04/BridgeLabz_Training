using UnitTesting.Classes;

namespace UnitTesting.MSTest
{
    // CALCULATOR TESTS

    [TestClass]
    public sealed class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void AddTwoNumbers()
        {
            int result = calculator.Add(10, 5);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void SubtractTwoNumbers()
        {
            int result = calculator.Subtract(10, 5);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void MultiplyTwoNumbers()
        {
            int result = calculator.Multiply(10, 5);

            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void DivideTwoNumbers()
        {
            double result = calculator.Divide(10, 5);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideByZero_ShouldThrowException()
        {
            Assert.Throws<ArithmeticException>(() =>
            {
                calculator.Divide(10, 0);
            });
        }
    }


    // STRING UTILITY TESTS


    [TestClass]
    public sealed class StringUtilsTests
    {
        private StringUtils stringUtils;

        [TestInitialize]
        public void Setup()
        {
            stringUtils = new StringUtils();
        }

        [TestMethod]
        public void Reverse_ShouldReverseString()
        {
            string result = stringUtils.ReverseTheString("hello");

            Assert.AreEqual("olleh", result);
        }

        [TestMethod]
        public void IsPalindrome_ShouldReturnTrue()
        {
            bool result = stringUtils.CheckPalindrome("madam");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_ShouldReturnFalse()
        {
            bool result = stringUtils.CheckPalindrome("hello");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ToUpperCase_ShouldConvertString()
        {
            string result = stringUtils.ToUpperCase("hello");

            Assert.AreEqual("HELLO", result);
        }
    }


    // ============================================================
    // 3. LIST MANAGER TESTS
    // ============================================================

    [TestClass]
    public sealed class ListManagerTests
    {
        private ListManager listManager;
        private List<int> list;

        [TestInitialize]
        public void Setup()
        {
            listManager = new ListManager();
            list = new List<int>();
        }

        [TestMethod]
        public void AddElement_ShouldAddElement()
        {
            listManager.AddElement(list, 10);

            CollectionAssert.Contains(list, 10);
        }

        [TestMethod]
        public void RemoveElement_ShouldRemoveElement()
        {
            list.Add(10);
            list.Add(20);

            listManager.RemoveElement(list, 10);

            CollectionAssert.DoesNotContain(list, 10);
        }

        [TestMethod]
        public void GetSize_ShouldReturnCorrectSize()
        {
            list.Add(10);
            list.Add(20);
            list.Add(30);

            int result = listManager.GetSize(list);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Size_ShouldDecreaseAfterRemoval()
        {
            list.Add(10);
            list.Add(20);

            listManager.RemoveElement(list, 10);

            Assert.AreEqual(1, listManager.GetSize(list));
        }
    }


    // ============================================================
    // 4. EXCEPTION HANDLING TESTS
    // ============================================================

    [TestClass]
    public sealed class ExceptionHandlerTests
    {
        private ExceptionHandler exceptionHandler;

        [TestInitialize]
        public void Setup()
        {
            exceptionHandler = new ExceptionHandler();
        }

        [TestMethod]
        public void Divide_ShouldReturnCorrectResult()
        {
            int result = exceptionHandler.Divide(10, 2);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void DivideByZero_ShouldThrowArithmeticException()
        {
            Assert.Throws<ArithmeticException>(() =>
            {
                exceptionHandler.Divide(10, 0);
            });
        }
    }


    // ============================================================
    // 5. DATABASE CONNECTION TESTS
    // ============================================================

    [TestClass]
    public sealed class DatabaseConnectionTests
    {
        private DatabaseConnection database;

        [TestInitialize]
        public void Setup()
        {
            database = new DatabaseConnection();

            database.Connect();
        }

        [TestCleanup]
        public void Cleanup()
        {
            database.Disconnect();
        }

        [TestMethod]
        public void Connection_ShouldBeEstablished()
        {
            Assert.IsTrue(database.IsConnected);
        }

        [TestMethod]
        public void Connection_ShouldBeClosed()
        {
            database.Disconnect();

            Assert.IsFalse(database.IsConnected);
        }
    }


    // ============================================================
    // 6. PARAMETERIZED TESTS - NUMBER CHECKER
    // ============================================================

    [TestClass]
    public sealed class NumberCheckerTests
    {
        private NumberChecker numberChecker;

        [TestInitialize]
        public void Setup()
        {
            numberChecker = new NumberChecker();
        }

        [TestMethod]
        [DataRow(2, true)]
        [DataRow(4, true)]
        [DataRow(6, true)]
        [DataRow(7, false)]
        [DataRow(9, false)]
        public void IsEven_ShouldReturnCorrectResult(int number, bool expected)
        {
            bool result = numberChecker.IsEven(number);

            Assert.AreEqual(expected, result);
        }
    }


    // ============================================================
    // 7. PERFORMANCE TESTS
    // ============================================================

    [TestClass]
    public sealed class PerformanceTesterTests
    {
        private PerformanceTester performanceTester;

        [TestInitialize]
        public void Setup()
        {
            performanceTester = new PerformanceTester();
        }

        [TestMethod]
        [Timeout(2000)]
        public void LongRunningTask_ShouldFinishWithinTwoSeconds()
        {
            string result = performanceTester.LongRunningTask();

            Assert.AreEqual("Task Completed", result);
        }
    }


    // ============================================================
    // 8. FILE PROCESSING TESTS
    // ============================================================

    [TestClass]
    public sealed class FileProcessorTests
    {
        private FileProcessor fileProcessor;
        private string filePath;

        [TestInitialize]
        public void Setup()
        {
            fileProcessor = new FileProcessor();

            filePath = Path.Combine(
                Path.GetTempPath(),
                "UnitTestingTestFile.txt"
            );
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        [TestMethod]
        public void WriteToFile_ShouldCreateFile()
        {
            fileProcessor.WriteToFile(filePath, "Hello World");

            Assert.IsTrue(File.Exists(filePath));
        }

        [TestMethod]
        public void WriteAndRead_ShouldReturnCorrectContent()
        {
            fileProcessor.WriteToFile(filePath, "Hello World");

            string result = fileProcessor.ReadFromFile(filePath);

            Assert.AreEqual("Hello World", result);
        }

        [TestMethod]
        public void ReadFromNonExistingFile_ShouldThrowIOException()
        {
            Assert.Throws<IOException>(() =>
            {
                fileProcessor.ReadFromFile(filePath);
            });
        }
    }


    // ============================================================
    // 9. BANK ACCOUNT TESTS
    // ============================================================

    [TestClass]
    public sealed class BankAccountTests
    {
        private BankAccount bankAccount;

        [TestInitialize]
        public void Setup()
        {
            bankAccount = new BankAccount();
        }

        [TestMethod]
        public void Deposit_ShouldIncreaseBalance()
        {
            bankAccount.Deposit(1000);

            Assert.AreEqual(1000, bankAccount.GetBalance());
        }

        [TestMethod]
        public void Withdraw_ShouldDecreaseBalance()
        {
            bankAccount.Deposit(1000);

            bankAccount.Withdraw(400);

            Assert.AreEqual(600, bankAccount.GetBalance());
        }

        [TestMethod]
        public void WithdrawWithInsufficientFunds_ShouldThrowException()
        {
            bankAccount.Deposit(500);

            Assert.Throws<InvalidOperationException>(() =>
            {
                bankAccount.Withdraw(600);
            });
        }

        [TestMethod]
        public void Balance_ShouldRemainSameAfterFailedWithdrawal()
        {
            bankAccount.Deposit(500);

            Assert.Throws<InvalidOperationException>(() =>
            {
                bankAccount.Withdraw(600);
            });

            Assert.AreEqual(500, bankAccount.GetBalance());
        }
    }


    // ============================================================
    // 10. PASSWORD VALIDATOR TESTS
    // ============================================================

    [TestClass]
    public sealed class PasswordValidatorTests
    {
        private PasswordValidator passwordValidator;

        [TestInitialize]
        public void Setup()
        {
            passwordValidator = new PasswordValidator();
        }

        [TestMethod]
        public void ValidPassword_ShouldReturnTrue()
        {
            bool result = passwordValidator.IsValid("Password1");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PasswordTooShort_ShouldReturnFalse()
        {
            bool result = passwordValidator.IsValid("Pass1");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PasswordWithoutUppercase_ShouldReturnFalse()
        {
            bool result = passwordValidator.IsValid("password1");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PasswordWithoutDigit_ShouldReturnFalse()
        {
            bool result = passwordValidator.IsValid("Password");

            Assert.IsFalse(result);
        }
    }


    // ============================================================
    // 11. TEMPERATURE CONVERTER TESTS
    // ============================================================

    [TestClass]
    public sealed class TemperatureConverterTests
    {
        private TemperatureConvertor converter;

        [TestInitialize]
        public void Setup()
        {
            converter = new();
        }

        [TestMethod]
        public void CelsiusToFahrenheit_ShouldConvertCorrectly()
        {
            double result = converter.CelsiusToFahrenheit(0);

            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_ShouldConvert100Correctly()
        {
            double result = converter.CelsiusToFahrenheit(100);

            Assert.AreEqual(212, result);
        }

        [TestMethod]
        public void FahrenheitToCelsius_ShouldConvertCorrectly()
        {
            double result = converter.FahrenheitToCelsius(32);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FahrenheitToCelsius_ShouldConvert212Correctly()
        {
            double result = converter.FahrenheitToCelsius(212);

            Assert.AreEqual(100, result);
        }
    }


    // ============================================================
    // 12. DATE FORMATTER TESTS
    // ============================================================

    [TestClass]
    public sealed class DateFormatterTests
    {
        private DateFormatter dateFormatter;

        [TestInitialize]
        public void Setup()
        {
            dateFormatter = new DateFormatter();
        }

        [TestMethod]
        public void FormatDate_ShouldConvertDateCorrectly()
        {
            string result = dateFormatter.FormatDate("2026-08-08");

            Assert.AreEqual("08-08-2026", result);
        }

        [TestMethod]
        public void FormatDate_ShouldConvertAnotherDateCorrectly()
        {
            string result = dateFormatter.FormatDate("2025-12-25");

            Assert.AreEqual("25-12-2025", result);
        }

        [TestMethod]
        public void FormatDate_InvalidFormat_ShouldThrowException()
        {
            Assert.Throws<FormatException>(() =>
            {
                dateFormatter.FormatDate("08-08-2026");
            });
        }

        [TestMethod]
        public void FormatDate_InvalidDate_ShouldThrowException()
        {
            Assert.Throws<FormatException>(() =>
            {
                dateFormatter.FormatDate("2026-99-99");
            });
        }
    }


    // ============================================================
    // 13. USER REGISTRATION TESTS
    // ============================================================

    [TestClass]
    public sealed class UserRegistrationTests
    {
        private UserRegistration userRegistration;

        [TestInitialize]
        public void Setup()
        {
            userRegistration = new UserRegistration();
        }

        [TestMethod]
        public void RegisterUser_ValidDetails_ShouldNotThrowException()
        {
            userRegistration.RegisterUser(
                "Krishna",
                "krishna@example.com",
                "Password123"
            );
        }

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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