using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library__MVC_.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime PublishingDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
