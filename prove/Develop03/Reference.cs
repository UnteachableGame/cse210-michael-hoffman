namespace Develop03;

public class Reference {
    private String _book;
    private int _chapter;
    private List<int> _verses;

    public Reference(String book, int chapter, params int[] verse) {
        this._book = book;
        this._chapter = chapter;
        this._verses = new List<int>(verse);
    }

    public Reference(String book, int chapter, List<int> verses) {
        this._book = book;
        this._chapter = chapter;
        this._verses = verses;
    }
}