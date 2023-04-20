using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Написать программу, которая будет выполняться до тех пор, пока не будет введено слово exit.
    Помните, в цикле должно быть условие, которое отвечает за то, когда цикл должен завершиться.
    Это нужно, чтобы любой разработчик взглянув на ваш код, понял четкие границы вашего цикла.
 */

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool commandStartProgramm = true;

            while (commandStartProgramm)
            {
                Console.WriteLine("Введите команду(/help - для получения справки.): ");
                string command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "/help":
                        Console.WriteLine("/hacked - взломать пентагон. \n/offworldinternet - отключить всемирный интернет. \n/reloadworld - перезапуск земли. \n/clear - очистка окна. \n/exit - выйти из программы.");
                        break;
                    case "/hacked":
                        Console.WriteLine("Пентагон взломан все необходимые данные вы можите найти в очищеной корзине =)");
                        break;
                    case "/offworldinternet":
                        Console.WriteLine("Интернет отключен во всем мире. Не возможно соедениться с сервером для передачи команд...");
                        break;
                    case "/reloadworld":
                        Console.WriteLine("Мир перезагружен все началось с начала. Соответственно вас больше не существет досвидания!");
                        Console.WriteLine("Ваш компьютер самоуничтожится по нажатии любой клавиши =D");
                        Console.ReadKey();
                        break;
                    case "/clear":
                        Console.Clear();
                        Console.WriteLine("Окно приложения очищено.");
                        break;
                    case "/exit":
                        commandStartProgramm = false;
                        break;
                    default:
                        Console.WriteLine("Вы ввели не верную команду. Воспользуйтесь справкой(/help)");
                        break;
                }
            }
            Console.WriteLine("Для выхода нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
