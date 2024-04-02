using MobileFacilityFood.Services;

namespace MobileFacilityFood.Tests.Services;

[TestClass]
public class DistanceCalculationServiceTests
{
    [TestMethod]
    public void Calculate_WhenCorrectData_ThenDistanceCalculatedApproximately()
    {
        var target = new DistanceCalculationService();

        // taken from google
        var result = target.Calculate(37.76396793169976, -122.51037344966151, 37.766153676572756, -122.46111937450482);

        // distance in meters
        Assert.IsTrue(result < 4500);
        Assert.IsTrue(result > 4300);
    }

    [TestMethod]
    public void Calculate_WhenCorrectData_ThenDistanceCalculatedApproximately2()
    {
        var target = new DistanceCalculationService();

        // taken from google
        var result = target.Calculate(37.76413856750102, -122.49651267682744, 37.75528592429814, -122.49599679946205);

        // distance in meters
        Assert.IsTrue(result < 1100);
        Assert.IsTrue(result > 900);
    }
}