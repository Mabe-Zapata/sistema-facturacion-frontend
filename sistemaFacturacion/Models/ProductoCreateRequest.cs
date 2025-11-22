using System.Text.Json.Serialization;

public class ProductoCreateRequest
{
    // Categoría del producto
    [JsonPropertyName("idCatPro")]
    public int IdCategoria { get; set; }

    // Tipo tributario del producto
    [JsonPropertyName("idTipTrib")]
    public int IdTipoTributario { get; set; }

    // Nombre del producto
    [JsonPropertyName("nomPro")]
    public string Nombre { get; set; } = string.Empty;

    // Descripción del producto
    [JsonPropertyName("desPro")]
    public string Descripcion { get; set; } = string.Empty;

    // Estado del producto (activo/inactivo)
    [JsonPropertyName("estPro")]
    public bool Estado { get; set; } = true;
}
