using Microsoft.Extensions.Logging;

namespace Project.One;

public partial class BusinessLogicService(ILogger<BusinessLogicService> logger)
{
    private readonly ILogger<BusinessLogicService> _logger = logger;

    public int GetBusinessLogicCount(string businessLogicName)
    {
        ArgumentNullException.ThrowIfNull(businessLogicName);
        
        LogGetBusinessLogic(businessLogicName);
        
        return businessLogicName.Length;
    }
    
    [LoggerMessage(1, LogLevel.Trace, "Getting business logic for {BusinessLogicName}")]
    partial void LogGetBusinessLogic(string businessLogicName);
}