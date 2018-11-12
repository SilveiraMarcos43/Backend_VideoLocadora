using SVL.Domain.Devolution;
using SVL.Domain.Devolution.Interfaces.Repository;
using SVL.Infra.Data;

namespace SVL.Infra.Repository
{
    public class MediaDevolutionRepository : IMediaDevolutionRepository
    {
        private BaseContexto _baseContexto;

        public MediaDevolutionRepository(BaseContexto baseContexto)
        {
            this._baseContexto = baseContexto;
        }

        /// <summary>
        /// Retorna Midia 
        /// </summary>
        /// <returns></returns>
        public MediaDevolution GetMediaDevolutionById(int mediaLocationId)
        {
           return _baseContexto.Set<MediaDevolution>().Find(mediaLocationId);
        }
    }
}