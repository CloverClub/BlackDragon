namespace Model
{
    public class Spearman : Hero
    {
        private bool invincibility;

        public bool Invinsible
        {
            get
            {
                return this.invincibility;
            }
            set
            {
                this.invincibility = value;
            }
        }
        public Spearman(string name, int exp, int health, int damage)
        {
            this.Name = name;
            this.Experience = exp;
            this.HealthPoints = health;
            this.DamagePoints = damage;
        }
    }
}
