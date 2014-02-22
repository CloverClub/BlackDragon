namespace Model
{
    public class Yeti : Enemy
    {
        public int Damage
        {
            get { return this.damagePoints; }
            set { this.damagePoints = value; }
        }

        public int Health
        {
            get { return this.healthPoints; }
            set { this.healthPoints = value; }
        }

        public Yeti(int health, int damage)
        {
            this.Health = health;
            this.Damage = damage;
        }
    }
}