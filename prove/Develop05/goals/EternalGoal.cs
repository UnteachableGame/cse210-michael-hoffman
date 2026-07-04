namespace Develop05;

public class EternalGoal : Goal {

    public EternalGoal(string title, string description, int points) : base(title, description, points) {
    }

    public override string GetDisplayString() {
        return $"{Title} ({Description})";
    }

    public override String GetSaveString() {
        return $"EternalGoal:{Title},{Description},{Points}";
    }
}