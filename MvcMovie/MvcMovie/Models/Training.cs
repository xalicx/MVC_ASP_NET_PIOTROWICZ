using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Training
    {
        public int Id { get; set; }

        public required string Type { get; set; }

        [Display(Name = "Dzień tygodnia")]
        public required string WeekDay { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Godzina")]
        public required DateTime DateStart { get; set; }
        public int Duration { get; set; }

        public required int InstructorId { get; set; }

        public Instructor? Instructor { get; set; }

        public string DateStop()
        {
            return DateStart.AddMinutes(Duration).ToString("hh:mm");
        }




    }
}
