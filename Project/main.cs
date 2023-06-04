using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //направление-авиакомпании-даты-билеты
            List<string> Directions = new List<string>() { "Москва-Дубай", "Москва-Сеул", "Москва-Токио" };
            List<string> Airlines = new List<string>() { "S7 Airlines", "Победа", "Аэрофлот" };
            Dictionary<string, List<DateTime>> DatesByDirection = new Dictionary<string, List<DateTime>>()
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
            int TicketType = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите направление:");
            for (int DirectionIndex = 0; DirectionIndex < Directions.Count; ++DirectionIndex)
            {
                Console.WriteLine($"{DirectionIndex + 1} - {directions[DirectionIndex]}");
            }
            int DirectionIndex = int.Parse(Console.ReadLine()) - 1;
            string Direction = Directions[d\DirectionIndex];

            Console.WriteLine("Выберите дату:");
            List<DateTime> Dates = DatesByDirection[Direction];
            for (int DataIndex = 0; DataIndex < Dates.Count; ++DataIndex)
            {
                Console.WriteLine($"{DataIndex + 1} - {Dates[DataIndex]:dd.MM.yyyy}");
            }
            int DateIndex = int.Parse(Console.ReadLine()) - 1;
            DateTime Date = Dates[DateIndex];
            
            Console.WriteLine("Выберите авиакомпанию:");
            for (int AirlinesIndex = 0; AirlinesIndex < Airlines.Count; ++AirlinesIndex)
            {
                Console.WriteLine($"{AirlinesIndex + 1} - {airlines[AirlinesIndex]}");
            }
            int AirlineIndex = int.Parse(Console.ReadLine()) - 1;
            string Airline = Airlines[AirlineIndex];

            Ticket ticket;
            if (TicketType == 1)
            {
                ticket = EconomyTicketFactory.CreateTicket(direction, date, airline);
            }
            else if (ticketType == 2)
            {
                ticket = BusinessTicketFactory.CreateTicket(direction, date, airline);
            }
            else
            {
                Console.WriteLine("Неверный тип билета.");
                return;
            }
            
            
            Console.WriteLine("Ваш билет:");
            Console.WriteLine($"Направление: {ticket.Direction}");
            Console.WriteLine($"Дата: {ticket.Date:dd.MM.yyyy}");
            Console.WriteLine($"Авиакомпания: {ticket.Airline}");
            Console.WriteLine($"Класс: {ticket.TicketClass}");
            
            Console.WriteLine("Хотите подтвердить бронирование? (Да/Нет)");
            string Сonfirmation = Console.ReadLine();
            if (Сonfirmation.ToLower() == "да")
            {
                Console.WriteLine("Бронирование подтверждено!");
                IsBookingConfirmed = true;
            }
            else
            {
                Console.WriteLine("Бронирование отменено.");
            }
        }
    }
}
