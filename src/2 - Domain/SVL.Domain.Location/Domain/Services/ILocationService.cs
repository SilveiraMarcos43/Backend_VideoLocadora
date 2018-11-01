
namespace SVL.Domain.Location.Domain.Services
{
    public interface ILocationService
    {

        /// <summary>
        /// Serviço criação da Locação
        /// </summary>
        /// <param name="customerId"></param>
        void Create(int customerId);

        /// <summary>
        /// Metodo que efetiva uma locação
        /// </summary>
        /// <returns></returns>
        LocationAggregate EffectLocationMedia(LocationAggregate locationMedia);

        /// <summary>
        /// Metodo que cancela uma Locação
        /// </summary>
        /// <returns></returns>
        void CancelLocationMedia(int LocationMediaId);
    }
}
