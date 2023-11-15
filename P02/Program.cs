namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] instructions = input.Split(" ");
                string command = instructions[0];
                int value = int.Parse(instructions[1]);

                if (command == "Add")
                {
                    numbers.Add(value);
                }
                else if (command == "Remove")
                {
                    if (numbers.Contains(value))
                    {
                        numbers.Remove(value);
                    }
                }
                else if (command == "Replace")
                {
                    int replacement = int.Parse(instructions[2]);

                    if (numbers.Contains(value))
                    {
                        int index = numbers.IndexOf(value);
                        numbers[index] = replacement;
                    }
                }
                else if (command == "Collapse")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < value)
                        {
                            numbers.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}