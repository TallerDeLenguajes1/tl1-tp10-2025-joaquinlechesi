namespace Tareas;

public class Tarea
{
    public int userId { get; set; }
    public int id { get; set; }
    public string title { get; set; }
    public bool completed { get; set; }
    // public Tarea(int userId_const, int id_const, string title_const, bool completed_const)
    // {
    //     this.userId = userId_const;
    //     this.id = id_const;
    //     this.title = title_const;
    //     this.completed = completed_const;
    // }
}