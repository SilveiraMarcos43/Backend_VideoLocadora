using System.Threading;
using System.Threading.Tasks;

namespace SVL.Common.CrossCuting
{
    public interface INotificationHandler<in TNotification> where TNotification : INotification
    {
        Task Handle(TNotification notification, CancellationToken cancellationToken);
    }            
}
