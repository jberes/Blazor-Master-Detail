//namespace WebinarMasterDetailDemo.Data.NorthwindRest; // Razor won't recognize third level namespace
using System.Text.Json.Serialization;
using WebinarMasterDetailDemo.Common;

namespace WebinarMasterDetailDemo.NorthwindRest;

public class OrdersType
{
    public double OrderID { get; set; }
    public string CustomerID { get; set; }
    public double EmployeeID { get; set; }
    [JsonConverter(typeof(JsonNumberToDateConverter))]
    public DateTime OrderDate { get; set; }
    [JsonConverter(typeof(JsonNumberToDateConverter))]
    public DateTime RequiredDate { get; set; }
    [JsonConverter(typeof(JsonNumberToDateConverter))]
    public DateTime? ShippedDate { get; set; }
    public double ShipVia { get; set; }
    public double Freight { get; set; }
    public string ShipName { get; set; }
    public string ShipAddress { get; set; }
    public string ShipCity { get; set; }
    public string ShipRegion { get; set; }
    [JsonConverter(typeof(JsonStringConverter))]
    public string ShipPostalCode { get; set; }
    public string ShipCountry { get; set; }
}
