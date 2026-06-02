namespace Learning04;

public class Assignment {
    private String _studentName;
    private String _topic;

    public Assignment(string studentName, string topic) {
        _studentName = studentName;
        _topic = topic;
    }

    public String GetStudentName() {
        return _studentName;
    }

    public void SetStudentName(String studentName) {
        _studentName = studentName;
    }
    
    public String GetTopic() {
        return _studentName;
    }

    public void SetTopic(String topic) {
        _topic = topic;
    }

    public String GetSummary() {
        return $"{GetStudentName()} - {GetTopic()}";
    }
}