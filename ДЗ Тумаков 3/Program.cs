using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ДЗ_Тумаков_3
{   // Упражнение 3.1 - Создать перечислимый тип данных и создать переменную типа перечисления и печать
    enum Bank
    {
        Current,
        Savings
    }
    internal class Program
    {
        // Упражнение 3.2 Структура данных, в котором инф. о банк.счете - номер,тип,баланс
        struct Account
        {
            public long Number;
            public string Type;
            public int Balance;
            public void Print()
            {
                Console.WriteLine($"Номер счета: {Number}\nТип счета: {Type}\nБаланс: {Balance}");
            }
        }
        enum Vuz
        {
            KGU,
            KAI,
            KHTI
        }
        struct Worker
        {
            public string Name;
            public Vuz Vuz;
            public void Print()
            {
                Console.WriteLine($"Имя: {Name}\nВУЗ: {Vuz}");
            }
        }

        static void Main(string[] args)
        {
            // Упражнение 3.1 продолжение
            Console.WriteLine("Упражнение 3.1 - Создать перечислимый тип данных и создать переменную типа перечисления и печать\n");
            Bank first = Bank.Current;
            Bank second = Bank.Savings;
            Console.WriteLine("Первый счет - " + first);
            Console.WriteLine("Второй счет - " + second);
            Thread.Sleep(5000);

            // Упражнение 3.2 - Создать структуру данных, которая хранит инф. о банк. счете - номер,тип,баланс
            Console.WriteLine("\nУпражнение 3.2 - Создать структуру данных, которая хранит инф. о банк. счете - номер,тип,баланс\n");
            Account account = new Account();
            account.Number = 1111222233334444;
            account.Type = "Current";
            account.Balance = 123456;
            account.Print();
            Thread.Sleep(5000);

            // Упражнение 3.3 - Создать пречислимый вуз(КГУ,КАИ,КХТИ), структуру работника: Имя,вуз
            Console.WriteLine("\nУпражнение 3.3 - Создать пречислимый вуз(КГУ,КАИ,КХТИ), структуру работника: Имя,вуз\n");
            Worker worker = new Worker();
            worker.Name = "Андрей";
            worker.Vuz = 0;
            worker.Print();
        }
    }
}
