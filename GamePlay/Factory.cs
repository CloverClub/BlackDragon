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
        public static Hero GetCharacter(HeroEnum heroId)
        {
            switch (heroId)
            {
                case HeroEnum.Archer:
                    return new Archer();
                case HeroEnum.Barbarian:
                    return new Barbarian(0, 1, 100,10);
                default:
                    throw new NotImplementedException();
            }
        }

        public static Enemy GetEnemy(EnemyEnum enemyId)
        {
            switch (enemyId)
            {
                case EnemyEnum.Demon:
                    return new Demon();
                case EnemyEnum.Skeleton:
                    return new Skeleton(10,10);
                case EnemyEnum.Goatman:
                    return new Goatman(10,20);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
