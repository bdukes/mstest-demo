using Project.One.Tests;

namespace Project.Two.Tests;

[TestClass]
public class MoreLogicServiceTests
{
    [TestMethod]
    public void DoThings_WhenZero_IsEmpty()
    {
        var service = CreateMoreLogicService();
        Assert.AreEqual(string.Empty, service.DoThings(0));
    }

    private static MoreLogicService CreateMoreLogicService()
    {
        return new MoreLogicService(TestHelpers.CreateBusinessLogicService());
    }
}