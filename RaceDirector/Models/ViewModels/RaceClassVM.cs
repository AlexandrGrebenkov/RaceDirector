using System.ComponentModel.DataAnnotations;

namespace RaceDirector.Models.ViewModels
{
    public class RaceClassVM
    {
        [Required]
        public string Name { get; set; }
    }
}
