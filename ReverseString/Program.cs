namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Introduction text
            Console.WriteLine("Welcome to the Reverse String Program. Enter a word, and I will give it to you in reverse!");

            // Ask for user input
            Console.WriteLine("Please enter a word: ");
            string userInput = Console.ReadLine();

            // Declar a charater array so we can iterate through the string 
            char[] reversed = new char[userInput.Length];

            // Fill the charater array with the reverse user input
            for (int i = 0; i < userInput.Length; i++)
            {
                reversed[i] = userInput[userInput.Length - i - 1];
            }

            // Turn the character array into a string to be printed
            string result = new string(reversed);

            // Output reversed string
            Console.WriteLine($"The reversed string is: {result}");

            // Check for Palindrome
            if (userInput == result)
            {
                Console.WriteLine("This is a Palindrome!");
            }
        }
    }
}
