const string CommandCoin = "PlayCoin";
const string CommandChangePassword = "SetPassword";
const string CommandChangeColor = "ChangeCharColor";
const string CommandCalculator = "Calculator";
const int Eagle = 0;
const int Tails = 1;
const int MinCoinNumber = 0;
const int MaxCoinNumber = 2;
const string colorRed = "Red";
const string colorGreen = "Green";
const string colorWhite = "White";
const string commandExit = "yes";
const string sum = "+";
const string subtraction = "-";
const string divide = "/";
const string multiply = "*";
const string moduleDivide = "%";

Random rand = new Random();
string choiceInCoin, password, choiseColor, inputExit;
int coinSide;
float conclusion, number1, number2;
string action;

Console.WriteLine("Желаете войти в программу? Введите yes, если да.");
inputExit = Console.ReadLine();

if (inputExit == "yes")
{
    Console.WriteLine("Добро пожаловать в моё приложение.");
    while (commandExit == inputExit)
    {
        Console.WriteLine($"Что вы хотите сделать?\n\n{CommandCoin} - игра в монетку\n{CommandChangePassword} - установить пароль" +
        $"\n{CommandChangeColor} - изменить цвет всех символов\n{CommandCalculator} - начать работу в калькуляторе(Пока доступно действие только с двумя числами).");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case CommandCoin:
                Console.WriteLine("Орел или решка?");
                choiceInCoin = Console.ReadLine();
                coinSide = rand.Next(MinCoinNumber, MaxCoinNumber);

                if (coinSide == Eagle)
                {
                    Console.WriteLine("Вам выпал Орел.");
                }
                else if (coinSide == Tails)
                {
                    Console.WriteLine("Вам выпала Решка.");
                }

                break;

            case CommandChangePassword:
                Console.WriteLine("Введите свой пароль.");
                password = Console.ReadLine();
                break;

            case CommandChangeColor:
                Console.WriteLine("Пока что доступно только 3 цвета: зеленый(введите Green), красный(введите Red), а так же классический белый(введите White)");
                choiseColor = Console.ReadLine();
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
                Console.WriteLine("Введите 1 число:");
                number1 = Console.Read();
                Console.WriteLine("Введите действие:");
                action = Console.ReadLine();
                Console.WriteLine("Введите 3 число:");
                number2 = Console.Read();
                switch (action)
                {
                    case sum:
                        conclusion = number1 + number2;
                        Console.WriteLine(conclusion); 
                        break;
                    case subtraction:
                        conclusion = number1 - number2;
                        Console.WriteLine(conclusion);
                        break;
                    case divide:
                        conclusion = number1 / number2;
                        Console.WriteLine(conclusion);
                        break;
                    case multiply:
                        conclusion = number1 * number2;
                        Console.WriteLine(conclusion);
                        break;
                    case moduleDivide:
                        conclusion = number1 * number2;
                        Console.WriteLine(conclusion);
                        break;
                }

                break;
                default:
                Console.WriteLine("Такой команды не существует!!!");
                break;
        }
        Console.Clear();
        Console.WriteLine("Напишите yes для повторного входа в приложение,");
        inputExit = Console.ReadLine();
    }
}
else if(inputExit != "yes")
{
    Console.WriteLine("Заходите в следующий раз!");
}