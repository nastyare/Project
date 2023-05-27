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
        }
    }
}
