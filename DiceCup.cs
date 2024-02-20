using System.Collections.Immutable;

namespace DiceGame;

public class DiceCup
{
    private readonly List<IDie> _dice;

    public DiceCup(params IDie[] dice)
    {
        _dice = dice.ToList();
    }

    public int RollAll() => _dice
        .Select(die => die.Roll())
        .Aggregate((total, next) => total += next);
}