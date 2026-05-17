using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        // Navigation Properties
        public List<Review> Reviews { get; set; }

        public List<Watchlist> Watchlists { get; set; }
    }
}
