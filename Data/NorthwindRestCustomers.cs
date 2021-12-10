//namespace WebinarMasterDetailDemo.Data.NorthwindRest; // Razor won't recognize third level namespace

using System.Text.Json.Serialization;
using WebinarMasterDetailDemo.Common;

namespace WebinarMasterDetailDemo.NorthwindRest;

public class CustomersType
{
    public string CustomerID { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    [JsonConverter(typeof(JsonStringConverter))]
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
}
