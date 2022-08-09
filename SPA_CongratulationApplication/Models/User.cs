using System.ComponentModel.DataAnnotations;

namespace SPA_CongratulationApplication.Models
{
    public class User
    {
        private int id { get; set; }

        [StringLength(100)]
        private string name { get; set; } = string.Empty;

        [EmailAddress]
        private string email { get; set; } = string.Empty;

        private bool isAllowSending { get; set; }

    }
}
