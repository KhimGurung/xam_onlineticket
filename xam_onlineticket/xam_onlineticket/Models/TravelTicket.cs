using System;
namespace xam_onlineticket.Models
{
    public class TravelTicket : Tickets
    {
        public string Transportation { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Through { get; set; }
    }
}
