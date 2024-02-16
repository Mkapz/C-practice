namespace TowerOfDeathRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHealth = 20;
            int enemyHealth = 20;

            while (playerHealth > 0 && enemyHealth > 0)
            {

                Console.WriteLine(" The player has " + playerHealth + " health");
                Console.WriteLine(" The enemy has " + enemyHealth + " health.");
                Console.WriteLine("Write 'attack' to attack the enemy or 'block' to block an enemy attack");

                //get a player's choice
                string choice = Console.ReadLine();
                //decide enemy damage random number
                int enemyDamage = new Random().Next(1, 4);

                //Process player action
                if (choice == "attack")
                {

                    //the player attacks
                    Console.WriteLine("You attack for 2 damage");
                    enemyHealth -= 2;
                    Console.WriteLine("The enemy attacked for " + enemyDamage + " damage!");
                    playerHealth -= enemyDamage;
                }
                if (choice == "block")
                {
                    //if the player defends
                    Console.WriteLine("You blocked fagainst the attack!");
                    Console.WriteLine("The enemy would've dealt " + enemyDamage + " damage!");

                }
                if (playerHealth == 0)
                {
                    Console.WriteLine("You have been defeated");
                }
                if (enemyHealth == 0)
                {
                    Console.WriteLine("You have defeated the enemy");
                }

               
            }
        }
    }
}
