using Ordering.Services.Interfaces;
using Ordering.Infrastructure.Repositories.Interfaces;
using Ordering.Model.Dto.OrderHistory;

namespace Ordering.Services;

public class OrderHistoryService : IOrderHistoryService
{
    private readonly IOrdersRepository _ordersRepository;

    public OrderHistoryService(IOrdersRepository ordersRepository)
    {
        _ordersRepository = ordersRepository;
    }

    public async Task<IEnumerable<OrderHistoryItemDto>> GetOrderHistory(OrderHisotryRequestDto request, CancellationToken token = default)
    {
        var orders = _ordersRepository.GetOrderHistory(request, token);
        //provide async work with incoming orders here

        return orders.ToBlockingEnumerable();
    }
}
