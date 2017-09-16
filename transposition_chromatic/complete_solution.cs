enum Notes
{
    C = 0,
    CS,
    D,
    DS,
    E,
    F,
    FS,
    G,
    GS,
    A,
    AS,
    B,
}

class Harmonizer
{
    public string Transpose(string note, int transposition)
    {
        int noteVal = Enum.Parse();
        noteVal += transposition;

        while (noteVal < 0)
        {
            noteVal += 12;
        }

        while (noteVal >= 12)
        {
            noteVal -= 12;
        }

        return noteVal;
    }
}