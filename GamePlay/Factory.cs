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
        public static Hero GetHero(HeroEnum heroId)
        {
            switch (heroId)
            {
                case HeroEnum.Archer:
                    return new Archer("Some name", 10, 100, 20);
                case HeroEnum.Barbarian:
                    return new Barbarian("Barbarian name", 10, 90, 30);
                case HeroEnum.Sorcerer:
                    return new Sorcerer("Sorcer name", 10, 120, 25);
                case HeroEnum.Spearman:
                    return new Spearman("Spearman name", 10, 100, 30);
                case HeroEnum.Dwarf:
                    return new Dwarf("Dwarf name", 10, 90, 25);
                default:
                    throw new NotImplementedException();
            }
        }

        public static Enemy GetEnemy(EnemyEnum enemyId)
        {
            switch (enemyId)
            {
                case EnemyEnum.Demon:
                    return new Demon(10,5);
                case EnemyEnum.Zombie:
                    return new Zombie(15,10);
                case EnemyEnum.Fallen:
                    return new Fallen(25,15);
                case EnemyEnum.Ogre:
                    return new Ogre(30,20);
                case EnemyEnum.Goatman:
                    return new Goatman(35, 25);
                case EnemyEnum.Skeleton:
                    return new Skeleton(5, 5);
                case EnemyEnum.Yeti:
                    return new Yeti(40, 25);
                case EnemyEnum.Brute:
                    return new Brute(45, 20);
                case EnemyEnum.Fenix:
                    return new Fenix(50, 25);
                case EnemyEnum.Dragon:
                    return new Dragon(100, 20);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
