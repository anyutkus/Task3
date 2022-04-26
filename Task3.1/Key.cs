using System;
using System.Collections.Generic;

public struct Key : IComparable<Key>
{
    private Octave _octave;
    private Note _note;
    private Accidental _accidental;

    public Key(Note note, Octave octave, Accidental accidental = Accidental.None)
    {
        _octave = Enum.IsDefined(typeof(Octave), octave) ? octave : 0;
        _note = Enum.IsDefined(typeof(Note), note) ? note : 0;
        _accidental = Enum.IsDefined(typeof(Accidental), accidental) ? accidental : 0;
    }

    public override string ToString() => (_note.GetNote() + _accidental.GetAccidental() + _octave.GetOctave());

    public override bool Equals(object obj) => (obj is Key key) && (this.ToKey() == key.ToKey());
 
    public override int GetHashCode() => ToKey().GetHashCode();

    public int ToKey() => (int)_octave * 12 + (int)_note + (int)_accidental;

    public int CompareTo(Key key)
    {
        var keyIndex = key.ToKey();

        return this.ToKey().CompareTo(keyIndex);
    }
}
