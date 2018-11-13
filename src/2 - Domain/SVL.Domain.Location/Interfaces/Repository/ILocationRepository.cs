
using FluentValidation;

namespace SVL.Domain.Location.Interfaces.Repository
{
    public interface ILocationRepository
    {
        /// <summary>
        /// Criação da locação sem Midia
        /// </summary>
        /// <param name="locationAggregate"></param>
        void CreateLocation(LocationAggregate locationAggregate);

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

        /// <summary>
        /// Metodo que Retorna uma locação
        /// </summary>
        /// <returns></returns>
        LocationAggregate ReturnLocationMedia(int LocationId);

    }
}
