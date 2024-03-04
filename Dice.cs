namespace DiceGame;

public class StandardDie : IDie
{
    /// <summary>
    /// Declares a bunch of private dice w/ different # of sides
    /// </summary>
    public static readonly IDie D4 = new StandardDie(4);
    public static readonly IDie D6 = new StandardDie(6);
    public static readonly IDie D8 = new StandardDie(8);
    public static readonly IDie D10 = new StandardDie(10);
    public static readonly IDie D12 = new StandardDie(12);
    public static readonly IDie D20 = new StandardDie(20);
    public static readonly IDie D100 = new StandardDie(100);
    private static readonly Random Rand = new();
    /// <summary>
    /// # of sides of the dice; a property of the die; declares it exists
    /// </summary>
    public int SideCount { get; }
    /// <summary>
    /// gives the dice a number of sides; used above to create some die
    /// </summary>
    private StandardDie(int sides) => SideCount = sides;
    /// <summary>
    /// Rolls the dice?
    /// </summary>
    public int Roll() => Rand.Next(SideCount) + 1;
    /// <summary>
    /// idk but maybe converts the int to a string so it can be used in messages to console & stuff
    /// </summary>
    public override string ToString() => $"d{SideCount}";
}

public class WeightedDie : IDie
{
    private static readonly Random Rand = new();
    public int SideCount => _sideWeights.Length;

    private readonly double[] _sideWeights;
    /// <summary>
    /// Constructor; i don't rly understand the details but it makes the die weighed?
    /// </summary>
    public WeightedDie(params double[] sideWeights)
    {
        var sum = sideWeights.Select(w => Math.Abs(w)).Sum();
        double total = 0;
        for (var i = 0; i < sideWeights.Length; i++)
        {
            total += Math.Abs(sideWeights[i]) / sum;
            sideWeights[i] = total;
        }
        _sideWeights = sideWeights;
    }
    
    /// <summary>
    /// Rolls the weighed die; also don't rly understand details?
    /// </summary>
    public int Roll()
    {
        var x = Rand.NextDouble();
        for (var i = 0; i < _sideWeights.Length; i++)
        {
            if (x <= _sideWeights[i])
                return i + 1;
        }

        return SideCount;
    }
}