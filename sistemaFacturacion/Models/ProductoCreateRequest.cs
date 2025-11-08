// Models/ProductoRequest.cs
using System.Text.Json.Serialization;

public  class ProductoCreateRequest
{
    [JsonPropertyName("tipPro")]
    public string Tipo { get; set; } = string.Empty;

    [JsonPropertyName("nomPro")]
    public string Nombre { get; set; } = string.Empty;

    [JsonPropertyName("desPro")]
    public string Descripcion { get; set; } = string.Empty;

     
}
