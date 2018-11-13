using System;

namespace SVL.Domain.Devolution.Interfaces.Repository
{
    public interface IMediaDevolutionRepository
    {
        /// <summary>
        /// Retorna  Midia da Locação
        /// </summary>
        /// <param name="mediaLocationId"></param>
        /// <returns></returns>
        MediaDevolution GetMediaDevolutionById(int mediaLocationId);

    }
}
