using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldOfGames
{
    public partial class MainForm : Form
    {
        public static string name;

        
        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Events (Button Click)
    
        /// <summary>
        /// Стартување на играта 2048.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void play2048_Click(object sender, EventArgs e)
        {
            Form2048 nova = new Form2048();
            name = tbName.Text;

            nova.ShowDialog();
            nova.Close();
        }

        /// <summary>
        /// Стартување на играта Flappy Bird.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playFlappyBird_Click(object sender, EventArgs e)
        {
            FormFlappyBird nova = new FormFlappyBird();
            name = tbName.Text;

            nova.ShowDialog();
            nova.Close();
        }

        /// <summary>
        /// Стартување на играта Minesweeper.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playMinesweeper_Click(object sender, EventArgs e)
        {
            FormMinesweeper nova = new FormMinesweeper();
            name = tbName.Text;

            nova.ShowDialog();
            nova.Close();
        }

        /// <summary>
        /// Стартување на играта Snake.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playSnake_Click(object sender, EventArgs e)
        {
            FormSnake nova = new FormSnake();
            name = tbName.Text;
            
            nova.ShowDialog();
            nova.Close();
        }

        /// <summary>
        /// Стартување на играта Tetris.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playTetris_Click(object sender, EventArgs e)
        {
            FormTetris nova = new FormTetris();
            name = tbName.Text;

            nova.ShowDialog();
            nova.Close();
        }

        #endregion
    }
}
