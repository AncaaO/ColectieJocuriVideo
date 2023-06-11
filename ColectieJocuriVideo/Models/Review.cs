using System.ComponentModel.DataAnnotations;

namespace ColectieJocuriVideo.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string? Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string? Message { get; set; }

        public int GameID { get; set; }
        public Game Game { get; set; }
    }
}