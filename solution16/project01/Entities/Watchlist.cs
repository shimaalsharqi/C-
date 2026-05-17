using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Entities
{
    public class Watchlist
    {
        // Composite Key
        public int UserId { get; set; }

        public int MovieId { get; set; }

        public DateTime AddedDate { get; set; }

        // Navigation Properties
        public User User { get; set; }

        public Movie Movie { get; set; }
    }
}
