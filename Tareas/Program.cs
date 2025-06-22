using System.Text.Json;
using Tareas;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nConsumo de API.");

HttpClient client = new HttpClient(); //Clase HttpClient

string url = "https://jsonplaceholder.typicode.com/todos/";
Console.WriteLine($"API a consumir:\n{url}");
HttpResponseMessage response = await client.GetAsync(url); //Para enviar una peticion GET de forma asincronica
response.EnsureSuccessStatusCode(); //Metodo del objeto de respuesta (HttpResponseMessage) para verificar si la peticion fue exitosa (ej. codigo 200 OK)

string responseBody = await response.Content.ReadAsStringAsync();  //Metodo del contenido de la respuesta (HttpClient) para leer el cuerpo del mensaje como un string
List<Tarea> tareas = JsonSerializer.Deserialize<List<Tarea>>(responseBody);
Console.WriteLine("TAREAS NO COMPLETADAS");
foreach (var tarea in tareas)
{
    if (!tarea.completed)
    {
        Console.WriteLine($"TITULO: {tarea.title} - ESTADO: {tarea.completed}");
    }
}

List<Tarea> tareasCompletadas = new List<Tarea>();
Console.WriteLine("TAREAS COMPLETADAS");
foreach (var tarea in tareas)
{
    //Tarea nuevaTarea = new Tarea(tarea.userId, tarea.id, tarea.title, tarea.completed);
    if (tarea.completed)
    {
        Tarea nuevaTarea = new Tarea { userId = tarea.id, id = tarea.id, title = tarea.title, completed = tarea.completed }; // Trabajando sin metodo CONSTRUCTOR
        tareasCompletadas.Add(nuevaTarea);
        Console.WriteLine($"TITULO: {tarea.title} - ESTADO: {tarea.completed}");
    }
}
string jsonString = JsonSerializer.Serialize<List<Tarea>>(tareasCompletadas);

// Crear archivo
string nombreArchivo = "tareas.json";
string ruta = "C:\\Users\\joaqu\\Facultad\\2025\\Taller de Lenguajes I\\Semana_10\\tl1-tp10-2025-joaquinlechesi\\Tareas\\";
StreamWriter nuevoArchivo = new StreamWriter(ruta + nombreArchivo);
nuevoArchivo.WriteLine(jsonString);
nuevoArchivo.Close();
Console.WriteLine("Fin del programa.");