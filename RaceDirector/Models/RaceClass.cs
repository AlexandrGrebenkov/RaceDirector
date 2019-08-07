using System.ComponentModel.DataAnnotations;

namespace RaceDirector.Models
{
    /// <summary>
    /// Гоночный класс (Prod-24, ES-32, и т.д.)
    /// </summary>
    public class RaceClass : Entity
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
