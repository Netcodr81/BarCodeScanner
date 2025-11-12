using BarCodeScannerApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BarCodeScannerApi.Data.Context;

public class BarcodeContext : DbContext
{
    public DbSet<Item> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=../barcode.db");
    }
}