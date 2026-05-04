namespace Learning02;

public class Resume {
    public String _name = "";
    public List<Job> _jobs = new ();

    public void Display() {
        Console.WriteLine($"Name: {_name}\nJobs: ");
        foreach (Job job in _jobs) {
            job.Display();
        }
    }
}