using DiceGame;

Console.WriteLine("Hello, World!");

TheGame game = new();

game.AddPlayer("Player 1");
game.AddPlayer("Player 2");
game.AddPlayer("Player 3");

for (int i = 0; i < 100; i++)
{
    game.PlayRound();
    Console.ReadLine();
}

