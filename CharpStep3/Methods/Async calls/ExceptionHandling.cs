using System;

namespace ExceptionHandlingClean
{
    class TestClass
    {
        // 1. Null Reference Example
        public static void FirstMethod(string input)
        {
            try
            {
                Console.WriteLine($"Input Length: {input.Length}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Input cannot be null.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("FirstMethod execution completed.\n");
            }
        }

        // 2. Format Exception Example
        public static void SecondMethod()
        {
            try
            {
                int.Parse("abcd");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input format is invalid.");
                Console.WriteLine($"Details: {ex.Message}\n");
            }
        }

        // 3. Combined Exception Example
        public static void ThirdMethod(string input1, string input2, int a, int b)
        {
            try
            {
                Console.WriteLine($"Input1 Length: {input1.Length}");
                int.Parse(input2);
                int result = a / b;
                Console.WriteLine($"Division Result: {result}");
            }
            catch (FormatException )
            {
                Console.WriteLine("Second input is not in correct format.");
            }
            catch (NullReferenceException )
            {
                Console.WriteLine("Input should not be null.");
            }
            catch (DivideByZeroException )
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            Console.WriteLine("ThirdMethod execution completed.\n");
        }

        // 4. Manual Exception Throwing Example
        public static void FourthMethod()
        {
            try
            {
                int age = -1;
                if (age < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
                Console.WriteLine($"Age: {age}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Invalid argument: {ex.Message}");
            }
            Console.WriteLine("FourthMethod execution completed.\n");
        }

        // 5. Nested Try-Catch Example
        public static void FifthMethod(string input1, string input2, int a, int b)
        {
            try
            {
                Console.WriteLine($"Input1 Length: {input1.Length}");

                try
                {
                    int.Parse(input2);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid format in input2.");
                }

                int result = a / b;
                Console.WriteLine($"Division Result: {result}");
            }
            catch (NullReferenceException ex)
            {
                try
                {
                    int dummy = 0 / 10;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Caught division by zero inside NullReference catch.");
                }

                Console.WriteLine($"Null input: {ex.Message}");
            }
            catch (DivideByZeroException )
            {
                Console.WriteLine("Divide by zero is not allowed.");
            }
            Console.WriteLine("FifthMethod execution completed.\n");
        }

        // 6. General Exception Handler (Fallback)
        public static void SixthMethod(string input1, string input2, int a, int b)
        {
            try
            {
                Console.WriteLine($"Input1 Length: {input1.Length}");
                int.Parse(input2);
                int result = a / b;
                Console.WriteLine($"Division Result: {result}");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Please check your inputs.");
            }
            Console.WriteLine("SixthMethod execution completed.\n");
        }
    }

    // Custom exception for age validation
    public class AgeValidationException : Exception
    {
        public AgeValidationException(string message) : base(message) { }
    }

    class Program
    {
        public static void Main()
        {
            TestClass.FirstMethod(null);

            //TestClass.SecondMethod();
            //TestClass.ThirdMethod("Hello", "123", 10, 2);
            //TestClass.FourthMethod();
            //TestClass.FifthMethod("Hi", "xyz", 10, 0);
            //TestClass.SixthMethod("Hi", "abc", 10, 0);

            Console.WriteLine("Program completed successfully.");
        }
    }
}