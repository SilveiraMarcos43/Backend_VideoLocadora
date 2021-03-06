﻿
namespace SVL.Domain.Location.Interfaces.Repository
{
    public interface ILocationRepository
    {
        /// <summary>
        /// Criação da locação sem Midia
        /// </summary>
        /// <param name="customerId"></param>
        void CreateLocation(int customerId);

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
