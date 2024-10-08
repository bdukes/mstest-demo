﻿namespace Project.One.Tests;

[TestClass]
public class BusinessLogicServiceTests
{
    [TestMethod]
    public void GetBusinessLogicCount_WhenNullInput_Throws()
    {
        var service = TestHelpers.CreateBusinessLogicService();
        Assert.ThrowsException<ArgumentNullException>(() => service.GetBusinessLogicCount(null!));
    }
}
