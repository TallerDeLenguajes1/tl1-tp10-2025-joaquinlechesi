using System.Text.Json;
using Usuarios;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Consumo de API\n");

HttpClient client = new HttpClient(); //Clase HttpClient

string url = "https://jsonplaceholder.typicode.com/users/";
Console.WriteLine($"API a consumir:\n{url}");
HttpResponseMessage response = await client.GetAsync(url); //Para evitar una peticion GET de forma asincronica
response.EnsureSuccessStatusCode(); //Metodo del objeto de respuesta (HttpResponseMessage) para verificar si la peticion fue exitosa (ej. codigo 200 OK)

string responseBody = await response.Content.ReadAsStringAsync(); //Metodo del contenido de la respuesta (HttpClient) para leer el cuerpo del mensaje como un string
List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(responseBody);
Console.WriteLine("RESULTADOS:");
int contador = 1; //Uso el "contador" en lugar de "usuario.id" por si los numeros de usuarios no vienen ordenados
foreach (var usuario in usuarios)
{
    if (contador < 6)
    {
        Console.WriteLine($"NONBRE: {usuario.name} - CORREO ELECTRONICO: {usuario.email} - DOMICILIO: {usuario.address.street} - {usuario.address.city}");
        contador++;
    }
}
