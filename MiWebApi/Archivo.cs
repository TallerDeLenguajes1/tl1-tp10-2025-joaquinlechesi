namespace MiWebApi;

public static class Archivo
{
    public static void escribirArchivoJson(string ruta, string stringJson)
    {
        FileStream fs = new FileStream(ruta, FileMode.Create);
        using (StreamWriter sw = new StreamWriter(fs))
        {
            sw.WriteLine(stringJson);
            sw.Close();
        }
    }
}