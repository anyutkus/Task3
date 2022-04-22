public static class OctaveHelper
{
    public static string GetOctave(this Octave octave) =>
        octave switch
        {
            Octave.SubContra => " (SubContra)",
            Octave.Contra => " (Contra)",
            Octave.Great => " (Great)",
            Octave.Small => " (Small)",
            Octave.First => " (First)",
            Octave.Second => " (Second)",
            Octave.Third => " (Third)",
            Octave.Forth => " (Forth)",
            Octave.Fifth => " (Fifth)",
            _ => ""
        };
}
