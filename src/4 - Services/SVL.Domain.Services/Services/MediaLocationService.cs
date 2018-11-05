using SVL.Domain.Location.Interfaces.Services;
using SVL.Infra.Entities;
using SVL.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Domain.Services.Services
{
    public class MediaLocationService : IMediaLocationService
    {

        private IRepository<MediaLocation> _repository;

        public MediaLocationService(IRepository<MediaLocation> repository)
        {
            _repository = repository;
        }
        public void AddMedia(MediaLocation mediaLocation)
        {
            _repository.Insert(mediaLocation);
        }

        public void RemoveMedia(int mediaId)
        {
            throw new NotImplementedException();
        }
    }
}
