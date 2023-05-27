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
            for (int DirectionIndex = 0; DirectionIndex < directions.Count; ++DirectionIndex)
            {
                Console.WriteLine($"{DirectionIndex + 1} - {directions[DirectionIndex]}");
            }
            int directionIndex = int.Parse(Console.ReadLine()) - 1;
            string direction = directions[directionIndex];

            Console.WriteLine("Выберите дату:");
            List<DateTime> dates = datesByDirection[direction];
            for (int DataIndex = 0; DataIndex < dates.Count; ++DataIndex)
            {
                Console.WriteLine($"{DataIndex + 1} - {dates[DataIndex]:dd.MM.yyyy}");
            }
            int dateIndex = int.Parse(Console.ReadLine()) - 1;
            DateTime date = dates[dateIndex];
            
            Console.WriteLine("Выберите авиакомпанию:");
            for (int AirlinesIndex = 0; AirlinesIndex < airlines.Count; ++AirlinesIndex)
            {
                Console.WriteLine($"{AirlinesIndex + 1} - {airlines[AirlinesIndex]}");
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
                isBookingConfirmed = true;
            }
            else
            {
                Console.WriteLine("Бронирование отменено.");
            }
        }
    }
}
