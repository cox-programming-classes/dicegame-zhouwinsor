using System.Collections.Immutable;

namespace DiceGame;
/// <summary>
/// Just a list of die with a few manipulations;
/// </summary>
public class DiceCup
{
    
    private readonly List<IDie> _dice;

    /// <summary>
    /// Constructor; what does the I before Die mean again?
    /// </summary>
    public DiceCup(params IDie[] dice)
    {
        _dice = dice.ToList();
    }

    /// <summary>
    /// Rolls all of the die; what do the select and aggregate stuff mean?
    /// </summary>
    public int RollAll() => _dice
        .Select(die => die.Roll())
        .Aggregate((total, next) => total += next);
}