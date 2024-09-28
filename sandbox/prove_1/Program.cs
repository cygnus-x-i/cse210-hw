using System;

namespace prove_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prove Part 1
            string firstName;
            string lastName;

            Console.Write("What is your first name? ");
            firstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            lastName = Console.ReadLine();
            Console.WriteLine($"Your name is {lastName}, {firstName}.");

            // Prove Part 2
            string scorePercent;
            Console.Write("What was your score (%)? ");
            scorePercent = Console.ReadLine();
            int percent;

            // Ensure valid input
            if (int.TryParse(scorePercent, out percent))
            {
                string grade;
                if (percent >= 90)
                {
                    grade = "A";
                }
                else if (percent >= 80)
                {
                    grade = "B";
                }
                else if (percent >= 70)
                {
                    grade = "C";
                }
                else if (percent >= 60)
                {
                    grade = "D";
                }
                else
                {
                    grade = "F";
                }
                Console.WriteLine($"Your grade is: {grade}");
            }
            else
            {
                Console.WriteLine("Please enter a valid integer for your score.");
            }

            // Prove 3
            Random randNum = new Random();
            int answer = randNum.Next(1, 11); // Random number between 1 and 10
            int guess = 0;

            while (guess != answer)
            {
                Console.Write("Enter a guess (between 1 and 10): ");
                string guessInput = Console.ReadLine();

                // Ensure valid input
                if (int.TryParse(guessInput, out guess))
                {
                    if (guess < 1 || guess > 10)
                    {
                        Console.WriteLine("Your guess must be between 1 and 10.");
                    }
                    else if (guess < answer)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > answer)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! {guess} is correct!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer.");
                }
            }
        }
    }
}
