using System.Runtime.CompilerServices;

namespace Calculator
{
    internal class StartUp
    {
        private static bool CheckCredentials()
        {
            Console.Write("Enter password to gain access: ");
            string password = Console.ReadLine();
            Console.Clear();
            return password == Password;
        }
        private const string Password = "abcd1234";
        static void Main(string[] args)
        {
            bool isAuthorised = CheckCredentials();
            if (!isAuthorised) 
            {
                Console.WriteLine("Access denied.");
                Console.ReadKey(intercept: true);
                return;
            }
            Console.WriteLine("Console Calculatro App");
            Console.WriteLine(new string(c:'-', count:15));
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Console Calculator App");
                Console.WriteLine(new string('-', 15));

                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.WriteLine("Choose one from the listed options:");
                foreach (string option in OptionsManager.OptionsList)
                {
                    Console.WriteLine($"\t{option}");
                }
                try
                {
                    Console.Write("Option: ");
                    string choice = Console.ReadLine();

                    if (choice == "ex")
                    {
                        break;
                    }
                    switch (choice)
                    {
                        case "a":
                            OptionsManager.Add(a, b);
                            break;
                        case "s":
                           OptionsManager.Subtract(a, b);
                            break;
                        case "m":
                           OptionsManager.Multiply(a, b);
                            break;
                        case "d":
                            OptionsManager.Divide(a, b);
                            break;
                        case "sabs":
                            OptionsManager.SubtractAbs(a, b);
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            }
        }
    }
}
