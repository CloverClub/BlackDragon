using System.Text;
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

        public override string DrawImage()
        {
            StringBuilder image = new StringBuilder();
            image.Append("( _o  *"); image.AppendLine();
            image.Append(@" |\ )/|");image.AppendLine();
            image.Append(@" |/_\ |");
                            
            return image.ToString();
        }
    }
}
