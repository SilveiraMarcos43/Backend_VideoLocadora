
namespace SVL.Domain.Location.Domain.Services
{
    public interface ILocationService
    {
        LocationAggregate Create(int customerId);
    }
}
