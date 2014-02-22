namespace Model
{
    public class Ogre : Enemy
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

        public Ogre(int health, int damage)
        {
            this.Health = health;
            this.Damage = damage;
        }
    }
}