namespace Develop03;

public class Scripture {
    private List<Word> _scripture = new ();
    private Reference _reference;

    public Scripture(String text, String book, int chapter, int verse) {
        _scripture = 
        _reference = new Reference(book, chapter, verse);
    }
}