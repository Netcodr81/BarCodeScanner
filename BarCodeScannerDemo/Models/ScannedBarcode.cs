namespace BarCodeScannerDemo.Models;

public record ScannedBarcode(
    string Code = "",
    string Format = "",
    DateTime? Timestamp = null
);