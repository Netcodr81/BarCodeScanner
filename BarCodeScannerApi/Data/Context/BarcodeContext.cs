using Microsoft.EntityFrameworkCore;
using SharedKernel.Models;

namespace BarCodeScannerApi.Data.Context;

public class BarcodeContext : DbContext
{
    public DbSet<Item> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=../barcode.db");
    }
}