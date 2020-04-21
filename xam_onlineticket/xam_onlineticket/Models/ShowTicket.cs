using System;
namespace xam_onlineticket.Models
{
    public class ShowTicket : Tickets
    {
        public string Address { get; set; }
        public string ShowTitle { get; set; }
        public string ShowDate { get; set; }
        public string ShowTime { get; set; }
        public string Theater { get; set; }
        public string Row { get; set; }
        public string Column { get; set; }
    }
}
