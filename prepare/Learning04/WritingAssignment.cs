namespace Learning04;

public class WritingAssignment : Assignment {
    private String _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic) {
        _title = title;
    }

    public String GetTitle() {
        return _title;
    }

    public void SetTitle(String title) {
        _title = title;
    }

    public String GetWritingInformation() {
        return $"{GetTitle()} by {GetStudentName()}";
    }
}