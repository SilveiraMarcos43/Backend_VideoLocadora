using System;

namespace SVL.Domain.Base
{
    public abstract class Person : BaseEntity
    {
        private string _name;
        private DateTime _dateBirth;

        /// <summary>
        /// Nome da Pessoa
        /// </summary>
        public string Name { get => _name; set => _name = value; }

        /* Data da aniver */
        public DateTime DateBirth { get => _dateBirth; set => _dateBirth = value; }
    }
}
