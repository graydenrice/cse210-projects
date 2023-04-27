public class Resume
{
    public string _personName;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs: ");
        foreach (Job b in _jobs)
        {
            b.DisplayJob();
        }
    }
}