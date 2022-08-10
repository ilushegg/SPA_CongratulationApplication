using System.ComponentModel.DataAnnotations;

namespace SPA_CongratulationApplication.Models
{
    public class Person
    {
        public int id { get; set; }

        [StringLength(100)]
        public string name { get; set; } = string.Empty;

        public DateTime birthday { get; set; }

        public String? filename { get; set; }

        public int userId { get; set; }
        public User? user { get; set; }

    }
}
