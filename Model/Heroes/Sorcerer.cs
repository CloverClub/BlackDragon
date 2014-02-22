namespace Model
{
    public class Sorcerer : Hero
    {
        private bool damageForLife;

        public bool Sacrifice
        {
            get
            {
                return this.damageForLife;
            }
            set
            {
                this.damageForLife = value;
            }
        }
        public Sorcerer(string name, int exp, int health, int damage)
        {
            this.Name = name;
            this.Experience = exp;
            this.HealthPoints = health;
            this.DamagePoints = damage;
        }
    }
}
