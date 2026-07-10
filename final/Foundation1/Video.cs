namespace Foundation1;

public class Video {
    private String _title;
    private String _author;
    private Duration _length;
    private List<Comment> _comments;

    public Video(string title, string author, Duration length) {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public int GetCommentsCount() {
        return Comments.Count;
    }

    public void Display() {
        Console.Write($"{Title} \n{Author} :: {Length.Display()}\nComments: ({GetCommentsCount()})\n");
        foreach (Comment comment in Comments) {
            comment.Display();
        }
        Console.WriteLine("\n---\n");
    }

    public string Title {
        get => _title;
        set => _title = value;
    }

    public string Author {
        get => _author;
        set => _author = value;
    }

    public Duration Length {
        get => _length;
        set => _length = value;
    }

    public List<Comment> Comments {
        get => _comments;
        set => _comments = value;
    }
}