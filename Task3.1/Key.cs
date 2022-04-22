using System;
using System.Collections.Generic;

public struct Key : IComparable<Key>
{
    private Octave _octave;
    private Note _note;
    private Accidental _accidental;

    public Key(Note note, Octave octave, Accidental accidental = Accidental.None)
    {
        _octave = octave;
        _note = note;
        _accidental = accidental;
    }

    public override string ToString() => (_note.GetNote() + _accidental.GetAccidental() + _octave.GetOctave());

    public override bool Equals(object obj)
    {
        if ((obj is Key key) && (this.ToKey() == key.ToKey()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
 
    public override int GetHashCode()
    {
        return ToKey().GetHashCode();
    }

    public double ToKey()
    {
        double code = (int)_octave * 7 + (int)_note;
        bool isCFNote = (_note == Note.C) || (_note == Note.F);
        bool isBENote = (_note == Note.B) || (_note == Note.E);

        if ((isCFNote && _accidental == Accidental.Flat) || (isBENote && _accidental == Accidental.Sharp))
        {
            code += (int)_accidental;
        }
        else
        {
            code += (int)_accidental * 0.5;
        }

        return code;
    }

    public int CompareTo(Key key)
    {
        double keyIndex = key.ToKey();

        return this.ToKey().CompareTo(keyIndex);
    }
}
