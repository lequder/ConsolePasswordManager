class Program
{
    static void Main(string[] args)
    {
        bool whileBool = true;
        while (whileBool)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("Welcome to Console Password Manager!");
            Console.WriteLine("************************************");

            Console.WriteLine("\nSelect an action:");
            Console.WriteLine("\n---------------------");
            Console.WriteLine("1 - Open base");
            Console.WriteLine("---------------------");
            Console.WriteLine("2 - Create base");
            Console.WriteLine("---------------------");
            Console.WriteLine("3 - Generate password");
            Console.WriteLine("---------------------");
            Console.WriteLine("4 - Exit");
            Console.WriteLine("---------------------");
            Console.Write("\nChoice - ");
            int choice = Convert.ToInt32(Console.ReadLine());

            PasswordGenerator passwordGenerator = new PasswordGenerator();

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();

                    break;
                case 3:
                    Console.Clear();
                    passwordGenerator.PassGen();
                    break;
                case 4:
                    Console.Clear();
                    whileBool = false;
                    break;
                default:
                    Console.WriteLine("Error: non-existing action selected");
                    break;
            }
        }
    }
}