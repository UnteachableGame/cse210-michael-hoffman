using Develop04;

internal class Program {
    private static void Main(string[] args) {
        bool isExperienceActive = true;
        
        Breathing breathingActivity = new Breathing("", 0, 0);
        Reflection reflectionActivity = new Reflection("", 0, 0, new List<string>());
        Listing listingActivity = new Listing("", 0, 0, new List<string>());
        while (isExperienceActive) {
            Console.Clear();
        
            Console.Write("Menu Options:\n" +
                              "1. Start breathing activity\n" +
                              "2. Start reflecting activity\n" +
                              "3. Start listening activity\n" +
                              "4. View stats of your activities\n" +
                              "5. Quit\n" +
                              "Select a choice from the menu: ");
            String userOption = Console.ReadLine();
        
            Console.Clear();
            
            String instruction;
            switch (userOption) {
                case "breathing" or "1":
                    instruction = "Welcome to the Breathing Activity,\n\n" +
                                  "This activity will help you relax by walking your though your breathing " +
                                  "in and out slowly. Clear your mind and focus on your breathing.";
                
                    breathingActivity = new Breathing(instruction, 0, -1);
                    breathingActivity.Begin();
                    break;
                case "reflecting" or "2":
                    instruction = "Welcome to the Reflecting Activity,\n\n" +
                                  "This activity will help you reflect on times in your life when you have shown " +
                                  "strength and resilence. This will help you recognize the power you have and " +
                                  "how you can use it in other aspects of your life.";

                    reflectionActivity = new Reflection(instruction, 0, -1, 
                        new List<string>([
                            "Think of a time when a project or plan you worked hard on completely failed or fell apart. " +
                            "What was your immediate reaction, and how did you pivot or rebuild from that point?", 
                            "Think of a time when you had to learn a complex new skill or technology completely on your own. " +
                            "What was the most frustrating hurdle you encountered early on, and how did you break it down " +
                            "to understand it?", 
                            "Think of a time when you received tough, critical feedback about your work or actions. " +
                            "How did you process that critique emotionally, and what specific adjustments did you make " +
                            "because of it?", 
                            "Think of a time when you had to balance multiple high-stress responsibilities at once " +
                            "(like work, school, or personal emergencies). How did you manage your time, and what did " +
                            "you learn about your own limits?",
                            "Think of a time when you had to make a major decision with very little information or guidance. " +
                            "What guided your choices in that moment, and how do you view the outcome now?"]));
                    reflectionActivity.Begin();
                    break;
                case "listening" or "3":
                    instruction = "Welcome to the Listing Activity\n\n" +
                                  "This activity will help you reflect on the good things in your life by having you" +
                                  "list as many things as you can in a certain area.";

                    listingActivity = new Listing(instruction, 0, -1, 
                        new List<string>([
                        "List as many things as you can that used to feel incredibly intimidating or difficult to you, " +
                        "but now feel completely routine and easy.",
                        "List as many moments as you can where you had to make a quick decision under pressure. " +
                        "Which ones are you proud of, and which ones would you change?",
                        "List as many personal rules, habits, or mindsets as you can that you have completely " +
                        "outgrown or abandoned over the last few years.",
                        "List as many instances as you can where a piece of critical feedback or a sudden failure " +
                        "actually redirected you toward a much better outcome.", 
                        "List as many hidden skills, strengths, or positive traits as you can that you only discovered " +
                        "you possessed after being pushed into a high-stress situation."]));
                    listingActivity.Begin();
                    break;
                case "view" or "4":
                    Console.Clear();
                    Thread.Sleep(250);
                    Console.WriteLine("Here are you stats:\n");
                    Thread.Sleep(2000);
                    Console.WriteLine("Activities:");
                    Thread.Sleep(1000);
                    Console.WriteLine(" - Breathing: " + breathingActivity.TimesDone);
                    Thread.Sleep(1000);
                    Console.WriteLine(" - Reflecting: " + reflectionActivity.TimesDone);
                    Thread.Sleep(1000);
                    Console.WriteLine(" - Listing: " + listingActivity.TimesDone);
                    Thread.Sleep(1000);

                    Console.WriteLine("\nPress enter when you would like to return back to the main screen.");
                    Console.ReadKey();
                    break;
                case "quit" or "5":
                    isExperienceActive = false;
                    break;
            }
        }
    }
}