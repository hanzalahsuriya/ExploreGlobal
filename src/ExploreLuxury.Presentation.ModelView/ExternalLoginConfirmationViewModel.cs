using System.ComponentModel.DataAnnotations;

namespace ExploreLuxury.Presentation.ModelView
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
    }
}
