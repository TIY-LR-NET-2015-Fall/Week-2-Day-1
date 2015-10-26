   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers seperated by a space");
            string input = Console.ReadLine();

            char[] charactersToSplitOn = new char[] { ' ' };
            string[] splits = input.Split(charactersToSplitOn);
            int[] numbers = ConvertToNumbers(splits);

            double biggestNumber = numbers.Sum();


            Console.WriteLine($"The biggest number was {biggestNumber}");
            Console.ReadLine();
        }

        private static int[] ConvertToNumbers(string[] splits)
        {
            return splits.Select(x => int.Parse(x)).ToArray();
        }
    }
