public static class AccidentalHelper
{
    public static string GetAccidental(this Accidental accidental) =>
        accidental switch
        {
            Accidental.Sharp => "#",
            Accidental.Flat => "♭",
            _ => ""
        };
}
