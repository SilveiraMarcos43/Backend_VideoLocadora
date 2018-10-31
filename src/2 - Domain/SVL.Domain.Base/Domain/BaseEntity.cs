using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SVL.Domain.Base
{

    public abstract class BaseEntity
    {
        private int _iD;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int ID { get => _iD; set => _iD = value; }

    }
}
