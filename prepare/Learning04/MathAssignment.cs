namespace Learning04;

public class MathAssignment : Assignment {
    private String _textbookSection;
    private String _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic) {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public String GetTextbookSection() {
        return _textbookSection;
    }
    
    public void SetTextbookSection(String textbookSection) {
        _textbookSection = textbookSection;
    }
    
    public String GetProblems() {
        return _problems;
    }
    
    public void SetProblems(String problems) {
        _problems = problems;
    }

    public String GetHomeworkList() {
        return $"Section {GetTextbookSection()} - Problems {GetProblems()}";
    }
}