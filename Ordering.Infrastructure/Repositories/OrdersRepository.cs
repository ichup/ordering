using Ordering.Infrastructure.Repositories.Interfaces;
using Ordering.Model.Dto.OrderHistory;

namespace Ordering.Infrastructure.Repositories;

public class OrdersRepository : IOrdersRepository
{
    public async IAsyncEnumerable<OrderHistoryItemDto> GetOrderHistory(OrderHisotryRequestDto request, CancellationToken token = default)
    {
        yield return new OrderHistoryItemDto();
    }
}
