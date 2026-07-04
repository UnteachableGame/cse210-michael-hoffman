namespace Develop05;

public class Goal {
    protected String _title;
    protected String _description;
    protected int _points;
    protected bool _completed;

    public Goal(string title, string description, int points) {
        _title = title;
        _description = description;
        _points = points;
        _completed = false;
    }

    public Goal(string title, string description, int points, bool completed) {
        _title = title;
        _description = description;
        _points = points;
        _completed = completed;
    }

    public virtual String GetDisplayString() {
        return $"{Title} ({Description})";
    }

    public virtual String GetSaveString() {
        return $"SimpleGoal:{Title},{Description},{Points},{Completed}";
    }

    public string Title {
        get => _title;
        set => _title = value;
    }

    public string Description {
        get => _description;
        set => _description = value;
    }

    public int Points {
        get => _points;
        set => _points = value;
    }

    public bool Completed {
        get => _completed;
        set => _completed = value;
    }
}