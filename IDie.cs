namespace DiceGame;

/// <summary>
/// This is an Interface.  It allows us to create a standard
/// way to create more versatile object models.
/// This interface is defining the abstract notion of a Die.
/// The only essential elements are that a Die `has` a
/// number of Sides; and you can `Roll` a Die to get a number.
///
/// The IDie interface does not tell anyone HOW that gets done
/// It only declares that it CAN be done.
/// </summary>
public interface IDie
{
    /// <summary>
    /// How many Sides on a Die
    /// </summary>
    public int SideCount { get; }
    
    /// <summary>
    /// Roll this Die!
    /// </summary>
    /// <returns>
    /// a random int between 1 and SideCount inclusive.
    /// </returns>
    public int Roll();
}