namespace Learning03;

public class Fraction {
    private int top;
    private int bottom;

    public Fraction() {
        top = 1;
        bottom = 1;
    }

    public Fraction(int wholeNumber) {
        top = wholeNumber;
        bottom = 1;
    }

    public Fraction(int top, int bottom) {
        this.top = top;
        this.bottom = bottom;
    }

    public int Top {
        get => top;
        set => top = value;
    }

    public int Bottom {
        get => bottom;
        set => bottom = value;
    }

    public String getFractionString() {
        return top + "/" + bottom;
    }

    public double getDoubleString() {
        return top / bottom;
    }
}