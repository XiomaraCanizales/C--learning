/* Instructions
The hero and the monster will start with 10 health points.
All attacks will be a value between 1 and 10.
The hero will attack first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner. 
*/

int heroHealth = 10;
int monsterHealth = 10;

Random random = new Random();

Console.WriteLine("Hero attacks first");
do
{
    int attack = random.Next(1, 11);
    monsterHealth -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth} health.");

    if (monsterHealth <= 0) continue;

    attack = random.Next(1, 11);
    heroHealth -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health.");

} while (heroHealth > 0 && monsterHealth > 0);
Console.WriteLine(heroHealth > monsterHealth ? "Hero Wins!" : "Monster Wins!");