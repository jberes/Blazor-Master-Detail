//namespace WebinarMasterDetailDemo.Data.NorthwindRest; // Razor won't recognize third level namespace
namespace WebinarMasterDetailDemo.NorthwindRest;

public class OrdersType
{
    public double? OrderID { get; set; }
    public string? CustomerID { get; set; }
    public double? EmployeeID { get; set; }
    public double? OrderDate { get; set; }
    public double? RequiredDate { get; set; }
    public string? ShippedDate { get; set; }
    public double? ShipVia { get; set; }
    public double? Freight { get; set; }
    public string? ShipName { get; set; }
    public string? ShipAddress { get; set; }
    public string? ShipCity { get; set; }
    public string? ShipRegion { get; set; }
    public string? ShipPostalCode { get; set; }
    public string? ShipCountry { get; set; }
}
