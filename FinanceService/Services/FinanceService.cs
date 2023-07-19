using Grpc.Core;

namespace FinanceService.Services;

public class FinanceManagement : Finances.FinancesBase
{
    private readonly ILogger<FinanceManagement> _logger;
    public FinanceManagement(ILogger<FinanceManagement> logger)
    {
        _logger = logger;
    }

    public override Task<PriceReply> GetModelPrice(PriceRequest request, ServerCallContext context)
    {
        return Task.FromResult(new PriceReply
        {
            Price = 1000
        });
    }
}
