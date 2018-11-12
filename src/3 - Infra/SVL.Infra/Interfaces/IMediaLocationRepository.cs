using SVL.Infra.Entities;
/// <summary>
/// Interface Genérica: Responsável pelas chamadas das Operações de CRUD
/// </summary>
namespace SVL.Infra.Interfaces
{
    public interface IMediaLocationRepository
    {
        /// <summary>
        /// Adicionar a media na Locação
        /// </summary>
        /// <param name="media"></param>
        void AddMedia(MediaLocation media);

        /// <summary>
        /// Remove a midia da locação
        /// </summary>
        /// <param name="mediaId"></param>
        void RemoveMedia(MediaLocation media);

    }
}
