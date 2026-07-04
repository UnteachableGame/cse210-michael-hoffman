using Develop05;

internal class Program {
    private static User _user;

    /* Extra creativity for the project:
        Created an extra class called User that contains the list of goals that they have and the amount of points that they have too.
        Added a way to edit any goal that is made in the goals list for the user.
    */

    private static void Main(string[] args) {
        _user = new User(new List<Goal>(), 0);

        bool isGoalProgramActive = true;

        while (isGoalProgramActive) {
            Console.Clear();

            // Display the points that the user has.

            String response = ReadInput("Menu Options:\n" +
                                        "    1. Create New Goal\n" +
                                        "    2. List Goals and Points\n" +
                                        "    3. Save Goals\n" +
                                        "    4. Load Goals\n" +
                                        "    5. Edit Goals\n" +
                                        "    6. Record Event\n" +
                                        "    7. Quit\n" +
                                        "Select a choice from the menu: (1-7) ");

            switch (response) {
                case "1":
                    // 1. Create a new goal
                    String goalResponse = ReadInput("\nThe types of goals are:\n" +
                                                    "    1. Simple Goal\n" +
                                                    "    2. Eternal Goal\n" +
                                                    "    3. Checklist Goal\n" +
                                                    "Which type of goal would you like to create? ");
                    String goalName;
                    String goalDescription;
                    int goalPointsInt;

                    switch (goalResponse) {
                        case "1":
                            goalName = ReadInput("What is the name of your goal? ");
                            goalDescription = ReadInput("What is a short description for this goal? ");
                            goalPointsInt =
                                int.Parse(ReadInput("How many points would you like the associate with this goal? "));

                            _user.Goals.Add(new Goal(goalName, goalDescription, goalPointsInt));
                            break;
                        case "2":
                            goalName = ReadInput("What is the name of your goal? ");
                            goalDescription = ReadInput("What is a short description for this goal? ");
                            goalPointsInt =
                                int.Parse(ReadInput("How many points would you like the associate with this goal? "));

                            _user.Goals.Add(new EternalGoal(goalName, goalDescription, goalPointsInt));
                            break;
                        case "3":
                            goalName = ReadInput("What is the name of your goal? ");
                            goalDescription = ReadInput("What is a short description for this goal? ");
                            goalPointsInt =
                                int.Parse(ReadInput("How many points would you like the associate with this goal? "));
                            int goalBonusFrequencyAmount =
                                int.Parse(ReadInput(
                                    "How many times does this goal need to be accomplished for a bonus? "));
                            int bonusPointsInt =
                                int.Parse(ReadInput("What is the bonus for accomplishing it that many times? "));

                            _user.Goals.Add(new ChecklistGoal(goalName, goalDescription, goalPointsInt, bonusPointsInt,
                                goalBonusFrequencyAmount));
                            break;
                    }

                    Console.WriteLine("\nGoal Saved!");
                    Thread.Sleep(1500);
                    break;
                case "2":
                    DisplayGoals();
                    Console.Write("\nPress enter to go back to the main screen!");
                    Console.ReadKey();
                    break;
                case "3":
                    if (_user.Goals.Count > 0) {
                        Save(_user.Goals, _user.Points, ReadInput("What will be the file name for the goal file? "));
                        Console.WriteLine("\nFile has saved successfully!");
                        Thread.Sleep(1500);
                    } else {
                        Console.WriteLine("There are no goals that are created or loaded!");
                        Thread.Sleep(1500);
                    }
                    break;
                case "4":
                    Load(ReadInput("What was the file name for the goal file? "));
                    Console.WriteLine("\nFile has loaded successfully!");
                    Thread.Sleep(1500);
                    break;
                case "5":
                    if (_user.Goals.Count > 0) {
                        Goal editGoal = DisplayAndAccessGoal("Which goal would you like to edit? ");

                        Console.WriteLine("Which part of the goal would you like to edit? ");
                        if (editGoal is EternalGoal eternalGoal) {
                            Console.WriteLine($"1. Edit Title :: {eternalGoal.Title}\n" +
                                              $"2. Edit Description :: {eternalGoal.Description}\n" +
                                              $"3. Edit Points :: {eternalGoal.Points}");
                            String editResponse = ReadInput("Which part would you like to edit? ");
                            String editingResponse = ReadInput("What would you like to change it to? ");
                            switch (editResponse) {
                                case "1":
                                    eternalGoal.Title = editingResponse;
                                    break;
                                case "2":
                                    eternalGoal.Description = editingResponse;
                                    break;
                                case "3":
                                    eternalGoal.Points = int.Parse(editingResponse);
                                    break;
                            }
                        } else if (editGoal is ChecklistGoal checklistGoal) {
                            Console.WriteLine($"1. Edit Title\n" +
                                              $"2. Edit Description\n" +
                                              $"3. Edit Points\n" +
                                              $"4. Edit Times Completed\n" +
                                              $"5. Edit Times Required to Complete\n" +
                                              $"6. Edit Bonus Points");
                            String editResponse = ReadInput("Which part would you like to edit? ");
                            String editingResponse = ReadInput("What would you like to change it to? ");
                            switch (editResponse) {
                                case "1":
                                    checklistGoal.Title = editingResponse;
                                    break;
                                case "2":
                                    checklistGoal.Description = editingResponse;
                                    break;
                                case "3":
                                    checklistGoal.Points = int.Parse(editingResponse);
                                    break;
                                case "4":
                                    checklistGoal.NumComplete = int.Parse(editingResponse);
                                    break;
                                case "5":
                                    checklistGoal.TotalRequired = int.Parse(editingResponse);
                                    break;
                                case "6":
                                    checklistGoal.Bonus = int.Parse(editingResponse);
                                    break;
                            }
                        } else {
                            Console.WriteLine($"1. Edit Title\n" +
                                              $"2. Edit Description\n" +
                                              $"3. Edit Points\n" +
                                              $"4. Edit If Completed");
                            String editResponse = ReadInput("Which part would you like to edit? ");
                            String editingResponse =
                                ReadInput("What would you like to change it to? (If completed, mark T/F) ");
                            switch (editResponse) {
                                case "1":
                                    editGoal.Title = editingResponse;
                                    break;
                                case "2":
                                    editGoal.Description = editingResponse;
                                    break;
                                case "3":
                                    editGoal.Points = int.Parse(editingResponse);
                                    break;
                                case "4":
                                    if (editingResponse == "T") {
                                        editGoal.Completed = true;
                                    } else if (editingResponse == "F") {
                                        editGoal.Completed = false;
                                    } else {
                                        Console.WriteLine("That was not a T or a F!!");
                                    }
                                    break;
                            }
                        }
                        Save(_user.Goals, _user.Points, ReadInput("What will be the file name for the goal file? "));

                        Console.WriteLine("\nGoal has been successfully edited and saved!");
                        Thread.Sleep(1500);
                    } else {
                        Console.WriteLine("There are no goals that are created or loaded!");
                        Thread.Sleep(1500);
                    }
                    break;
                case "6":
                    if (_user.Goals.Count > 0) {
                        Goal goalAccomplished = DisplayAndAccessGoal("Which goal did you accomplish? ");
                        if (goalAccomplished is ChecklistGoal checklistGoal1) {
                            if (checklistGoal1.NumComplete >= checklistGoal1.TotalRequired) {
                                Console.WriteLine("You can't check this goal off again!");
                                Thread.Sleep(1500);
                                break;
                            }
                        }
                        
                        Console.WriteLine($"\nCongratulations! You have earned {goalAccomplished.Points} points!");
                        if (goalAccomplished is not EternalGoal) {
                            if (goalAccomplished is ChecklistGoal checklistGoal) {
                                if (checklistGoal.NumComplete >= checklistGoal.TotalRequired - 1) {
                                    checklistGoal.NumComplete += 1;
                                    checklistGoal.Completed = true;
                                } else {
                                    checklistGoal.NumComplete += 1;
                                }
                            } else {
                                goalAccomplished.Completed = true;
                            }
                        }

                        _user.Points += goalAccomplished.Points;
                        Console.WriteLine($"You now have {_user.Points} points!");
                        Save(_user.Goals, _user.Points, ReadInput("What will be the file name for the goal file? "));
                    
                        Console.WriteLine("\nGoal has been successfully edited and saved!");
                        Thread.Sleep(1500);
                    } else {
                        Console.WriteLine("There are no goals that are created or loaded!");
                        Thread.Sleep(1500);
                    }
                    break;
                case "7":
                    isGoalProgramActive = false;
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("That isn't a number between 1 through 7, silly!");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }

    public static String ReadInput(String input) {
        Console.Write(input);
        return Console.ReadLine();
    }

    public static Goal DisplayAndAccessGoal(String input) {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _user.Goals.Count; i++) {
            Goal goal = _user.Goals[i];
            Console.WriteLine($"{i + 1}. {goal.Title}");
        }

        int goalInt = int.Parse(ReadInput(input));

        Goal userGoal = null;
        for (int i = 0; i < _user.Goals.Count; i++) {
            if (goalInt == i + 1) {
                userGoal = _user.Goals[i];
            }
        }

        if (userGoal == null) {
            return null;
        }

        return userGoal;
    }

    public static void DisplayGoals() {
        Console.WriteLine($"\nYour total points are: {_user.Points}");
        
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _user.Goals.Count; i++) {
            Goal goal = _user.Goals[i];

            if (goal == null) continue;
            String isCompletedX = "N";
            if (goal.Completed) {
                isCompletedX = "X";
            }

            if (goal is EternalGoal eternalGoal) {
                Console.WriteLine($"{i + 1}. [{isCompletedX}] " + eternalGoal.GetDisplayString());
            } else if (goal is ChecklistGoal checklistGoal) {
                Console.WriteLine($"{i + 1}. [{isCompletedX}] " + checklistGoal.GetDisplayString());
            } else {
                Console.WriteLine($"{i + 1}. [{isCompletedX}] " + goal.GetDisplayString());
            }
        }
    }

