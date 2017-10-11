using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using SpawnsetCreator.SpawnData;

namespace SpawnsetCreator
{
    public partial class MainWindow : Form
    {

        EnemyFactory SpawnFactory = new EnemyFactory();
        Spawnset Spawns = new Spawnset();
        SpawnsetFileManager SpawnFs = new SpawnsetFileManager();

        public MainWindow()
        {
            InitializeComponent();

            EnemyList.FullRowSelect = true;
            UpdateTextboxesValues();
        }

        private void UpdateEnemyList()
        {
            EnemyList.Items.Clear();

            foreach(Enemy e in Spawns.Spawns)
            {
                ListViewItem item = new ListViewItem(e.GetViewStrings());
                EnemyList.Items.Add(item);
            }

            //Color the end loop (17 final spawns)
            if(EnemyList.Items.Count > 17)
            {
                for (int i = 0; i < 17; i++)
                {
                    EnemyList.Items[(EnemyList.Items.Count - 1) - i].BackColor = Color.Orange;
                }
                EnemyList.Items[(EnemyList.Items.Count - 1)].EnsureVisible();
            }

        }

        private void UpdateTextboxesValues()
        {
            numSpawnsTextbox.Text       = Spawns.NumEnemies.ToString();
            numGemsTextbox.Text         = Spawns.NumGems.ToString();
            shrinkFinalNumeric.Value    = Convert.ToDecimal(Spawns.ShrinkFinalRadius);
            shrinkStartNumeric.Value    = Convert.ToDecimal(Spawns.ShrinkStartRadius);
            shrinkRateNumeric.Value     = Convert.ToDecimal(Spawns.ShrinkRate);
            brightnessNumeric.Value     = Convert.ToDecimal(Spawns.Brightness);
        }

        private void RemoveEnemyButton_Click(object sender, EventArgs e)
        {
            foreach(int i in EnemyList.SelectedIndices){
                Spawns.RemoveEnemy(i);
            }
            UpdateEnemyList();
            UpdateTextboxesValues();
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Spawns = SpawnFs.ParseFile(openFileDialog.FileName);
                UpdateEnemyList();
                UpdateTextboxesValues();
            }
        }

        private void exportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = exportFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                SpawnFs.SaveToFile(exportFileDialog.FileName, Spawns);
            }
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBoxButtons button = MessageBoxButtons.YesNo;
            if(System.Windows.Forms.MessageBox.Show("Do you really want to delete all spawns?", "Hold up!", button) == DialogResult.Yes)
            {
                Spawns.Clear();
                UpdateEnemyList();
                UpdateTextboxesValues();
            }
        }

        private void shrinkFinalNumeric_ValueChanged(object sender, EventArgs e)
        {
            Spawns.ShrinkFinalRadius = (float)shrinkFinalNumeric.Value;
        }

        private void shrinkStartNumeric_ValueChanged(object sender, EventArgs e)
        {
            Spawns.ShrinkStartRadius = (float)shrinkStartNumeric.Value;
        }

        private void shrinkRateNumeric_ValueChanged(object sender, EventArgs e)
        {
            Spawns.ShrinkRate = (float)shrinkRateNumeric.Value;
        }

        private void brightnessNumeric_ValueChanged(object sender, EventArgs e)
        {
            Spawns.Brightness = (float)brightnessNumeric.Value;
        }

        private void AddSpawn(int id, float spawnDelay)
        {
            Enemy en = SpawnFactory.CreateEnemy(id, spawnDelay);
            Spawns.AddEnemy(en);

            UpdateEnemyList();
            UpdateTextboxesValues();
        }

        private void squid1SpawnButton_Click(object sender, EventArgs e)
        {
            AddSpawn(EnemyFactory.SQUID1, Convert.ToSingle(spawnDelayNumeric.Value));
        }

        private void squid2SpawnButton_Click(object sender, EventArgs e)
        {
            AddSpawn(EnemyFactory.SQUID2, Convert.ToSingle(spawnDelayNumeric.Value));
        }

        private void squid3SpawnButton_Click(object sender, EventArgs e)
        {
            AddSpawn(EnemyFactory.SQUID3, Convert.ToSingle(spawnDelayNumeric.Value));
        }

        private void centipedeSpawnButton_Click(object sender, EventArgs e)
        {
            AddSpawn(EnemyFactory.CENTIPEDE, Convert.ToSingle(spawnDelayNumeric.Value));
        }

        private void gigapedeSpawnButton_Click(object sender, EventArgs e)
        {
            AddSpawn(EnemyFactory.GIGAPEDE, Convert.ToSingle(spawnDelayNumeric.Value));
        }

        private void ghostpedeSpawnButton_Click(object sender, EventArgs e)
        {
            AddSpawn(EnemyFactory.GHOSTPEDE, Convert.ToSingle(spawnDelayNumeric.Value));
        }

        private void spider1SpawnButton_Click(object sender, EventArgs e)
        {
            AddSpawn(EnemyFactory.SPIDER1, Convert.ToSingle(spawnDelayNumeric.Value));
        }

        private void spider2SpawnButton_Click(object sender, EventArgs e)
        {
            AddSpawn(EnemyFactory.SPIDER2, Convert.ToSingle(spawnDelayNumeric.Value));
        }

        private void leviathanSpawnButton_Click(object sender, EventArgs e)
        {
            AddSpawn(EnemyFactory.LEVIATHAN, Convert.ToSingle(spawnDelayNumeric.Value));
        }

        private void thornSpawnButton_Click(object sender, EventArgs e)
        {
            AddSpawn(EnemyFactory.THORN, Convert.ToSingle(spawnDelayNumeric.Value));
        }

        private void nothingSpawnButton_Click(object sender, EventArgs e)
        {
            AddSpawn(EnemyFactory.NOTHING, Convert.ToSingle(spawnDelayNumeric.Value));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void aNoteFromSojkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string boxText1 = "Hi, Putting high values or messed up values in some of these settings might cause crazy shit to happen. I haven't messed around much with spawnsets so i don't know what breaks and don't.\n\n"
                                + "Also If you get banned or mess up your game with these spawnsets it's your own fault.\n\n"
                                + "And shoutout to ThePassiveDada and xvlv as I've made this program based on the things they found\n\n"
                                + "Have fun and i hope you make some cool shit\n\n";
            string caption1 = "Sup'";
            System.Windows.Forms.MessageBox.Show(boxText1, caption1, MessageBoxButtons.OK);

            string boxText2 = "Every spawn has a delay until it appears that starts from the previous spawn. So if you want multiple enemies to spawn at once you use 0 delay.\n\n" +
                              "Also the last 17 waves will be the end-game loop. These are marked in orange when the list is larger than 17. Make sure that these waves are not all 0 second delay or else you will get crazy shit\n\n" +
                              "I don't know anything about the arena settings values, so have fun with those\n\n";
            string caption2 = "Oh and one last thing";
            System.Windows.Forms.MessageBox.Show(boxText2, caption2, MessageBoxButtons.OK);
        }
    }
}
