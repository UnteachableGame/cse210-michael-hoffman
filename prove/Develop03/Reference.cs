namespace Develop03;

public class Reference {
    private String _book;
    private int _chapter;
    private String _verses;

    public Reference(String book, int chapter, String verses) {
        this._book = book;
        this._chapter = chapter;
        this._verses = verses;
    }
    
    public String Book {
        get => _book;
        set => _book = value;
    }
    
    public int Chapter {
        get => _chapter;
        set => _chapter = value;
    }
    
    public String Verses {
        get => _verses;
        set => _verses = value;
    }
}