using System;
using xam_onlineticket.Models;
using System.Collections.Generic;

namespace xam_onlineticket.Models
{
    public class Tickets
    {
        public enum TicketValidity
        {
            Valid,
            Expired,
            All
        }

        public string Logo { get; set; }
        public string Title { get; set; }
        public string TicketId { get; set; }
        public string PurchaseDate { get; set; }
        public string Price { get; set; }
        public bool Valid { get; set; }
        public bool Used { get; set; }

        public List<Tickets> GetTickets()
        {
            List<Tickets> tickets = new List<Tickets>()
            {
                new ShowTicket(){
                    Logo= "ic.jpeg",
                    TicketId= "29865743",
                    PurchaseDate= "12.11.2019",
                    Title= "Internatinal Cineplex",
                    Address= "Am Olympiapark 2, 80809 Müchen",
                    ShowTitle= "Lord of the Rings",
                    Theater= "01",
                    Row= "07",
                    Column= "12",
                    ShowDate= "12.04.2019",
                    ShowTime= "19:00",
                    Price= "19",
                    Valid= false,
                    Used= false
                },
                new PartyTicket(){
                    Logo= "ny.jpeg",
                    TicketId= "29865743",
                    PurchaseDate= "12.11.2019",
                    Title= "New Year Party",
                    Address= "Zeil 9, 9058 Frankfurt",
                    Artist= "The Amazing Spiderman",
                    StartTime= "07:00",
                    EndTime= "12:00",
                    Date= "12.04.2019",
                    Price= "13",
                    Valid= true,
                    Used= false
                },
                new ShowTicket() {
                    Logo= "ic.jpeg",
                    TicketId= "29865743",
                    PurchaseDate= "12.11.2019",
                    Title= "Internatinal Cineplex",
                    Address= "Am Olympiapark 2, 80809 Müchen",
                    ShowTitle= "Lord of the Rings",
                    Theater= "01",
                    Row= "07",
                    Column= "12",
                    ShowDate= "12.04.2019",
                    ShowTime= "19:00",
                    Price= "15",
                    Valid= true,
                    Used= false
                },
                new TravelTicket(){
                    Logo= "rmv.jpeg",
                    TicketId= "29865743",
                    Title= "Day Ticket",
                    Transportation= "RMV Bus",
                    From= "5000",
                    To= "5000",
                    Through= "0000",
                    PurchaseDate= "12.11.2019",
                    Price= "12",
                    Valid= false,
                    Used= true
                },
                new VisitTicket(){
                    Logo= "bmw.jpeg",
                    TicketId= "29865743",
                    PurchaseDate= "12.11.2019",
                    Title= "BMW Museum",
                    Address= "Am Olympiapark 2, 80809 Müchen",
                    OpenTime= "09:00",
                    CloseTime= "19:00",
                    LastEntry= "18:00",
                    Price= "5",
                    Validity= "Ticket is for one time use after purchase",
                    Valid= false,
                    Used= true
                },
                new PartyTicket(){
                    Logo= "sn.jpeg",
                    TicketId= "29865743",
                    PurchaseDate= "12.11.2019",
                    Title= "New Year Party",
                    Address= "Zeil 9, 9058 Frankfurt",
                    Artist= "The Amazing Spiderman",
                    StartTime= "07:00",
                    EndTime= "12:00",
                    Date= "12.04.2019",
                    Price= "13",
                    Valid= false,
                    Used= false
                },
                new VisitTicket(){
                    Logo= "ic.jpeg",
                    TicketId= "29865743",
                    PurchaseDate= "12.11.2019",
                    Title= "Frankfurt Tower",
                    Address= "Am Olympiapark 2, 80809 Müchen",
                    OpenTime= "09:00",
                    CloseTime= "19:00",
                    LastEntry= "18:00",
                    Price= "5",
                    Validity= "Ticket is for one time use after purchase",
                    Valid= false,
                    Used= false
                },
                new ShowTicket(){
                    Logo= "ic.jpeg",
                    TicketId= "29865743",
                    PurchaseDate= "12.11.2019",
                    Title= "Internatinal Cineplex",
                    Address= "Am Olympiapark 2, 80809 Müchen",
                    ShowTitle= "Lord of the Rings",
                    Theater= "01",
                    Row= "07",
                    Column= "12",
                    ShowDate= "12.04.2019",
                    ShowTime= "19:00",
                    Price= "19",
                    Valid= true,
                    Used= false
                }
            };

            return tickets;
        }
    }
}
