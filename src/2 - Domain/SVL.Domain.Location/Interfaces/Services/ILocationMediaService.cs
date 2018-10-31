
namespace SVL.Domain.Location.Interfaces.Services
{
    public interface ILocationMediaService
    {
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
        /// Adicionar a media na Locação
        /// </summary>
        /// <param name="media"></param>
        void AddMedia(MediaLoc media);

        /// <summary>
        /// Remove a midia da locação
        /// </summary>
        /// <param name="mediaId"></param>
        void RemoveMedia(int mediaId);

    }
}
