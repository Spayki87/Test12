using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ковертор_валют
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandBuyUsdToEur = "1";
            const string CommandBuyUsdToRub = "2";
            const string CommandBuyEurToUsd = "3";
            const string CommandBuyEurToRub = "4";
            const string CommandBuyRubToUsd = "5";
            const string CommandBuyRubToEur = "6";
            const string CommandExit = "7";

            float usdValue;
            float eurValue;
            float rubValue;
            float usdToEur = 0.915F;
            float usdToRub = 106.5F;
            float eurToUsd = 1.092F;
            float eurToRub = 116.4F;
            float rubToUsd = 0.2293545F;
            float rubToEur = 0.0083822F;
            float currencyCount;
            string userInput;
            bool isExitFromExchange = true;

            Console.WriteLine("Добро пожаловать в обменник валют");
            Console.Write("Введите баланс долларов: ");
            usdValue = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс евро: ");
            eurValue = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс рублей: ");
            rubValue = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("У нас вы можете обменять:");

            while (isExitFromExchange == true)
            {
                Console.WriteLine(CommandBuyUsdToEur + " - доллары на евро");
                Console.WriteLine(CommandBuyUsdToRub + " - доллары на рубли");
                Console.WriteLine(CommandBuyEurToUsd + " - евро на доллары");
                Console.WriteLine(CommandBuyEurToRub + " - евро на рубли");
                Console.WriteLine(CommandBuyRubToUsd + " - рубли на доллары");
                Console.WriteLine(CommandBuyRubToEur + " - рубли на евро");
                Console.WriteLine(CommandExit + " - Если хотите выйти из обменника");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandBuyUsdToEur:
                        Console.WriteLine("Обмен доллары на евро");
                        Console.Write("Сколько вы хотите обменять ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (usdValue >= currencyCount)
                        {
                            usdValue -= currencyCount;
                            eurValue += currencyCount * usdToEur;
                        }
                        else
                        {
                            Console.WriteLine("Не допустимое количество долларов.");
                        }
                        break;

                    case CommandBuyUsdToRub:
                        Console.WriteLine("Обмен доллары на рубли");
                        Console.Write("Сколько вы хотите обменять ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (usdValue >= currencyCount)
                        {
                            usdValue -= currencyCount;
                            rubValue += currencyCount * usdToRub;
                        }
                        else
                        {
                            Console.WriteLine("Не допустимое количество долларов.");
                        }
                        break;

                    case CommandBuyEurToUsd:
                        Console.WriteLine("Обмен евро на доллары");
                        Console.Write("Сколько вы хотите обменять ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (eurValue >= currencyCount)
                        {
                            eurValue -= currencyCount;
                            usdValue += currencyCount * eurToUsd;
                        }
                        else
                        {
                            Console.WriteLine("Не допустимое количество евро.");
                        }
                        break;

                    case CommandBuyEurToRub:
                        Console.WriteLine("Обмен евро на рубли");
                        Console.Write("Сколько вы хотите обменять ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (eurValue >= currencyCount)
                        {
                            eurValue -= currencyCount;
                            rubValue += currencyCount * eurToRub;
                        }
                        else
                        {
                            Console.WriteLine("Не допустимое количество евро.");
                        }
                        break;

                    case CommandBuyRubToUsd:
                        Console.WriteLine("Обмен рубли на доллары");
                        Console.Write("Сколько вы хотите обменять ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (rubValue >= currencyCount)
                        {
                            rubValue -= currencyCount;
                            usdValue += currencyCount * rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine("Не допустимое количество рублей.");
                        }
                        break;

                    case CommandBuyRubToEur:
                        Console.WriteLine("Обмен рубли на евро");
                        Console.Write("Сколько вы хотите обменять ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (rubValue >= currencyCount)
                        {
                            rubValue -= currencyCount;
                            eurValue += currencyCount * rubToEur;
                        }
                        else
                        {
                            Console.WriteLine("Не допустимое количество рублей.");
                        }
                        break;

                    case CommandExit:
                        isExitFromExchange = false;
                        Console.WriteLine("Вы вышли из обменника.");
                        break;
                }

                Console.WriteLine($"У вас на балансе {usdValue} долларов, {eurValue} евро, {rubValue} рублей");
            }
        }
    }
}
