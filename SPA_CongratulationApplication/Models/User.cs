using System.ComponentModel.DataAnnotations;

namespace SPA_CongratulationApplication.Models
{
    public class User
    {
        public int id { get; set; }

        [StringLength(100)]
        public string name { get; set; } = string.Empty;

        [EmailAddress]
        public string email { get; set; } = string.Empty;

        public bool isAllowSending { get; set; }

    }
}
