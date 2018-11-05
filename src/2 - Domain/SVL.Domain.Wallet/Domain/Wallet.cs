using SVL.Common.CrossCuting;

namespace SVL.Domain.Wallet.Domain
{
    public class Wallet : BaseEntity
    {
        private int _creditPoints;
        private int _customerId;

        public Wallet(int CustomerID)
        {
            this._customerId = CustomerID;
        }

        /// <summary>
        /// Id do Cliente
        /// </summary>
        public int CustomerID { get => CustomerID; set => _customerId = value; }

        /// <summary>
        /// Total de Creditos do Cliente
        /// </summary>
        public int CreditPoints { get => _creditPoints; set => _creditPoints = value; }


    }
}
