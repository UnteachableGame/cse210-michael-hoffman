namespace Develop04;

public class Breathing : Activity {

    public Breathing(string instruction, int duration, int timesDone) : base(instruction, duration, timesDone) {
        TimesDone += 1;
    }

    public void Begin() {
        StartActivity();
        
        int numberOfBreathes = Duration / 10;
        
        // 10 seconds
        for (int i = 0; i < numberOfBreathes; i++) {
            Console.WriteLine();
            CountdownAnimation("Breathe in...", 4);
            Console.WriteLine();
            CountdownAnimation("Now breathe out...", 6);
            Console.WriteLine();
        }

        EndActivity("Breathing");
        TimesDone += 1;
    }
}