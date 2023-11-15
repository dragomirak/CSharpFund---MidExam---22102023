namespace P03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ").ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] instructions = input.Split(" - ");
                string command = instructions[0];

                if (command == "Add")
                {
                    string phone = instructions[1];
                    if (phones.Contains(phone) == false)
                    {
                        phones.Add(phone);
                    }
                }
                else if (command == "Remove")
                {
                    string phone = instructions[1];
                    if (phones.Contains(phone) == true)
                    {
                        phones.Remove(phone);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Bonus phone")
                {
                    string[] oldAndNewPhones = instructions[1].Split(":");
                    string oldPhone = oldAndNewPhones[0];
                    string newPhone = oldAndNewPhones[1];

                    if (phones.Contains(oldPhone))
                    {
                        int index = phones.IndexOf(oldPhone);
                        if (index == phones.Count - 1)
                        {
                            phones.Add(newPhone);
                        }
                        else
                        {
                            phones.Insert(index + 1, newPhone);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Last")
                {
                    string phone = instructions[1];
                    if (phones.Contains(phone) == true)
                    {
                        int index = phones.IndexOf(phone);
                        string phoneToAdd = phones[index];
                        phones.Remove(phone);
                        phones.Add(phoneToAdd);
                    }
                    else
                    {
                        continue;
                    }

                }

            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}