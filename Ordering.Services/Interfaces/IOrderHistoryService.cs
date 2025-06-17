using Ordering.Model.Dto.OrderHistory;

namespace Ordering.Services.Interfaces;

public interface IOrderHistoryService
{
    Task<IEnumerable<OrderHistoryItemDto>> GetOrderHistory(OrderHisotryRequestDto request, 
        CancellationToken token = default);
}
