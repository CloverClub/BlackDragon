namespace Model
{
    class Scepter : Weapon
    {
        public int Damage
        {
            get { return this.addDamage; }
            set { this.addDamage = 18; }
        }
        public int Range
        {
            get { return this.range; }
            set { this.range = value; }
        }
        public override void DrawWeapon()
        {
            throw new System.NotImplementedException();
        }
    }
}
