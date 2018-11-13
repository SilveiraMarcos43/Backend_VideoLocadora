using SVL.Common.CrossCuting;
using SVL.Domain.Base.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SVL.Domain.Base
{
    /// <summary>
    ///     bairro: "Tijuca",
    ///     logradouro: "Rua Garibaldi",
    ///     cep: "20511330",
    ///     uf: "RJ",
    ///     localidade: "Rio de Janeiro"
    /// </summary>
    public class Address : BaseEntity
    {
        private string _cep;
        private string _streetDescription;
        private string _city;
        private string _district;
        private string _state;

        /// <summary>
        /// CEP
        /// </summary>
        public string Cep { get => _cep; set => _cep = value; }
        /// <summary>
        /// Descrição Rua
        /// </summary>
        public string StreetDescription { get => _streetDescription; set => _streetDescription = value; }
        /// <summary>
        /// bairro
        /// </summary>
        public string District { get => _district; set => _district = value; }
        /// <summary>
        /// Cidade
        /// </summary>
        public string City { get => _city; set => _city = value; }
        /// <summary>
        /// Estado
        /// </summary>
        public string State { get => _state; set => _state = value; }

    }
}
