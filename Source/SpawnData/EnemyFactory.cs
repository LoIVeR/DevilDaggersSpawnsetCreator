using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpawnsetCreator.SpawnData
{
    class EnemyFactory
    {
        public const int NOTHING = -1;
        public const int SQUID1 = 0;
        public const int SQUID2 = 1;
        public const int CENTIPEDE = 2;
        public const int SPIDER1 = 3;
        public const int LEVIATHAN = 4;
        public const int GIGAPEDE = 5;
        public const int SQUID3 = 6;
        public const int THORN = 7;
        public const int SPIDER2 = 8;
        public const int GHOSTPEDE = 9;

        public List<string> EnemyNames;

        public EnemyFactory()
        {
            EnemyNames = new List<string>();
            EnemyNames.Add("SQUID I");
            EnemyNames.Add("SQUID II");
            EnemyNames.Add("CENTIPEDE");
            EnemyNames.Add("SPIDER I");
            EnemyNames.Add("LEVIATHAN");
            EnemyNames.Add("GIGAPEDE");
            EnemyNames.Add("SQUID III");
            EnemyNames.Add("THORN");
            EnemyNames.Add("SPIDER II");
            EnemyNames.Add("GHOSTPEDE");
            EnemyNames.Add("NOTHING");
        }

        public Enemy CreateEnemy(int enemyType, float relativeDelay)
        {
            switch(enemyType)
            {
                case NOTHING:
                    return new Enemy(NOTHING, "NOTHING", relativeDelay, 0);
                case SQUID1:
                    return new Enemy(SQUID1, "SQUID I" , relativeDelay, 1);
                case SQUID2:
                    return new Enemy(SQUID2, "SQUID II", relativeDelay, 2);
                case CENTIPEDE:
                    return new Enemy(CENTIPEDE, "CENTIPEDE", relativeDelay, 25);
                case SPIDER1:
                    return new Enemy(SPIDER1, "SPIDER I", relativeDelay, 1);
                case LEVIATHAN:
                    return new Enemy(LEVIATHAN, "LEVIATHAN", relativeDelay, 6);
                case GIGAPEDE:
                    return new Enemy(GIGAPEDE, "GIGAPEDE", relativeDelay, 50);
                case SQUID3:
                    return new Enemy(SQUID3, "SQUID III", relativeDelay, 3);
                case THORN:
                    return new Enemy(THORN, "THORN", relativeDelay, 0);
                case SPIDER2:
                    return new Enemy(SPIDER2, "SPIDER II", relativeDelay, 2);
                case GHOSTPEDE:
                    return new Enemy(GHOSTPEDE, "GHOSTPEDE", relativeDelay, 10);
                default:
                    Console.WriteLine("Something went wrong in factory: Enemy TYPE : " + enemyType);
                    return null;
            }
        }
    }
}
