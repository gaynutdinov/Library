using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library__MVC_.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        
        public Book Book { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
    }
}
