using System.Text.Json;
using Tareas;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nConsumo de API.");

HttpClient client = new HttpClient();

string url = "https://jsonplaceholder.typicode.com/todos/";
HttpResponseMessage response = await client.GetAsync(url);
response.EnsureSuccessStatusCode();

string responseBody = await response.Content.ReadAsStringAsync();
List<Tarea> tareas = JsonSerializer.Deserialize<List<Tarea>>(responseBody);
Console.WriteLine("TAREAS NO COMPLETADAS");
foreach (var tarea in tareas)
{
    if (!tarea.completed)
    {
        Console.WriteLine($"TITULO: {tarea.title} - ESTADO: {tarea.completed}");
    }
}
Console.WriteLine("TAREAS COMPLETADAS");
foreach (var tarea in tareas)
{
    if (tarea.completed)
    {
        Console.WriteLine($"TITULO: {tarea.title} - ESTADO: {tarea.completed}");
    }
}