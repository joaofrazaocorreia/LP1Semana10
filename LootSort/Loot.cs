using System;
using System.Collections.Generic;

namespace LootSort
{
    /// <summary>
    /// The Loot class should implement IComparable<Loot>
    /// and override GetHashCode() and Equals()
    /// </summary>
    public class Loot : IComparable<Loot>
{
    /// <summary>Type of loot.</summary>
    public LootType Kind { get; }

    /// <summary>Loot description.</summary>
    public string Description { get; }

    /// <summary>Loot value.</summary>
    public float Value { get; }

    /// <summary>
    /// Create a new instance of loot.
    /// </summary>
    /// <param name="kind">Type of loot.</param>
    /// <param name="description">Loot description.</param>
    /// <param name="value">Loot value.</param>
    public Loot(LootType kind, string description, float value)
    {
        Kind = kind;
        Description = description;
        Value = value;
    }

    /// <summary>
    /// Return a nicely formatted string representing the loot instance.
    /// </summary>
    /// <returns>
    /// A nicely formatted string representing the loot instance.
    /// </returns>
    public override string ToString() =>
        $"[{Kind,15}]\t{Value:f2}\t{Description}";

    public int CompareTo(Loot other)
    {
        if (other == null) return 1;

        int same = this.Kind.ToString().CompareTo(other.Kind.ToString());

        if (same == 0)
            same = other.Value.ToString().CompareTo(this.Value.ToString());

        if (same == 0)
            same = other.Description.CompareTo(this.Description);

        return same;
    }
    
    public override bool Equals(object obj)
    {
        return Equals(obj as Loot);
    }

    public bool Equals(Loot l)
    {
        if (l != null)
            return (this.Kind.ToString() == l.Kind.ToString()) &&
                   (this.Value.ToString() == l.Value.ToString()) &&
                   (this.Description == l.Description);

        else return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Kind, Value, Description);
    }
}
}