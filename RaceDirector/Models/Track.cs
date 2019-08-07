using System.ComponentModel.DataAnnotations;

namespace RaceDirector.Models
{
    /// <summary>Трасса</summary>
    public class Track : Entity
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
