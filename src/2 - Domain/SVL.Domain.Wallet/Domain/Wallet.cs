using SVL.Common.CrossCuting;

namespace SVL.Domain.Wallet.Domain
{
    public class Wallet : BaseEntity
    {
        private int _creditPoints;

        public Wallet(int CustomerID)
        {

        }

        /// <summary>
        /// Id do Cliente
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Total de Creditos do Cliente
        /// </summary>
        public int CreditPoints { get => _creditPoints; set => _creditPoints = value; }


    }
}
