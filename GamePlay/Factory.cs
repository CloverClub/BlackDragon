using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlay
{
    public class Factory
    { 
        public static Hero GetCharacter(int heroId)
        {
            switch (heroId)
            {
                case 1:
                    return new Archer();
                case 2:
                    return new Barbarian(0, 1, 100,10);
                default:
                    throw new NotImplementedException();
            }
        }

        public static Enemy GetEnemy(int enemyId)
        {
            switch (enemyId)
            {
                case 1:
                    return new Demon();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