    public static void Save(List<Goal> goals, int points, String file) {
        file = "../../../" + file;

        using StreamWriter writer = new StreamWriter(file);
        writer.WriteLine(points);

        foreach (Goal goal in goals) {
            if (goal is EternalGoal eternalGoal) {
                writer.WriteLine(eternalGoal.GetSaveString());
            } else if (goal is ChecklistGoal checklistGoal) {
                writer.WriteLine(checklistGoal.GetSaveString());
            } else {
                writer.WriteLine(goal.GetSaveString());
            }
        }

        writer.Close();
    }

    public static void Load(String file) {
        file = "../../../" + file;
        string[] lines = File.ReadAllLines(file);

        // Set points from first line
        _user.Points = int.Parse(lines[0]);

        // Start loop from 1 to skip the points line
        for (int i = 1; i < lines.Length; i++) {
            string line = lines[i];
            if (!line.Contains(':')) continue;

            string[] typeOfGoal = line.Split(":");
            string[] goalInfo = typeOfGoal[1].Split(",");
            
            switch (typeOfGoal[0]) {
                case "SimpleGoal":
                    _user.Goals.Add(new Goal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]),
                        bool.Parse(goalInfo[3])));
                    break;
                case "EternalGoal":
                    _user.Goals.Add(new EternalGoal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2])));
                    break;
                case "ChecklistGoal":
                    _user.Goals.Add(new ChecklistGoal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]),
                        int.Parse(goalInfo[3]), int.Parse(goalInfo[4]), int.Parse(goalInfo[5])));
                    break;
            }
        }
    }
}