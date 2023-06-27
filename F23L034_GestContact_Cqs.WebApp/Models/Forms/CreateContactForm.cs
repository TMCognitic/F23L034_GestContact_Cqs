using System.ComponentModel.DataAnnotations;

namespace F23L034_GestContact_Cqs.WebApp.Models.Forms
{
    public class CreateContactForm
    {
#nullable disable
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Nom { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Prenom { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(384)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateNaiss { get; set; }
#nullable enable
        [MaxLength(20)]
        public string? Tel { get; set; }
    }
}
