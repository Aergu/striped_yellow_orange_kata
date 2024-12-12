using System.Threading.Channels;

namespace level2_striped_yellow_and_orange_belt;

class Program
{
    public delegate void PlayerCharacterAction(PlayerCharacter playerCharacter, int damage);

    public delegate void EnemyCharacterAction(EnemyCharacter enemyCharacter, int damage);

    static void Main(string[] args)
    {

        PlayerCharacter playerCharacter = new PlayerCharacter("Player", 300);
        EnemyCharacter enemyCharacter = new EnemyCharacter("Knight", 400);


        playerCharacter._healthChanged += (newHealth) =>
        {
            Console.WriteLine($"[Event]: {playerCharacter.Name}'s health changed to {newHealth}");
        };

        enemyCharacter._healthChanged += (newHealth) =>
        {
            Console.WriteLine($"[Event]: {enemyCharacter.Name}'s health changed to {newHealth}");
        };


        EnemyCharacterAction _playerattack = (enemy, damage) => enemy.TakeDamage(damage);
        PlayerCharacterAction _enemyattack = (player, damage) => player.TakeDamage(damage);

        _playerattack(enemyCharacter, 20);
        _enemyattack(playerCharacter, 10);
    }
}