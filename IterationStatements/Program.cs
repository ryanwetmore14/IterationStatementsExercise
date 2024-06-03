namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void PrintNums1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time\

        public static void UpByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void TwoNumsSame(int numOne, int numTwo)
        {
            if (numOne == numTwo)
            {
                Console.WriteLine($"{numOne} and {numTwo} are the same");
            }
            else
            {
                Console.WriteLine($"{numOne} and {numTwo} are not the same");
            }
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even!");
            }
            else
            {
                Console.WriteLine($"{number} is odd!");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void IsPositive(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive!");
            }
            else
            {
                Console.WriteLine($"{number} is negative!");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void CanVote()
        {
            Console.WriteLine("Please enter your age:");
            bool canParse = int.TryParse(Console.ReadLine(), out int userAge);

            while (canParse == false)
            {
                Console.WriteLine("Invalid Input, please enter your age:");
                canParse = int.TryParse(Console.ReadLine(), out userAge);
            }

            if (userAge >= 18)
            {
                Console.WriteLine($"Congrats! {userAge} is old enough to vote!");
            }
            else
            {
                Console.WriteLine($"Sorry, {userAge} is not old enough to vote!");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void IsInTenRange(int number)
        {
            if (number <= 10 && number >= -10)
            {
                Console.WriteLine($"{number} is in ten range!");
            }
            else
            {
                Console.WriteLine($"{number} is not in ten range!");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultThru12(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {number} = {i * number}");
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //PrintNums1000();
            //UpByThree();
            //TwoNumsSame(1, 2);
            //EvenOrOdd(4);
            //IsPositive(2);
            //CanVote();
            //IsInTenRange(9);
            MultThru12(5);
        }
    }
}
