const string CommandCoin = "PlayCoin";
const string CommandChangePassword = "SetPassword";
const string CommandChangeColor = "ChangeCharColor";
const string CommandCalculator = "Calculator";
const string CommandExit = "Exit";

string inputExit = "";

Console.WriteLine("Добро пожаловать в моё приложение.");

while (CommandExit != inputExit)
{
    Console.WriteLine($"Что вы хотите сделать?\n\n{CommandCoin} - игра в монетку\n{CommandChangePassword} - установить пароль" +
    $"\n{CommandChangeColor} - изменить цвет всех символов\n{CommandCalculator} - начать работу в калькуляторе(Пока доступно действие только с двумя числами)" +
    $"\nНапишите {CommandExit}, если хотите выйти из программы.");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case CommandCoin:
            int eagle = 0;
            int tails = 1;
            int minCoinNumber = 0;
            int maxCoinNumber = 2;

            Random rand = new Random();
            int coinSide;

            Console.WriteLine("Орел или решка?");
            Console.ReadLine();
            coinSide = rand.Next(minCoinNumber, maxCoinNumber);

            if (coinSide == eagle)
            {
                Console.WriteLine("Вам выпал Орел.");
            }
            else if (coinSide == tails)
            {
                Console.WriteLine("Вам выпала Решка.");
            }
            Console.ReadLine();
            break;

        case CommandChangePassword:
            Console.WriteLine("Введите свой пароль.");
            string password = Console.ReadLine();
            break;

        case CommandChangeColor:
            string colorRed = "Red";
            string colorGreen = "Green";
            string colorWhite = "White";

            Console.WriteLine($"Пока что доступно только 3 цвета: зеленый(введите {colorGreen}), красный(введите {colorRed}), а так же классический белый(введите {colorWhite})");
            string choiseColor = Console.ReadLine();

            if (choiseColor == colorGreen)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (choiseColor == colorWhite)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (choiseColor == colorRed)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            break;

        case CommandCalculator:
            const string SymbolSum = "+";
            const string SymbolSubtraction = "-";
            const string SymbolDivide = "/";
            const string SymbolMultiply = "*";
            const string SymbolModuleDivide = "%";

            float number1;
            float number2;
            string action;
            float conclusion;

            Console.WriteLine("Введите 1 число:");
            number1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите действие:");
            action = Console.ReadLine();

            Console.WriteLine("Введите 3 число:");
            number2 = Convert.ToSingle(Console.ReadLine());

            switch (action)
            {
                case SymbolSum:
                    conclusion = number1 + number2;
                    Console.WriteLine($"Ваш ответ: {conclusion}");
                    break;

                case SymbolSubtraction:
                    conclusion = number1 - number2;
                    Console.WriteLine($"Ваш ответ: {conclusion}");
                    break;

                case SymbolDivide:
                    conclusion = number1 / number2;
                    Console.WriteLine($"Ваш ответ: {conclusion}");
                    break;

                case SymbolMultiply:
                    conclusion = number1 * number2;
                    Console.WriteLine($"Ваш ответ: {conclusion}");
                    break;

                case SymbolModuleDivide:
                    conclusion = number1 * number2;
                    Console.WriteLine($"Ваш ответ: {conclusion}");
                    break;
            }
            Console.ReadLine();
            break;

        case CommandExit:
            inputExit = CommandExit;
            break;

        default:
            Console.WriteLine("Вы выбрали неизвестную команду!");
            Console.ReadLine();
            break;

    }

    Console.Clear();
}