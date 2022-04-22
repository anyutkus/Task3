using System;

class Program
{
    public static void Main()
    {
        var key1 = new Key(Note.C, Octave.First, Accidental.Flat);
        var key2 = new Key(Note.D, Octave.First, Accidental.Flat);

        Console.WriteLine(key1.ToString());
        Console.WriteLine(key2.ToString());

        Console.WriteLine(key1.Equals(key2));
        Console.WriteLine(key1.GetHashCode());
        Console.WriteLine(key2.GetHashCode());
        Console.WriteLine(key1.CompareTo(key2));
        Console.WriteLine(key2.CompareTo(key1));

        Console.WriteLine(key1.ToKey());
        Console.WriteLine(key2.ToKey());

        var key3 = new Key(Note.E, Octave.First, Accidental.Sharp);
        var key4 = new Key(Note.F, Octave.First, Accidental.None);

        Console.WriteLine(key3.ToString());
        Console.WriteLine(key4.ToString());

        Console.WriteLine(key3.Equals(key4));
        Console.WriteLine(key3.GetHashCode());
        Console.WriteLine(key4.GetHashCode());
        Console.WriteLine(key3.CompareTo(key4));
        Console.WriteLine(key4.CompareTo(key3));

        Console.WriteLine(key3.ToKey());
        Console.WriteLine(key4.ToKey());

        var key5 = new Key(Note.B, Octave.Small);

        Console.WriteLine(key5.ToString());
        Console.WriteLine(key1.ToString());

        Console.WriteLine(key5.Equals(key1));
        Console.WriteLine(key5.GetHashCode());
        Console.WriteLine(key1.GetHashCode());
        Console.WriteLine(key5.CompareTo(key1));
        Console.WriteLine(key1.CompareTo(key5));

        Console.WriteLine(key5.ToKey());
        Console.WriteLine(key1.ToKey());

        var key6 = new Key(Note.G, Octave.Fifth, Accidental.Sharp);
        var key7 = new Key(Note.A, Octave.SubContra, Accidental.Flat);

        Console.WriteLine(key6.ToString());
        Console.WriteLine(key7.ToString());

        Console.WriteLine(key6.Equals(key7));
        Console.WriteLine(key6.GetHashCode());
        Console.WriteLine(key7.GetHashCode());
        Console.WriteLine(key6.CompareTo(key7));
        Console.WriteLine(key7.CompareTo(key6));

        Console.WriteLine(key6.ToKey());
        Console.WriteLine(key7.ToKey());
    }
}
