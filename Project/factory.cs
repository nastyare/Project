using System;

namespace IndividualProject
{
    abstract class Ticket
    {
        public string Direction { get; set; }
        public DateTime Date { get; set; }
        public string Airline { get; set; }
        public string TicketClass { get; set; }
        public string TicketClass { get; set; }

    }
    class EconomyTicket : Ticket
    {
        public EconomyTicket(string direction, DateTime date, string airline)
        {
            Direction = direction;
            Date = date;
            Airline = airline;
            TicketClass = "Эконом-класс";
        }
    }
    class BusinessTicket : Ticket
    {
        public BusinessTicket(string direction, DateTime date, string airline)
        {
            Direction = direction;
            Date = date;
            Airline = airline;
            TicketClass = "Бизнес-класс";
        }
    }

    // Абстрактный класс для фабрики билетов
    abstract class TicketFactory
    {
        public abstract Ticket CreateTicket(string direction, DateTime date, string airline);
    }

    // Конкретная фабрика для эконом-билетов
    class EconomyTicketFactory : TicketFactory
    {
        public override Ticket CreateTicket(string direction, DateTime date, string airline)
        {
            return new EconomyTicket(direction, date, airline);
        }
    }

    // Конкретная фабрика для бизнес-билетов
    class BusinessTicketFactory : TicketFactory
    {
        public override Ticket CreateTicket(string direction, DateTime date, string airline)
        {
            return new BusinessTicket(direction, date, airline);
        }
    }
}
