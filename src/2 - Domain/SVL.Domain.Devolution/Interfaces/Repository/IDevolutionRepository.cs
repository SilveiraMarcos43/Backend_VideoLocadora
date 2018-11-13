
namespace SVL.Domain.Devolution.Interfaces.Repository
{
    public interface IDevolutionRepository
    {
        /// <summary>
        /// Serviço criação da Devolução
        /// </summary>
        /// <param name="locationId"></param>
        void CreateDevolution(int locationId, int customerId);


        /// <summary>
        /// Metodo que altera a situação da devolução
        /// </summary>
        /// <returns></returns>
        void UpdateDevolutionStatus(int locationId);

    }
}

