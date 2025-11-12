using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BarCodeScannerApi.Data.Models;

public class BarcodeResponse
{
    public int Total { get; set; }
    public List<Item> Items { get; set; }
}

public class Item
{
    [Key]
    [JsonPropertyName("ean")]
    public long EAN { get; set; }
    
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    [JsonPropertyName("upc")]
    public long UPC { get; set; }
    
    [JsonPropertyName("brand")]
    public string? Brand { get; set; }
    
    [JsonPropertyName("model")]
    public string? Model { get; set; }
    
    [JsonPropertyName("color")]
    public string? Color { get; set; }
    
    [JsonPropertyName("size")]
    public string? Size { get; set; }
    
    [JsonPropertyName("dimension")]
    public string? Dimension { get; set; }
    
    [JsonPropertyName("weight")]
    public string? Category { get; set; }
    
    [JsonPropertyName("images")]
    public string[] Images { get; set; } = [];
}