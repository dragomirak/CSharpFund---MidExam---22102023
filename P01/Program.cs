namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());
            double totalExperience = 0;

            for (int i = 1; i <= countOfBattles; i++)
            {
                double experiencePerBattle = double.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    experiencePerBattle *= 1.15;
                }

                if (i % 5 == 0)
                {
                    experiencePerBattle *= 0.90;
                }

                if (i % 15 == 0)
                {
                    experiencePerBattle *= 1.05;
                }

                totalExperience += experiencePerBattle;

                if (totalExperience >= neededExperience)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }

            }

            Console.WriteLine($"Player was not able to collect the needed experience, {(neededExperience - totalExperience):f2} more needed.");
        }
    }
}