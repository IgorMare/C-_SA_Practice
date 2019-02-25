using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        // Steps to take in order to instantiate class Player from Engine into SuperAdventure (using Engine reference on top)
        // 1. Create class level variable that will hold Player object (class level means it is accesable on class level, private access modifier hides it from outside of the class)
        private Player _player;

        // Defaulf constructor that initializes Form
        public SuperAdventure()
        {
            InitializeComponent();
            //2. Creating instance of a player class and assigning it to class-level variable _player
            _player = new Player();
            //3. Setting initial values of a player object
            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;
            // Displaying values in form, ToString() method converts number value into string value 
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

    }
}
