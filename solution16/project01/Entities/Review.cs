using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Entities
{
    public class Review
    {
        public int Id { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }

        // Foreign Keys
        public int UserId { get; set; }

        public int MovieId { get; set; }

        // Navigation Properties
        public User User { get; set; }

        public Movie Movie { get; set; }
    }
}
