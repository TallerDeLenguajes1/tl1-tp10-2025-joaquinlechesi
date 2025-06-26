using System.Text.Json.Serialization; //IMPORTANTE IMPLEMENTAR
namespace MiWebApi;

public class Country
{
    [JsonPropertyName("country_id")]
    public string country_id { get; set; }

    [JsonPropertyName("probability")]
    public double probability { get; set; }
}