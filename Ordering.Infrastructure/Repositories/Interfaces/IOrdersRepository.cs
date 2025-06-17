using Ordering.Model.Dto.OrderHistory;

namespace Ordering.Infrastructure.Repositories.Interfaces;

public interface IOrdersRepository
{
    IAsyncEnumerable<OrderHistoryItemDto> GetOrderHistory(OrderHisotryRequestDto request, CancellationToken token = default);
}
