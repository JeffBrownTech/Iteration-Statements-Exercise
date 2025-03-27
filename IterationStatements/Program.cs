using System.Reflection.Metadata.Ecma335;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i.ToString());
            }
        }
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        public static void PrintEveryThirdNumber()
        {
            for(int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i.ToString());
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        public static bool AreNumbersEqual(int num1, int num2)
        {
            return num1 == num2;
        }
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static bool IsEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static bool IsPositive(int number)
        {
            return number > 0 ? true : false;
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static bool CanVote(int age)
        {
            return age >= 18 ? true : false;
        }
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        public static bool IsInRange(int number)
        {
            return (number >= -10 && number <= 10) ? true : false;
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        public static void DisplayMultiplicationTable(int number)
        {
            Console.WriteLine("\n--- Multiplication Table ---");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {i * number}");
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintEveryThirdNumber();
            Console.WriteLine($"\nAre 3 and 4 Equal? : {AreNumbersEqual(3, 4)}");   // False
            Console.WriteLine($"Are 10 and 10 Equal? : {AreNumbersEqual(10, 10)}");   // True
            Console.WriteLine($"Is 10 Even? : {IsEven(10)}");  // True
            Console.WriteLine($"Is 23 Even? : {IsEven(23)}");  // False

            Console.Write("\nEnter your age to see if you can vote: ");
            string? ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out int age))
            {
                if (CanVote(age))
                {
                    Console.WriteLine("You can vote!");
                }
                else
                {
                    Console.WriteLine("You are not eligible to vote just yet.");
                }
            }
            else
            {
                Console.WriteLine("That was not valid input!");
            }

            Console.WriteLine("");

            Console.WriteLine($"Is 2 within range? {IsInRange(2)}");
            Console.WriteLine($"Is -2 within range? {IsInRange(-2)}");
            Console.WriteLine($"Is 33 within range? {IsInRange(33)}");
            Console.WriteLine($"Is -33 within range? {IsInRange(-33)}");

            DisplayMultiplicationTable(2);
            DisplayMultiplicationTable(5);
            DisplayMultiplicationTable(0);
        }
    }
}
