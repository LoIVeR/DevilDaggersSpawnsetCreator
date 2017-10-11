using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpawnsetCreator.SpawnData
{
    class Enemy
    {
        public int EnemyType { get; set; }      //Game enemy ID
        public string Name { get; set; }        //Actual name of the enemy
        public float SpawnTime { get; set; }    //This has to be calculated by adding the previous delay times
        public int Gems { get; set; }
        public float Delay { get; set; }        //The delay until this enemy spawns

        public Enemy(int type, string name, float delay, int gems)
        {
            EnemyType = type;
            Name = name;
            Delay = delay;
            Gems = gems;
        }

        /* For showing the object in the windows form listview. */
        public string[] GetViewStrings()
        {
            string[] s = new string[3];
            s[0] = SpawnTime.ToString();
            s[1] = Name;
            s[2] = Delay.ToString();
            return s;
        }
    }
}
