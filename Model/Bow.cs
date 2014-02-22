namespace Model
{
    class Bow : Weapon
    {
        public int Damage
        {
            get { return this.addDamage; }
            set { this.addDamage = value; }
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
