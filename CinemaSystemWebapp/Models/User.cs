using System;
using System.Collections.Generic;

namespace CinemaSystemWebapp.Models
{
    public partial class User
    {
        public enum Roles
        {
            User,
            Staff,
            Admin
        }

        public User()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string AvatarUrl { get; set; } = null!;
        public double Balance { get; set; }
        public int Role { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
