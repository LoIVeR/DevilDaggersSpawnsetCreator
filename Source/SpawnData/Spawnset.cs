using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SpawnsetCreator.SpawnData
{
    class Spawnset
    {
        public const float SHRINK_DEFAULT_FINAL_RADIUS  = 20;
        public const float SHRINK_DEFAULT_START_RADIUS  = 50.0000038f;
        public const float SHRINK_DEFAULT_RATE          = 0.025f;
        public const float BRIGHTNESS_DEFAULT           = 60;

        public int NumGems  { get; set; }
        public int NumEnemies { get; set; }
       
        public float ShrinkFinalRadius { get; set; }
        public float ShrinkStartRadius { get; set; }
        public float ShrinkRate { get; set; }
        public float Brightness { get; set; }

        public List<Enemy> Spawns;

        public Tileset Tiles;

        public Spawnset()
        {
            NumGems             = 0;
            NumEnemies          = 0;
            ShrinkFinalRadius   = SHRINK_DEFAULT_FINAL_RADIUS;
            ShrinkStartRadius   = SHRINK_DEFAULT_START_RADIUS;
            ShrinkRate          = SHRINK_DEFAULT_RATE;
            Brightness          = BRIGHTNESS_DEFAULT;

            Spawns = new List<Enemy>();
            Tiles = new Tileset();
        }

        public void AddEnemy(Enemy e)
        {
            Spawns.Add(e);
            NumGems = NumGems + e.Gems;
            NumEnemies++;
            UpdateSpawnTimes();
        }

        public void RemoveEnemy(int index)
        {
            NumGems = NumGems - Spawns[index].Gems;
            NumEnemies--;
            Spawns.RemoveAt(index);
            UpdateSpawnTimes();
            
        }

        public void UpdateSpawnTimes()
        {
            float time = 0;
            foreach(Enemy e in Spawns)
            {
                time += e.Delay;
                e.SpawnTime = time;
            }
        }

        public void Clear()
        {
            NumGems = 0;
            NumEnemies = 0;
            Spawns.Clear();
        }
    }
}
