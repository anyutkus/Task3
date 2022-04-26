public static class NoteHelper
{
    public static string GetNote(this Note note) =>
        note switch
        {
            Note.C => "C",
            Note.D => "D",
            Note.E => "E",
            Note.F => "F",
            Note.G => "G",
            Note.A => "A",
            Note.B => "B",
            _ => ""
        };
}
