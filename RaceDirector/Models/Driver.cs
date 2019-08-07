using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDirector.Models
{
    /// <summary>Пилот</summary>
    public class Driver : Entity
    {
        /// <summary>Имя</summary>
        [MaxLength(100)]
        public string FirstName { get; set; }

        /// <summary>Фамилия</summary>
        [MaxLength(100)]
        public string LastName { get; set; }

        /// <summary>Дата рождения</summary>
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
    }
}
