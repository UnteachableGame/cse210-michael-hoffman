namespace Develop04;

public class Reflection : Activity {
    
    protected List<String> _prompts;
    private List<String> _usedPrompts;

    public Reflection(string instruction, int duration, int timesDone, List<string> prompts) : base(instruction, duration, timesDone) {
        _prompts = prompts;
        _usedPrompts = new List<string>();
        TimesDone += 1;
    }

    public List<string> Prompts {
        get => _prompts;
    }

    public List<string> UsedPrompts {
        get => _usedPrompts;
    }

    public void Begin() {
        StartActivity();
        String prompt = PickRandomPrompt(Prompts, UsedPrompts);
        UsedPrompts.Add(prompt);

        if (prompt != "No More!") {
            Console.Write("Consider the following prompt: \n" +
                          $" --- {prompt} --- \n" +
                          "When you have something in mind, press enter to continue.\n");
            Console.ReadKey();

            Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
            CountdownAnimation("You may begin in:", 5);
        
            Console.Clear();

            int splitDuration = Duration / 2;

            Console.Write("> How did you feel when it was complete? ");
            Animate(splitDuration);
            Console.Write("\n> What was your favorite thing about this experience? ");
            Animate(splitDuration);
            Console.WriteLine();
        
            EndActivity("Reflecting");
            TimesDone += 1;
        } else {
            Console.WriteLine("\nThere are no more prompts to use! You will be sent back to the main menu.");
            Animate(2);
        }
    }
}