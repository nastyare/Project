using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //направление-авиакомпании-даты-билеты
            List<string> directions = new List<string>() { "Москва-Дубай", "Москва-Сеул", "Москва-Токио" };
            List<string> airlines = new List<string>() { "S7 Airlines", "Победа", "Аэрофлот" };
            Dictionary<string, List<DateTime>> datesByDirection = new Dictionary<string, List<DateTime>>()
            {
                { "Москва-Дубай", new List<DateTime>() { new DateTime(2023, 6, 1), new DateTime(2023, 6, 8), new DateTime(2023, 6, 15) } },
                { "Москва-Сеул", new List<DateTime>() { new DateTime(2023, 6, 2), new DateTime(2023, 6, 9), new DateTime(2023, 6, 16) } },
                { "Москва-Токио", new List<DateTime>() { new DateTime(2023, 6, 3), new DateTime(2023, 6, 10), new DateTime(2023, 6, 17) } }
            };
            TicketFactory EconomyTicket = new EconomyTicketFactory();
            TicketFactory BusinessTicket = new BusinessTicketFactory();
            
            //менюшка
            Console.WriteLine("Выберите тип билета:");
            Console.WriteLine("1 - Эконом-класс");
            Console.WriteLine("2 - Бизнес-класс");
            int ticketType = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите направление:");
            for (int i = 0; i < directions.Count; ++i)
            {
                Console.WriteLine($"{i + 1} - {directions[i]}");
            }
            int directionIndex = int.Parse(Console.ReadLine()) - 1;
            string direction = directions[directionIndex];

            Console.WriteLine("Выберите дату:");
            List<DateTime> dates = datesByDirection[direction];
            for (int i = 0; i < dates.Count; ++i)
            {
                Console.WriteLine($"{i + 1} - {dates[i]:dd.MM.yyyy}");
            }
            int dateIndex = int.Parse(Console.ReadLine()) - 1;
            DateTime date = dates[dateIndex];
            
            Console.WriteLine("Выберите авиакомпанию:");
            for (int i = 0; i < airlines.Count; ++i)
            {
                Console.WriteLine($"{i + 1} - {airlines[i]}");
            }
            int airlineIndex = int.Parse(Console.ReadLine()) - 1;
            string airline = airlines[airlineIndex];

            Ticket ticket;
            if (ticketType == 1)
            {
                ticket = economyTicketFactory.CreateTicket(direction, date, airline);
            }
            else if (ticketType == 2)
            {
                ticket = businessTicketFactory.CreateTicket(direction, date, airline);
            }
            else
            {
                Console.WriteLine("Неверный тип билета.");
                return;
            }
        }
    }
}
