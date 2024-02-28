namespace DiceGame;

public class StandardDie : IDie
{
    public static readonly IDie D4 = new StandardDie(4);
    public static readonly IDie D6 = new StandardDie(6);
    public static readonly IDie D8 = new StandardDie(8);
    public static readonly IDie D10 = new StandardDie(10);
    public static readonly IDie D12 = new StandardDie(12);
    public static readonly IDie D20 = new StandardDie(20);
    public static readonly IDie D100 = new StandardDie(100);
    private static readonly Random Rand = new();
    public int SideCount { get; }

    private StandardDie(int sides) => SideCount = sides;

    public int Roll() => Rand.Next(SideCount) + 1;

    public override string ToString() => $"d{SideCount}";
}

public class WeightedDie : IDie
{
    private static readonly Random Rand = new();
    public int SideCount => _sideWeights.Length;

    private readonly double[] _sideWeights;

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