using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Develop03;

public class Scripture {
    private List<Word> _scripture;
    private Reference _reference;
    private List<int> _usedWordInts;
    private bool _hasFirstPassed;

    public Scripture(Reference reference, string text) {
        _reference = reference;
        _scripture = new List<Word>();
        _usedWordInts = new List<int>();

        String[] textList = text.Split(" ");
        
        foreach (String word in textList) {
            _scripture.Add(new Word(word));
        }
    }

    public Reference Reference {
        get => _reference;
    }

    public List<int> UsedWordInts {
        get => _usedWordInts;
    }

    public bool HasFirstPassed {
        get => _hasFirstPassed;
        set => _hasFirstPassed = value;
    }

    public List<Word> Scripture1 {
        get => _scripture;
    }

    public void HideWords() {
        int amountOfWordsHiddenPerPress = 3;

        // This loop is to choose three words every press of the enter key to "hide" the words.
        if (HasFirstPassed) {
            for (int i = 0; i < amountOfWordsHiddenPerPress; i++) {
                // Choose a random number in the length of the scripture's words.
                int randomNum = new Random().Next(0, _scripture.Count);

                // Console.WriteLine("First Number: " + randomNum);
                
                // Check for the word if it is already hidden.
                while (UsedWordInts.Contains(randomNum)) {
                    randomNum = new Random().Next(0, _scripture.Count);
                }
                UsedWordInts.Add(randomNum);

                // foreach (int wordInt in UsedWordInts) {
                //     Console.Write(wordInt + ", ");
                // }
                
                // Hides the word using the index in the scripture's words.
                for (int j = 0; j < Scripture1.Count; j++) {
                    if (j == randomNum) {
                        Scripture1[j].Hide();
                    }
                }
            }
        }

        // Display all the text as a whole.
        Display();
    }

    public String Display() {
        // This needs to build the rest of the scripture with the hidden words.
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < Scripture1.Count; i++) {
            Word word = Scripture1[i];
            if (i == Scripture1.Count) {
                sb.Append(word.Text);
            } else {
                sb.Append(word.Text + " ");
            }
        }
        return $"{Reference.Book} {Reference.Chapter}:{Reference.Verses} {sb}";
    }
    
}