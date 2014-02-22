namespace Model
{
    public class Dragon : Enemy
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

        public Dragon(int health, int damage)
        {
            this.Health = health;
            this.Damage = damage;
        }
    }
}