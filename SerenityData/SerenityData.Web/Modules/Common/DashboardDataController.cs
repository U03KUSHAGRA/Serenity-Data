using Microsoft.AspNetCore.Mvc;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

[Route("[controller]")]
public class DashboardDataController : Controller
{
    private readonly IDbConnection connection;

    public DashboardDataController(IConfiguration configuration)
    {
        string connStr = configuration.GetSection("Data:SerenityData:ConnectionString").Value;
        connection = new SqlConnection(connStr);
        connection.Open();
    }

    [HttpGet("CategoryData")]
    public IActionResult CategoryData()
    {
        var data = connection.Query(@"
            SELECT c.CategoryName AS Label, COUNT(*) AS Value
            FROM Products p
            JOIN Categories c ON p.CategoryID = c.CategoryID
            GROUP BY c.CategoryName
        ");

        return Json(data);
    }

    [HttpGet("SalesData")]
    public IActionResult SalesData()
    {
        var data = connection.Query(@"
        SELECT 
            CONVERT(varchar, ReportDate, 23) AS Label, 
            SUM(TotalAmount) AS Value 
        FROM TotalSales 
        GROUP BY ReportDate 
        ORDER BY ReportDate");

        return Json(data);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            connection?.Dispose();
        }
        base.Dispose(disposing);
    }
}
