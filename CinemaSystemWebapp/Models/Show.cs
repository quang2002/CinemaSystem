using System;
using System.Collections.Generic;

namespace CinemaSystemWebapp.Models
{
    public partial class Show
    {
        public Show()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public int? FilmId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public double TicketPrice { get; set; }
        public int? RoomId { get; set; }

        public virtual Film? Film { get; set; }
        public virtual Room? Room { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
