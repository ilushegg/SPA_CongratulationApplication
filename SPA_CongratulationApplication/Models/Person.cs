using System.ComponentModel.DataAnnotations;

namespace SPA_CongratulationApplication.Models
{
    public class Person
    {
        private int id { get; set; }

        [StringLength(100)]
        private string name { get; set; } = string.Empty;

        private DateOnly birthday { get; set; }

        private String? filename { get; set; }

        private int userId { get; set; }
        private User? user { get; set; }

    }
}
