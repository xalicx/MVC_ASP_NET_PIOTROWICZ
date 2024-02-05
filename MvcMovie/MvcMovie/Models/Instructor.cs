

using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models

{
    public class Instructor
    {
        public class Teacher
        {
            public int Id { get; set; }

            public required string Name { get; set; }

            public required string Place { get; set; }


            public int? Age { get; set; }

            [Display(Name = "Licence number")]
            public string? LicenceNumber { get; set; }

            public ICollection<Training>? Training { get; set; }

            override public string ToString()
            {
                return Name + ' ' + Place;
            }
        }
    }
}
