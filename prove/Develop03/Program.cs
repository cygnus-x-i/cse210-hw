class Program
{
    static void Main(string[] args)
    {
        string input = "";
        Reference myReference = new();

        string book = "John";
        int chapter = 3;
        int startVerse = 16;
        int endVerse = 16;

        List<string> validResponses = new() { "1", "2", "3" };
        Console.WriteLine("What difficulty level would you like? Select one:\n1. Easy\n2. Normal\n3. Hard");
        string difficulty = Console.ReadLine();

        int loopBreaker = 0;
        while (loopBreaker == 0)
        {
            foreach (string i in validResponses)
            {
                if (difficulty == i)
                {
                    loopBreaker = 1;
                }
            }
            if (loopBreaker == 0)
            {
                Console.WriteLine("Invalid selection. Please choose 1 for Easy, 2 for Normal, or 3 for Hard:");
                difficulty = Console.ReadLine();
            }
        }

        int wordsToHide = 3; // Default to "Easy" level hiding count
        switch (difficulty)
        {
            case "1":
                wordsToHide = 3; // Easy level hides 3 words
                break;
            case "2":
                wordsToHide = 4; // Medium level hides 4 words
                break;
            case "3":
                wordsToHide = 5; // Hard level hides 5 words
                break;
        }

        string verse = "For God so loved the world, that He gave His only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life";

        myReference.SetVerses(verse, book, chapter, startVerse, endVerse);

        Verse myVerse = new(); // Create a new verse object
        myVerse.PrepareVerse(myReference); // Prepare the verse for word hiding

        while (input != "quit")
        {
            Console.Clear(); // Clear the terminal screen

            myVerse.DisplayVerses(myReference); // Display the verse with hidden words

            try
            {
                // Hide words based on difficulty level
                for (int j = 0; j < wordsToHide && myVerse.HasUnhiddenWords();)
                {
                    int result = myVerse.HideWord();
                    if (result == 0) break; // No more words to hide, exit loop
                    j += result;
                }

                // Check if all words are hidden after attempting to hide them
                if (!myVerse.HasUnhiddenWords())
                {
                    Console.Clear();
                    myVerse.DisplayVerses(myReference); // Display the fully hidden verse one last time
                    Console.WriteLine("All words are hidden. Exiting the program.");
                    break;
                }
            }
            catch
            {
                input = "quit";
            }

            // Prompt for next input if not quitting
            if (input != "quit")
            {
                Console.WriteLine("Press Enter to continue, or type quit to exit");
                input = Console.ReadLine().ToLower();
            }
        }
    }
}
