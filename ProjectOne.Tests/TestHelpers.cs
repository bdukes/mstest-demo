using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Project.One.Tests;

public static class TestHelpers
{
    public static BusinessLogicService CreateBusinessLogicService(ILogger<BusinessLogicService>? logger = null)
    {
        return new BusinessLogicService(logger ?? NullLogger<BusinessLogicService>.Instance);
    }
}