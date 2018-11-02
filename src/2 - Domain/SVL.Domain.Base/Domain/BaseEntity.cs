using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SVL.Domain.Base
{

    public abstract class BaseEntity
    {
        private Guid _iD;

        [Key]
        public virtual Guid ID { get => _iD; set => _iD = value; }

    }
}
