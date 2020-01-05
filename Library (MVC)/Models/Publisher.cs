using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library__MVC_.Models
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int INN { get; set; }
        
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
