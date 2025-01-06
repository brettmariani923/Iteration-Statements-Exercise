using System.Formats.Asn1;
using System.Globalization;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            static void PrintNumbers()
            {
               
                for (int num = 1000; num <= 1000 && num >= -1000; num--)
                {
                    Console.WriteLine(num);
                }
            }
                    PrintNumbers();


            
            static void PrintEveryThirdNumber()
            {

                for (int threes = 3; threes <= 999; threes += 3)
                {
                    Console.WriteLine(threes);
                }
            }    
                    PrintEveryThirdNumber();



            static bool AreNumbersEqual(int num1, int num2)
            {

                if (num1 == num2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }    
                 AreNumbersEqual(4, 5);



            static bool IsEven(int number)
            {

                if (number % 2 == 0)
                {
                   
                    return true;
                }
                else
                {
                    return false;
                }
            }
                 IsEven(15);



            static bool IsPositive(int number)
            {
                if (number >= 0)
                {
                   return true;
                }
                else
                {
                   return false;
                }
            }        
                 IsPositive(1500);



            static bool CanVote(int age)
            {
                if (age >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }    
                 CanVote(25);


            static bool IsRange(int number)
            {
                if(number < 10 && number > -10)
                {
                    return true;
                }
                else
                {
                    return false;   
                }
            }
                Console.WriteLine("Please input a number");
                int userInput = int.Parse(Console.ReadLine());

                Console.WriteLine($"{IsRange(userInput)}");





                // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

            static void DisplayMultiplicationTable(int number)
            {
                Console.WriteLine($"1 * {number} = {number * 1}");   
                Console.WriteLine($"2 * {number} = {number * 2}");
                Console.WriteLine($"3 * {number} = {number * 3}");
                Console.WriteLine($"4 * {number} = {number * 4}");
                Console.WriteLine($"5 * {number} = {number * 5}");
                Console.WriteLine($"6 * {number} = {number * 6}");
                Console.WriteLine($"7 * {number} = {number * 7}");
                Console.WriteLine($"8 * {number} = {number * 8}");
                Console.WriteLine($"9 * {number} = {number * 9}");
                Console.WriteLine($"10 * {number} = {number * 10}");
                Console.WriteLine($"11 * {number} = {number * 11}");
                Console.WriteLine($"12 * {number} = {number * 12}"); 
            }
            
                Console.WriteLine("Pick a number");
                int userInput1 = int.Parse(Console.ReadLine());

                DisplayMultiplicationTable(userInput1);

                
            



        }

    }
}
