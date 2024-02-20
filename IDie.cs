namespace DiceGame;

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