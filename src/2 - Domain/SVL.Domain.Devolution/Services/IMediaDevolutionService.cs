using System;

namespace SVL.Domain.Devolution.Services
{
    public interface IMediaDevolutionService
    {
        /// <summary>
        /// Retorna  Midia da Locação
        /// </summary>
        /// <param name="mediaLocationId"></param>
        /// <returns></returns>
        MediaDevolution GetMediaDevolutionById(int mediaLocationId);

        /// <summary>
        /// Media Devolvida Rebobinada
        /// </summary>
        /// <param name="mediaLocationId"></param>
        /// <returns></returns>
        bool VerifyMediaRewound(int _customerId, int mediaLocationId, Boolean Rewound);

        /// <summary>
        /// Devolvida dentro do prazo
        /// </summary>
        /// <param name="locationId"></param>
        /// <param name="mediaLocationId"></param>
        /// <returns></returns>
        bool MediaWasReturnedOnTime(int locationId, int mediaLocationId);

    }
}
