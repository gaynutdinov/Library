using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library__MVC_.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime DeathDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
