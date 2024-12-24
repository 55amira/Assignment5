namespace ConsoleApp5
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }


    internal class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        static void Main(string[] args)
        {
            foreach (string day in Enum.GetNames(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
            string userInput = Console.ReadLine();

            if (Enum.TryParse(userInput, true, out Season season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid season name.");
            }
        }
    }
}
