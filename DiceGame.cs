namespace DiceGame;

public class TheGame
{
    private DiceCup _house = new DiceCup(new WeightedDie(1, 1, 2, 3, 5, 8), StandardDie.D6);

    private Dictionary<string, DiceCup> _players = new();

    public void AddPlayer(string playerName) =>
        _players.Add(playerName, new(StandardDie.D6, StandardDie.D6));

    public (string, int) PlayRound()
    {
        Console.WriteLine("Here we go!");
        (var winner, var score) = ("", 0);
        foreach (var player in _players.Keys)
        {
            var s = _players[player].RollAll();
            
            Console.WriteLine($"{player} rolls:  {s}");
            
            if (s > score)
                (winner, score) = (player, s);
            
        }

        var houseScore = _house.RollAll();
        Console.WriteLine($"The House rolls:  {houseScore}");
        if (houseScore > score)
        {
            (winner, score) = ("House", houseScore);
        }
        Console.WriteLine($"{winner} Wins!");
        return (winner, score);
    }
}