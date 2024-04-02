using MobileFacilityFood.Dependencies;
using Newtonsoft.Json;

namespace MobileFacilityFood.Tests.Dependencies;

[TestClass]
public class MobileFacilityFoodItemTests
{
    [TestMethod]
    public void Serialization_WhenFullData_CorrectDeserialization()
    {
        // ReSharper disable StringLiteralTypo
        var sourceText = "{\"objectid\":\"1732544\",\"applicant\":\"Bonito Poke\",\"facilitytype\":\"Truck\",\"cnn\":\"7165000\",\"locationdescription\":\"ILLINOIS ST: 16TH ST to MARIPOSA ST \\\\ TERRY A FRANCOIS BLVD (400 - 599)\",\"address\":\"409 ILLINOIS ST\",\"blocklot\":\"3940003\",\"block\":\"3940\",\"lot\":\"003\",\"permit\":\"23MFF-00016\",\"status\":\"REQUESTED\",\"fooditems\":\"Bonito Poke Bowls & Various Drinks\",\"x\":\"6016152.96291\",\"y\":\"2106970.02895\",\"latitude\":\"37.76624504710292\",\"longitude\":\"-122.38735628651092\",\"schedule\":\"http://bsm.sfdpw.org/PermitsTracker/reports/report.aspx?title=schedule&report=rptSchedule&params=permit=23MFF-00016&ExportPDF=1&Filename=23MFF-00016_schedule.pdf\",\"received\":\"20231010\",\"priorpermit\":\"0\",\"expirationdate\":\"2024-11-15T00:00:00.000\",\"location\":{\"latitude\":\"37.76624504710292\",\"longitude\":\"-122.38735628651092\",\"human_address\":\"{\\\"address\\\": \\\"\\\", \\\"city\\\": \\\"\\\", \\\"state\\\": \\\"\\\", \\\"zip\\\": \\\"\\\"}\"},\":id\":\"row-sf5w.gvcb~y7g6\"}";
        // ReSharper restore StringLiteralTypo

        var deserializedObject = JsonConvert.DeserializeObject<MobileFacilityFoodItem>(sourceText);

        Assert.IsNotNull(deserializedObject);
        Assert.AreEqual("1732544", deserializedObject.ObjectId);
        Assert.AreEqual("Bonito Poke", deserializedObject.Applicant);
        Assert.AreEqual("Truck", deserializedObject.FacilityType);
        Assert.AreEqual("7165000", deserializedObject.Cnn);
        Assert.AreEqual("ILLINOIS ST: 16TH ST to MARIPOSA ST \\ TERRY A FRANCOIS BLVD (400 - 599)", deserializedObject.LocationDescription);
        Assert.AreEqual("409 ILLINOIS ST", deserializedObject.Address);
        Assert.AreEqual("3940003", deserializedObject.BlockLot);
        Assert.AreEqual("3940", deserializedObject.Block);
        Assert.AreEqual("003", deserializedObject.Lot);
        Assert.AreEqual("23MFF-00016", deserializedObject.Permit);
        Assert.AreEqual(ApplicationStatus.REQUESTED, deserializedObject.Status);
        CollectionAssert.AreEqual(new []{"bonito poke bowls & various drinks"}, deserializedObject.FoodItems);
        Assert.AreEqual(37.76624504710292, deserializedObject.Latitude);
        Assert.AreEqual(-122.38735628651092, deserializedObject.Longitude);
        Assert.AreEqual("http://bsm.sfdpw.org/PermitsTracker/reports/report.aspx?title=schedule&report=rptSchedule&params=permit=23MFF-00016&ExportPDF=1&Filename=23MFF-00016_schedule.pdf", deserializedObject.Schedule);
    }
}