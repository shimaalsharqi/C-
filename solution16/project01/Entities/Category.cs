using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // Navigation Property
        public List<Movie> Movies { get; set; }
    }
}
