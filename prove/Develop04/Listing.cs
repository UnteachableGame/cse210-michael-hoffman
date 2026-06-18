namespace Develop04;

public class Listing : Activity {

    protected List<String> _prompts;
    private List<String> _savedResponses;
    private List<String> _usedPrompts;

    public Listing(string instruction, int duration, int timesDone, List<string> prompts) : base(instruction, duration, timesDone) {
        _prompts = prompts;
        _savedResponses = new List<string>();
        _usedPrompts = new List<string>();
        TimesDone += 1;
    }

    public List<string> Prompts {
        get => _prompts;
    }

    public List<string> SavedResponses {
        get => _savedResponses;
    }

    public List<string> UsedPrompts {
        get => _usedPrompts;
    }

    public void Begin() {
        StartActivity();
        String prompt = PickRandomPrompt(Prompts, UsedPrompts);
        UsedPrompts.Add(prompt);

        if (prompt != "No More!") {
            Console.WriteLine("List as many responses you can to the following prompt:\n" +
                              $" --- {prompt} --- ");
            CountdownAnimation("You may being in:", 5);
        
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(Duration);

            String currentSentence = "";
            Console.Write("\n> ");
        
            while (DateTime.Now < futureTime) {
                if (Console.KeyAvailable) {
                    ConsoleKeyInfo info = Console.ReadKey(false);

                    switch (info.Key) {
                        case ConsoleKey.Enter:
                            Console.WriteLine();
                            SavedResponses.Add(currentSentence);
                    
                            currentSentence = "";
                            Console.Write("> ");
                            break;
                        case ConsoleKey.Backspace:
                            if (currentSentence.Length == 0) {
                                currentSentence = currentSentence.Remove(currentSentence.Length - 1);
                                Console.Write("\b \b");
                            }
                            break;
                        default:
                            currentSentence += info.KeyChar;
                            break;
                    }
                }
                Thread.Sleep(20);
            }

            Console.WriteLine();
        
            EndActivity("Listing");
        } else {
            Console.WriteLine("\nThere are no more prompts to use! You will be sent back to the main menu.");
            Animate(2);
        }
    }
}