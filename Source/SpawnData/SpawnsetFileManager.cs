using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpawnsetCreator.SpawnData
{
    /* Class for saving and loading spawnsets */
    class SpawnsetFileManager
    {
        //Buffer Sizes
        public const int HEADER_SIZE   = 10480; //unsure if this is constant but seems like it
        private const int PADDING_SIZE  = 20;

        //Byte positions
        private const int SPAWN_COUNT_POS   = 10476;
        private const int SPAWNS_START_POS  = 10480;
        private const int SHRINK_FINAL_POS  = 8;
        private const int SHRINK_START_POS  = 12;
        private const int SHRINK_RATE_POS   = 16;
        private const int BRIGHTNESS_POS    = 20;

        private byte[] HeaderBuffer = new byte[HEADER_SIZE];
        private byte[] Padding = new byte[PADDING_SIZE];
        private byte[] SpawnBuffer;

        private int SpawnBufferSize;

        public Spawnset ParseFile(string path)
        {
            Spawnset set = new Spawnset();
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

                SpawnBufferSize = (int)fs.Length - HEADER_SIZE;
                SpawnBuffer = new byte[SpawnBufferSize];

                fs.Read(HeaderBuffer, 0, HEADER_SIZE);
                fs.Read(SpawnBuffer, 0, SpawnBufferSize);

                ParseHeader(set);
                ParseSpawns(set);

                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went parsing file");
                Console.WriteLine(e.StackTrace);
                return null;
            }
            return set; 
        }

        private void ParseHeader(Spawnset outSet)
        {
            outSet.ShrinkFinalRadius    = BitConverter.ToSingle(HeaderBuffer, SHRINK_FINAL_POS);
            outSet.ShrinkStartRadius    = BitConverter.ToSingle(HeaderBuffer, SHRINK_START_POS);
            outSet.ShrinkRate           = BitConverter.ToSingle(HeaderBuffer, SHRINK_RATE_POS);
            outSet.Brightness           = BitConverter.ToSingle(HeaderBuffer, BRIGHTNESS_POS);
        }

        private void ParseSpawns(Spawnset outSet)
        {
            int enemyType;
            float delay;
            EnemyFactory factory = new EnemyFactory();
            int i = 0;
            
            while (i < SpawnBufferSize)
            {
                enemyType = BitConverter.ToInt32(SpawnBuffer, i);
                i += 4;
                delay = BitConverter.ToSingle(SpawnBuffer, i);
                i += (4 + PADDING_SIZE);
                outSet.AddEnemy(factory.CreateEnemy(enemyType, delay));
            }
        }


        public bool SaveToFile(string path, Spawnset set)
        {
            try
            {
                FileStream output = new FileStream(path, FileMode.Create, FileAccess.Write);
                
                //Copy template file
                byte[] buffer = Properties.Resources.template.ToArray();

                SetupHeader(buffer, set);

                //Write header
                output.Write(buffer, 0, buffer.Length);

                //Write spawns and delay
                foreach (Enemy e in set.Spawns)
                {
                    output.Write(BitConverter.GetBytes(e.EnemyType), 0, 4);
                    output.Write(BitConverter.GetBytes(e.Delay), 0, 4);
                    output.Write(Padding, 0, PADDING_SIZE);
                }

                output.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went saving file");
                Console.WriteLine(e.StackTrace);
                return false;
            }
            return true;
        }

        private void SetupHeader(byte[] buffer, Spawnset set)
        {
            /* Number of enemies */
            byte[] numEnemies = BitConverter.GetBytes(set.NumEnemies);
            for (int i = 0; i < 4; i++)
            {
                buffer[SPAWN_COUNT_POS + i] = numEnemies[i];
            }

            /* Shrink settings */ 
            byte[] finalRadius = BitConverter.GetBytes(set.ShrinkFinalRadius);
            byte[] startRadius = BitConverter.GetBytes(set.ShrinkStartRadius);
            byte[] shrinkRate = BitConverter.GetBytes(set.ShrinkRate);

            //final radius
            for (int i = 0; i < 4; i++)
            {
                buffer[SHRINK_FINAL_POS + i] = finalRadius[i];
            }

            //start radius
            for (int i = 0; i < 4; i++)
            {
                buffer[SHRINK_START_POS + i] = startRadius[i];
            }

            //shrink rate
            for (int i = 0; i < 4; i++)
            {
                buffer[SHRINK_RATE_POS + i] = shrinkRate[i];
            }

            /* Brightness */
            byte[] brightness = BitConverter.GetBytes(set.Brightness);
            for (int i = 0; i < 4; i++)
            {
                buffer[BRIGHTNESS_POS + i] = brightness[i];
            }
        }
    }
}
