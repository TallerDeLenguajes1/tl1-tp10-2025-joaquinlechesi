using System.Text.Json.Serialization; //IMPORTANTE IMPLEMENTAR
namespace MiWebApi;
// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

public class Nombre
{
    [JsonPropertyName("count")]
    public int count { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("country")]
    public List<Country> country { get; set; }
}


//public class Country
//{
//    public string country_id { get; set; }
//    public double probability { get; set; }
//}
//
//public class Nombre
//{
//    public int count { get; set; }
//    public string name { get; set; }
//    public List<Country> country { get; set; }
//}

// public class GetNombre
// {
//     private static readonly HttpClient cliente = new HttpClient();
//     //await getNombre();
//     private static async Task<Nombre> getNombre()
//     {
//         var url = "https://api.genderize.io/?name=";
//         HttpResponseMessage response = await cliente.GetAsync(url);
//         response.EnsureSuccessStatusCode();
//         string responseBody = await response.Content.ReadAsStringAsync();
//         Nombre nombre = JsonSerializer.Deserialize<Nombre>(responseBody);
//         return nombre;
//     }
// }