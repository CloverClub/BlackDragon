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
                case 2:
                    return new Zombie();
                case 3:
                    return new Fallen();
                case 4:
                    return new Ogre();
                case 5:
                    return new Dragon();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
