// Models/ProductoResponse.cs
using System.Text.Json.Serialization;

public sealed class ProductoDto
{
    [JsonPropertyName("idPro")]
    public int Id { get; set; }

    [JsonPropertyName("tipPro")]
    public string Tipo { get; set; } = string.Empty;

    [JsonPropertyName("nomPro")]
    public string Nombre { get; set; } = string.Empty;

    [JsonPropertyName("desPro")]
    public string Descripcion { get; set; } = string.Empty;

    [JsonPropertyName("prePro")]
    public decimal Precio { get; set; } 

    [JsonPropertyName("estPro")]
    public bool Estado { get; set; }
}
