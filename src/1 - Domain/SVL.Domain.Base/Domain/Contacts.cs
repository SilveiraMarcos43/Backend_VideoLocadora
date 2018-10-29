using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SVL.Domain.Base
{
    public class Contato : BaseEntity
    {
        public Contato()
        {

        }

        private string _telefone;
        private string _name;
        private string _email;
        private int _CustomerId;
        private Customer _Customer;

        /// <summary>
        /// Nome do Contato
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value;}
        }

        /// <summary>
        /// Email do Contato
        /// </summary>
        public string Email { get => _email; set => _email = value; }

        /// <summary>
        /// Telefone do Contato
        /// </summary>
        public string Telefone
        {
            get { return this._telefone;  }
            set { this._telefone = value; }
        }

        /// <summary>
        /// Significa que este contato pertence a um Cliente
        /// </summary>
        [ForeignKey("Customer")]
        public int CustomerId { get => _CustomerId; set => _CustomerId = value; }
        public Customer Customer { get => _Customer; set => _Customer = value; }


    }
}
