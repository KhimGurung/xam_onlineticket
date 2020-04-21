using System;
namespace xam_onlineticket.Models
{
    public class VisitTicket : Tickets
    {
        public string Address { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
        public string LastEntry { get; set; }
        public string Validity { get; set; }
    }
}
