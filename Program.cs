using DiceGame;


/*dependencies:
Dice is dependent on IDie
Dice Cups are dependent on Dice
DiceGame is dependent on DiceCup

I'm confused about the test methods :(
*/
Console.WriteLine("Hello, World!");

IDie die = StandardDie.D4;
IDie die2 = StandardDie.D4;
IDie die3 = StandardDie.D4;

var dices = new DiceCup(StandardDie.D4, StandardDie.D4, StandardDie.D4);

Console.WriteLine(dices.RollAll());

/*int[] rollCounts = [0, 0, 0, 0];
for (var i = 0; i < 10_000; i++)
{
    rollCounts[die.Roll() - 1]++;
}
Console.WriteLine($"{rollCounts[0]},{rollCounts[1]}, {rollCounts[2]}, {rollCounts[3]} ");
*/



