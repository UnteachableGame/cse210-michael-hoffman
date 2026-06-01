namespace Learning04;

public class Assignment {
    private String _studentName = "";
    private String _topic = "";

    public Assignment(string studentName, string topic) {
        _studentName = studentName;
        _topic = topic;
    }

    public string StudentName {
        get => _studentName;
        set => _studentName = value;
    }

    public string Topic {
        get => _topic;
        set => _topic = value;
    }

    public String GetSummary() {
        return $"Student Name: {_studentName}; Topic: {_topic}";
    }
}