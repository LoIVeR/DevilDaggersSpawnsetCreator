using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace SpawnsetCreator.SpawnData
{
    /* Represents the tiles in the arena */
    // TODO: Make it so you can edit tiles and save to the file
    class Tileset
    {
        private const int BUFFER_SIZE = 10404;
        private const int NUMBER_OF_TILES = 2601;
        private const int MAX_ARENA_WIDTH = 51;
        private const int MAX_ARENA_HEIGHT = 51;

        byte[] Buffer = new byte[BUFFER_SIZE];

        float[,] TileData = new float[MAX_ARENA_WIDTH, MAX_ARENA_HEIGHT];

        public Tileset()
        {
            byte[] templateHeader = Properties.Resources.template.ToArray();
            CopyTileData(templateHeader);
        }

        /* Copies the tile data from a existing file */
        public void CopyTileData(byte[] inBuffer)
        {
            int i;
            for (i = 0; i < BUFFER_SIZE; i++)
            {
                Buffer[i] = inBuffer[i + 36];
            }

            i = 0;
            for (int y = 0; y < MAX_ARENA_HEIGHT; y++)
            {
                for (int x = 0; x < MAX_ARENA_WIDTH; x++)
                {
                    TileData[x, y] = BitConverter.ToSingle(Buffer, i);
                    i = i + 4;
                }
            }
        }
    }
}
