﻿
namespace SVL.Domain.Location.Interfaces.Services
{
    public interface ILocationMediaService
    {
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
