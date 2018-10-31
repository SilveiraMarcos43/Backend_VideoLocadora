using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SVL.Domain.Base
{
    public class Contact : BaseEntity
    {
        public Contact()
        {

        }

        private string _telefone;
        private string _name;
        private string _email;
        private int _CustomerId;
        private Customer _Customer;

        /// <summary>
        /// Nome do Contact
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value;}
        }

        /// <summary>
        /// Email do Contact
        /// </summary>
        public string Email { get => _email; set => _email = value; }

        /// <summary>
        /// Telefone do Contact
        /// </summary>
        public string Telefone
        {
            get { return this._telefone;  }
            set { this._telefone = value; }
        }

        /// <summary>
        /// Significa que este Contact pertence a um Cliente
        /// </summary>
        [ForeignKey("Customer")]
        public int CustomerId { get => _CustomerId; set => _CustomerId = value; }
        public Customer Customer { get => _Customer; set => _Customer = value; }


    }
}
