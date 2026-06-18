namespace Develop04;

public class Activity {
    protected String _instruction;
    protected int _duration;
    protected int _timesDone;

    public Activity(string instruction, int duration, int timesDone) {
        _instruction = instruction;
        _duration = duration;
        _timesDone = timesDone;
    }

    public string Instruction {
        get => _instruction;
    }

    public int Duration {
        get => _duration;
        set => _duration = value;
    }

    public int TimesDone {
        get => _timesDone;
        set => _timesDone = value;
    }

    public void StartActivity() {
        Console.Clear();
        
        // Give the instruction and asks for the seconds in a user prompts.
        Console.WriteLine(Instruction);
        Console.Write("\nHow long, in seconds, would you for your session? ");
        String duration = Console.ReadLine();
        Duration = int.Parse(duration);
        
        Console.Clear();
        
        // Start the activity with an animation.
        Console.WriteLine("Get ready...");
        Animate(5);

        Console.WriteLine(" ");
    }

    public void EndActivity(String activity) {
        Console.WriteLine("\nWell done!!");
        Animate(5);

        Console.WriteLine($"\nYou have completed another {Duration} seconds of the {activity} Activity.");
        Animate(5);
    }
    
    protected void Animate(int duration) {
        for (int i = 0; i < duration; i++) {
            TimeAndCharacterAnimate('+', 750);
            TimeAndCharacterAnimate('-', 500);
        }
    }

    private void TimeAndCharacterAnimate(char character, int timeInMilliseconds) {
        Console.Write(character);
        Thread.Sleep(timeInMilliseconds);
        Console.Write("\b \b");
    }

    protected void CountdownAnimation(string display, int duration) {
        for (int i = duration; i > 0; i--) {
            Console.Write($"\r{display} {duration}");
            duration -= 1;
            Thread.Sleep(1000); // This waits for 1 second = 1000 milliseconds.
        }
        Console.Write($"\r{display}  ");
        Thread.Sleep(1000); // 1 second
    }
    
    protected String PickRandomPrompt(List<String> prompts, List<String> checkingList) {
        int randomNum = new Random().Next(1, prompts.Count);
        
        for (int i = 1; i < prompts.Count; i++) {
            if (i == randomNum) {
                if (!checkingList.Contains(prompts[i])) {
                    return prompts[i];
                } else {
                    return "No More!";
                }
            }
        }
        return null;
    }
}