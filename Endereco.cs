using System.Text.Json.Serialization;

public class Endereco
{
    [JsonPropertyName("localidade")]
    public string Localidade { get; set; }
}