using System;

namespace RaceDirector.Models
{
    /// <summary>Пилот</summary>
    public class Driver : Entity
    {
        /// <summary>Имя</summary>
        public string FirstName { get; set; }

        /// <summary>Фамилия</summary>
        public string LastName { get; set; }

        /// <summary>Дата рождения</summary>
        public DateTime DateOfBirth { get; set; }
    }
}
