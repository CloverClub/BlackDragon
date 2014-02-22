namespace Model
{
    public class Archer : Hero
    {

        public Archer(string name, int exp, int health, int damage)
        {
            this.Name = name;
            this.Experience = exp;
            this.HealthPoints = health;
            this.DamagePoints = damage;
        }
    }
}
