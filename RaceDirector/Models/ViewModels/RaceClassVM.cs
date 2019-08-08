using System.ComponentModel.DataAnnotations;

namespace RaceDirector.Models.ViewModels
{
    public class RaceClassVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
