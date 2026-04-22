namespace LR4.Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var doubleNumbers = new List<double> { 1.5, 2.5, 3.5, 4.5, 5.5 };
            var strings = new List<string> { "   ", "Apple", "Banana", "cherry", "Date", "elderberry" };
            var sentence = "Sometimes to understand a word's meaning you need more than a definition";
            var oddNumbers = GetOddNumbers(numbers);
            Console.WriteLine("1. Odd Numbers: " + string.Join(", ", oddNumbers));
            var average = GetAverage(doubleNumbers);
            Console.WriteLine("2. Average: " + average);
            var sortedStrings = SortByAlphabet(strings);
            Console.WriteLine("3. Sorted Strings: " + string.Join(", ", sortedStrings));
            var sumEven = SumOfEvenNumbers(numbers);
            Console.WriteLine("4. Sum of Even Numbers: " + sumEven);
            var factorial = CalculateFactorial(5);
            Console.WriteLine("5. Factorial of 5: " + factorial);
            var SumAndMultiplyResult = SumAndMultiply(numbers);
            Console.WriteLine("6. Sum: " + SumAndMultiplyResult.sum + ", Multiply: " + SumAndMultiplyResult.multiply);
            var squares = CaluclateSquares(numbers);
            Console.WriteLine("7. Squares: " + string.Join(", ", squares));
            var sortedByLength = SortByLength(strings);
            Console.WriteLine("8. Sorted by Length: " + string.Join(", ", sortedByLength));
            var wordCount = CalculateCountOfWords(sentence);
            Console.WriteLine("9. Total Word Count: " + wordCount);
            var firstNonEmpty = GetFirstNonEmptyString(strings);
            Console.WriteLine("10. First Non-Empty String: " + firstNonEmpty);
            var allStartsWithCapital = CheckAllStartsWithCapital(strings);
            Console.WriteLine("11. All Start With Capital: " + allStartsWithCapital);
            var secondLargest = GetSecondLargestNumber(numbers);
            Console.WriteLine("12. Second Largest Number: " + secondLargest);
            var mostEven = GetMostEvenNumber(numbers);
            Console.WriteLine("13. Most Even Number: " + mostEven);
        }
        public static List<int> GetOddNumbers(List<int> numbers)
        {
            return numbers.Where(n => n % 2 != 0).ToList();
        }
        public static double GetAverage(List<double> numbers)
        {
            return numbers.Average();
        }
        public static List<string> SortByAlphabet(List<string> strings)
        {
            return strings.OrderBy(s => s).ToList();
        }
        public static int SumOfEvenNumbers(List<int> numbers)
        {
            return numbers.Where(n => n % 2 == 0).Sum();
        }
        public static int CalculateFactorial(int number)
        {
            return Enumerable.Range(1, number).Aggregate(1, (acc, n) => acc * n);
        }
        public static (int sum, int multiply) SumAndMultiply(List<int> numbers)
        {
            int sum = numbers.Sum();
            int multiply = numbers.Aggregate(1, (acc, n) => acc * n);
            return (sum, multiply);
        }
        public static List<int> CaluclateSquares(List<int> numbers)
        {
            return numbers.Select(n => n * n).ToList();
        }
        public static List<string> SortByLength(List<string> strings)
        {
            return strings.OrderBy(s => s.Length).ToList();
        }
        public static int CalculateCountOfWords(string input)
        {
            var wordCount = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Count();
            return wordCount;
        }
        public static string GetFirstNonEmptyString(List<string> strings)
        {
            return strings.FirstOrDefault(s => !string.IsNullOrWhiteSpace(s)) ?? "All strings are empty";
        }
        public static bool CheckAllStartsWithCapital(List<string> strings)
        {
            return strings.All(s => !string.IsNullOrWhiteSpace(s) && char.IsUpper(s[0]));
        }
        public static int GetSecondLargestNumber(List<int> numbers)
        {
            return numbers.OrderByDescending(n => n).Distinct().Skip(1).FirstOrDefault();
        }
        public static int GetMostEvenNumber(List<int> numbers)
        {
            return numbers.Where(n => n % 2 == 0)
                          .Max();
        }
    }
}
