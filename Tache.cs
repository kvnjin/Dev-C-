public class Tache
{
    public bool IsTaskDone { get; set; }
    public string Task { get; set; }

    public Tache(string task)
    {
        Task = task;
    }
}