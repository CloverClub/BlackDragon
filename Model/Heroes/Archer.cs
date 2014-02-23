using System.Text;
namespace Model
{
    public class Archer : Hero
    {
        private bool doubleDamage;

        public bool DoubleDamage
        {
            get 
            { 
                return this.doubleDamage;
            }
            set 
            { 
                this.doubleDamage = value;
            }
        }

        public Archer(string name, int exp, int health, int damage)
        {
            this.Name = name;
            this.Experience = exp;
            this.HealthPoints = health;
            this.DamagePoints = damage;
        }

        public override string DrawImage()
        {
            StringBuilder image = new StringBuilder();
            image.Append("|_O");image.AppendLine();
            image.Append(@"  |\_)_"); image.AppendLine();
            image.Append(@"  |\");image.AppendLine();                 
            image.Append("/  |");              
                          

            return image.ToString();
        }
    }
}
