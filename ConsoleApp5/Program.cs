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

    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    enum Colors
    {
        Red,
        Green,
        Blue
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //foreach (string day in Enum.GetNames(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            //Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
            //string userInput = Console.ReadLine();

            //if (Enum.TryParse(userInput, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season name.");
            //}


            
            Permissions userPermissions = Permissions.None;

            

            userPermissions |= Permissions.Read;
            userPermissions |= Permissions.Write;

            userPermissions &= ~Permissions.Write;

            
            if ((userPermissions & Permissions.Read) == Permissions.Read)
            {
                Console.WriteLine("Read permission is granted.");
            }
            else
            {
                Console.WriteLine("Read permission is not granted.");
            }

            if ((userPermissions & Permissions.Write) == Permissions.Write)
            {
                Console.WriteLine("Write permission is granted.");
            }
            else
            {
                Console.WriteLine("Write permission is not granted.");
            }

            
            Console.WriteLine($"Current permissions: {userPermissions}");

            Console.WriteLine("Enter a color name (Red, Green, Blue):");
            string colorInput = Console.ReadLine();

            if (Enum.TryParse(colorInput, true, out Colors color))
            {
                switch (color)
                {
                    case Colors.Red:
                    case Colors.Green:
                    case Colors.Blue:
                        Console.WriteLine($"{color} is a primary color.");
                        break;
                    default:
                        Console.WriteLine($"{color} is not a primary color.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid color name.");
            }
        }
    }
}
