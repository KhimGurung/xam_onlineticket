using System;
namespace xam_onlineticket.Models
{
    public class PartyTicket : Tickets
    {
        
        public string Address { get; set; }
        public string Artist { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
