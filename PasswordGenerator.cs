class PasswordGenerator
{
    public void PassGen()
    {
        string listChar = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789#$%&@^`~.,:;<>*+!?=";
        string useChar = "";
        bool whileBool = true;
        string password = "";
        int passLenght = 0;
        Random rand = new Random();

        while (whileBool) //Set Password Length
        {
            Console.WriteLine("Enter the length of the password (max 50): ");
            passLenght = Convert.ToInt32(Console.ReadLine());

            if (passLenght <= 0 || passLenght > 50)
            {
                Console.Clear();
                Console.WriteLine("Error: length > 50 or length < 1\n");
            }
            else
            {
                Console.Clear();
                break;
            }
        }

        while (whileBool) //Ask about upper case
        {
            Console.WriteLine("Use A-Z\n");
            Console.WriteLine("1 - yes");
            Console.WriteLine("2 - no");
            Console.Write("\nChoice - ");

            int useUpperCase = Convert.ToInt32(Console.ReadLine());

            switch (useUpperCase)
            {
                case 1:
                    for (int i = 0; i < 25; i++)
                    {
                        useChar += listChar[i];
                    }
                    whileBool = false;
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    whileBool = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error: non-existing action selected\n");
                    break;
            }
        }

        whileBool = true;
        while (whileBool)
        {
            Console.WriteLine("Use a-z\n");
            Console.WriteLine("1 - yes");
            Console.WriteLine("2 - no");
            Console.Write("\nChoice - ");

            int useLowerCase = Convert.ToInt32(Console.ReadLine());

            switch (useLowerCase)
            {
                case 1:
                    for (int i = 25; i < 51; i++)
                    {
                        useChar += listChar[i];
                    }
                    whileBool = false;
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    whileBool = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error: non-existing action selected\n");
                    break;
            }
        }

        whileBool = true;
        while (whileBool)
        {
            Console.WriteLine("Use 0-9\n");
            Console.WriteLine("1 - yes");
            Console.WriteLine("2 - no");
            Console.Write("\nChoice - ");

            int useDigit = Convert.ToInt32(Console.ReadLine());

            switch (useDigit)
            {
                case 1:
                    for (int i = 51; i < 61; i++)
                    {
                        useChar += listChar[i];
                    }
                    whileBool = false;
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    whileBool = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error: non-existing action selected\n");
                    break;
            }
        }

        whileBool = true;
        while (whileBool)
        {
            Console.WriteLine("Use #$%&@^`~\n");
            Console.WriteLine("1 - yes");
            Console.WriteLine("2 - no");
            Console.Write("\nChoice - ");

            int useSpecialCharacters = Convert.ToInt32(Console.ReadLine());

            switch (useSpecialCharacters)
            {
                case 1:
                    for (int i = 61; i < 69; i++)
                    {
                        useChar += listChar[i];
                    }
                    whileBool = false;
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    whileBool = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error: non-existing action selected\n");
                    break;
            }
        }

        whileBool = true;
        while (whileBool)
        {
            Console.WriteLine("Use .,:;\n");
            Console.WriteLine("1 - yes");
            Console.WriteLine("2 - no");
            Console.Write("\nChoice - ");

            int usePunctuationMarks = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (usePunctuationMarks)
            {
                case 1:
                    for (int i = 69; i < 73; i++)
                    {
                        useChar += listChar[i];
                    }
                    whileBool = false;
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    whileBool = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error: non-existing action selected\n");
                    break;
            }
        }

        whileBool = true;
        while (whileBool)
        {
            Console.WriteLine("Use <>*+!?=\n");
            Console.WriteLine("1 - yes");
            Console.WriteLine("2 - no");
            Console.Write("\nChoice - ");

            int useMathSymbols = Convert.ToInt32(Console.ReadLine());

            switch (useMathSymbols)
            {
                case 1:
                    for (int i = 73; i < 80; i++)
                    {
                        useChar += listChar[i];
                    }
                    whileBool = false;
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    whileBool = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error: non-existing action selected\n");
                    break;
            }
        }
    loop1:
        for (int i = 0; i <= passLenght; i++)
        {
            password += useChar[rand.Next(0, useChar.Length)];
        }
    loop2:
        Console.WriteLine($"Password: {password}\n");

        Console.WriteLine("Select an action:");
        Console.WriteLine("1 - regenerate");
        Console.WriteLine("2 - exit");
        Console.Write("\nChoice - ");
        int selectAction = Convert.ToInt32(Console.ReadLine());

        switch (selectAction)
        {
            case 1:
                password = "";
                Console.Clear();
                goto loop1;
            case 2:
                Console.Clear();
                return;
            default:
                Console.Clear();
                Console.WriteLine("Error: non-existing action selected\n");
                goto loop2;

        }

    }
}