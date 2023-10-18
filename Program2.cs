namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos = 1;
            int pos2 = 1;

            string[][] tasks = new string[][]
            {
                new string[] { "Выбрана дата 06.10.2023", "1. Покушать", "2. Пойти на пары", "3. Сделать практос", "4. Поспать", "5. Второй раз покушать" },
                new string[] { "Выбрана дата 08.10.2023", "1. Проснуться", "2. Пойти на пары", "3. Сделать практос", "4. Покушать", "5. Поспать" },
                new string[] { "Выбрана дата 13.10.2023", "1. Поиграть в комп", "2. Покушать", "3. Поспать", "4. Покормить кота", "5. Попить воды" }
            };

            string[][] taskDetails = new string[][]
            {
                new string[]
                {
                    "Покушать",
                    "----------------",
                    "Описание: картошку с грибами",
                    "Дата: 06.10.2023 07:00:00"
                },
                new string[]
                {
                    "Пойти на пары",
                    "----------------",
                    "Описание: с 1 по 5((",
                    "Дата: 06.10.2023 8:30:00"
                },
                new string[]
                {
                    "Сделать практос",
                    "----------------",
                    "Описание: по питону, удачи!!",
                    "Дата: 06.10.2023 13:30:00"
                },
                new string[]
                {
                    "Поспать",
                    "----------------",
                    "Описание: Сладких снов",
                    "Дата: 06.10.2023 15:30:00"
                },
                new string[]
                {
                    "Второй раз покушать",
                    "----------------",
                    "Описание: приятного аппетита",
                    "Дата: 06.10.2023 16:30:00"
                },
                new string[]
                {
                    "Проснуться",
                    "----------------",
                    "Описание: доброе утро",
                    "Дата: 08.10.2023 07:00:00"
                },
                new string[]
                {
                    "Пойти на пары",
                    "----------------",
                    "Описание: с 1 по 3",
                    "Дата: 08.10.2023 8:30:00"
                },
                new string[]
                {
                    "Сделать практос",
                    "----------------",
                    "Описание: по шарпу, удачи!!",
                    "Дата: 08.10.2023 13:30:00"
                },
                new string[]
                {
                    "Покушать",
                    "----------------",
                    "Описание: суп",
                    "Дата: 08.10.2023 15:30:00"
                },
                new string[]
                {
                    "Поспать",
                    "----------------",
                    "Описание: сладких снов",
                    "Дата: 08.10.2023 21:30:00"
                },
                new string[]
                {
                    "Поиграть в комп",
                    "----------------",
                    "Описание: в доту",
                    "Дата: 13.10.2023 07:00:00"
                },
                new string[]
                {
                    "Покушать",
                    "----------------",
                    "Описание: плов",
                    "Дата: 13.10.2023 8:30:00"
                },
                new string[]
                {
                    "Поспать",
                    "----------------",
                    "Описание: 2 часа",
                    "Дата: 13.10.2023 13:30:00"
                },
                new string[]
                {
                    "Покормить кота",
                    "----------------",
                    "Описание: 50гр",
                    "Дата: 13.10.2023 16:30:00"
                },
                new string[]
                {
                    "Попить воды",
                    "----------------",
                    "Описание: 2 стакана",
                    "Дата: 13.10.2023 21:30:00"
                }
            };

            while (true)
            {
                Console.Clear();

                if (pos >= 1 && pos <= tasks.Length)
                {
                    string[] nowTasks = tasks[pos - 1];

                    for (int i = 0; i < nowTasks.Length; i++)
                    {
                        string task = nowTasks[i];

                        if (i + 1 == pos2)
                        {
                            Console.WriteLine("-> " + task);
                        }
                        else
                        {
                            Console.WriteLine("   " + task);
                        }
                    }

                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.UpArrow && pos2 != 1)
                    {
                        pos2--;
                    }
                    else if (key.Key == ConsoleKey.DownArrow && pos2 != nowTasks.Length)
                    {
                        pos2++;
                    }
                    else if (key.Key == ConsoleKey.LeftArrow && pos > 1)
                    {
                        pos--;
                        pos2 = 1;
                    }
                    else if (key.Key == ConsoleKey.RightArrow && pos < tasks.Length)
                    {
                        pos++;
                        pos2 = 1;
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();

                        string[] selectedTaskDetails = taskDetails[(pos - 1) * (nowTasks.Length - 1) + pos2 - 2];
                        foreach (string detail in selectedTaskDetails)
                        {
                            Console.WriteLine(detail);
                        }

                        Console.ReadKey();
                    }
                }
            }
        }
    }
}