using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Infra.CrossCuting
{
    public interface IEventAddress<T> where T : INotification
    {
        void EnderecarEvento(T args);
    }
}
