namespace Develop05;

public class ChecklistGoal : Goal {
    private int _bonus;
    private int _numComplete;
    private int _totalRequired;

    public ChecklistGoal(string title, string description, int points, int bonus, int totalRequired) : base(title, description, points) {
        _bonus = bonus;
        _numComplete = 0;
        _totalRequired = totalRequired;
    }

    public ChecklistGoal(string title, string description, int points, int bonus, int numComplete, int totalRequired) : base(title, description, points) {
        _bonus = bonus;
        _numComplete = numComplete;
        _totalRequired = totalRequired;
    }

    public override string GetDisplayString() {
        return
            $"{Title} ({Description}) -- Currently completed: {NumComplete}/{TotalRequired}";
    }

    public override string GetSaveString() {
        return
            $"ChecklistGoal:{Title},{Description},{Points},{Bonus},{NumComplete},{TotalRequired}";
    }

    public int Bonus {
        get => _bonus;
        set => _bonus = value;
    }

    public int NumComplete {
        get => _numComplete;
        set => _numComplete = value;
    }

    public int TotalRequired {
        get => _totalRequired;
        set => _totalRequired = value;
    }
}