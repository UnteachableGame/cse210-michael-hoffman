namespace Develop05;

public class User {
    private List<Goal> _goals;
    private int points;

    public User(List<Goal> goals, int points) {
        _goals = goals;
        this.points = points;
    }

    public List<Goal> Goals {
        get => _goals;
    }

    public int Points {
        get => points;
        set => points = value;
    }
}