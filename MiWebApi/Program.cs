using System.Security;
using System.Text.Json;
using MiWebApi;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 3.");
string url = "https://api.nationalize.io/?name=";
Console.WriteLine("Ingrese su nombre para obtener cuatro posibles nacionalidades en base a su nombre:");
string nombreIngresado;
nombreIngresado = Console.ReadLine();
HttpClient client = new HttpClient();
HttpResponseMessage response = await client.GetAsync((url + nombreIngresado.ToLower()));
response.EnsureSuccessStatusCode();

string responseBody = await response.Content.ReadAsStringAsync();
Nombre nombre = JsonSerializer.Deserialize<Nombre>(responseBody);

Console.WriteLine("Mostrando resultados:");
Console.WriteLine($"Nombre ingresado: {nombre.count}\n Cantidad: {nombre.name}\nPosiblles nacionalidades:");
//var salida;
foreach (var country in nombre.country)
{
    //salida = country.probability.
    Console.WriteLine($"Identificacion de país: {country.country_id} - Probabilidad: {country.probability}");
}

Console.WriteLine("Fin del programa.");