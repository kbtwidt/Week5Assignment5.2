namespace Week5Assignment5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");
            Console.Write("Enter a sentence: ");
            string[] inputString = Console.ReadLine().TrimEnd('.').Split(' ');
            string lastWord = inputString[inputString.Length - 1];
            Console.WriteLine($"The last word is \"{inputString[inputString.Length - 1]}\" with a length of {lastWord.Length}");

            Console.WriteLine("\nPart 2\n");
            NaturalRecursion(10);

            Console.WriteLine("\nPart 3\n");
            ReverseRecusion(10);

            Console.WriteLine("\nPart 4\n");
            Console.Write("Enter a word to check if it is a palindrome: ");
            string input = Console.ReadLine().ToLower();
            if (IsPalindrome(input, 0, input.Length - 1))
                Console.WriteLine($"{input} is a palindrome");
            else
                Console.WriteLine($"{input} is not a palindrome");
        }

        static void NaturalRecursion(int num)
        {
            if (num > 1)
            {
                NaturalRecursion(num - 1);
            }
            Console.Write(num + " ");
        }

        static void ReverseRecusion(int num)
        {
            Console.Write(num + " ");
            if (num > 1)
            {
                ReverseRecusion(num - 1);
            }
        }

        static bool IsPalindrome(string str, int left, int right)
        { 
            if (left >= right) return true;
            if (str[left] != str[right]) return false;
            return IsPalindrome(str,left + 1,right - 1);
        }
    }
}
