using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOutGame
{
    public partial class Form1 : Form
    {
        // 2d array for all the grid buttons.
        Button[,] btn = new Button[5, 5];
        // Used later to randomly assign button starting colours.
        Random rnd = new Random();
        // We don't want to check whether the game is completed when setting up lights.
        Boolean setup = false;
        // Create sounds
        System.Media.SoundPlayer lightsOn = new System.Media.SoundPlayer(@"Resources\lights_on.wav");
        System.Media.SoundPlayer lightsOff = new System.Media.SoundPlayer(@"Resources\lights_off.wav");
        System.Media.SoundPlayer gameWon = new System.Media.SoundPlayer(@"Resources\game_won.wav");


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupGameGrid();
        }      

        

        // Button click event - toggles light on or off.
        private void OnButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int buttonGridLocationX = button.Location.X / 60;
            int buttonGridLocationY = button.Location.Y / 60;

            // Toggle the button that was clicked.           
            ToggleLight(button);

            // Toggle the four adjacent buttons to be turned on or off
            // left
            if (buttonGridLocationX > 0)
            {
                ToggleLight(btn[buttonGridLocationX - 1, buttonGridLocationY]);
            }
            // right
            if (buttonGridLocationX < 4)
            {
                ToggleLight(btn[buttonGridLocationX + 1, buttonGridLocationY]);
            }
            // above
            if (buttonGridLocationY > 0)
            {
                ToggleLight(btn[buttonGridLocationX, buttonGridLocationY - 1]);
            }
            // below
            if (buttonGridLocationY < 4)
            {
                ToggleLight(btn[buttonGridLocationX, buttonGridLocationY + 1]);
            }
            if (setup)
            {
                CheckGameEndStatus();
            }

        }      

            // Swap button colours
            private void ToggleLight(Button button)
        {
            if (button.BackColor == Color.DarkGreen)
            {
                button.BackColor = Color.LightGreen;
                if (setup)
                {
                    lightsOn.Play();
                }
            }

            else if (button.BackColor == Color.LightGreen)
            {
                button.BackColor = Color.DarkGreen;
                if (setup)
                {
                    lightsOff.Play();
                }
            }
        }

        private void SetGameGridLights()
        {
            int gridColumn;
            int gridRow;

            setup = false;
            //Create the 5x5 grid of buttons.
            for (gridColumn = 0; gridColumn < 5; gridColumn++)
            {
                for (gridRow = 0; gridRow < 5; gridRow++)
                {
                    btn[gridColumn, gridRow].BackColor = Color.DarkGreen;
                
                }

            }

            // Turn some lights on
            for (int i = 0; i < 10; i++)
            {
                int value1 = rnd.Next(0, 5);
                int value2 = rnd.Next(0, 5);
                btn[value1, value2].PerformClick();           
      
            }
            // Game is setup, will now check for completion.
            setup = true;            
        }

        private void SetupGameGrid()
        {
            int gridColumn;
            int gridRow;                   

            // Create the 5x5 grid of buttons.
            for (gridColumn = 0; gridColumn < 5; gridColumn++)
            {
                for (gridRow = 0; gridRow < 5; gridRow++)
                {
                    // Set the button height/width/location.
                    btn[gridColumn, gridRow] = new Button
                    {
                        Height = 60,
                        Width = 60,
                        Location = new Point(60 * gridColumn, 60 * gridRow),
                        Name = gridColumn.ToString() + gridRow.ToString(),
                        FlatStyle = FlatStyle.Flat,                        
                     };                   

                     //Button click event handler.
                     btn[gridColumn, gridRow].Click += new EventHandler(OnButtonClick);                   

                    // Add button to form.
                    Controls.Add(btn[gridColumn, gridRow]);
                }
            }
            SetGameGridLights();       


        }
        

        // Reset game, grid is already setup, just need to reset lights.
        private void resetBtn_Click(object sender, EventArgs e)
        {            
            SetGameGridLights();

        }

        // Check if game has ended
        private void CheckGameEndStatus()
        {
            int gridColumn;
            int gridRow;
            Boolean status = true;
            // Loop through grid and check if lights are turned on.
            for (gridColumn = 0; gridColumn < 5; gridColumn++)
            {
                for (gridRow = 0; gridRow < 5; gridRow++)
                {

                    if (btn[gridColumn, gridRow].BackColor == Color.LightGreen)
                    {
                        status = false;
                    }
                }

            }
            // If all lights are off, ask to play again
            if (status == true)
            {
                gameWon.Play();
                DialogResult playAgainResult = MessageBox.Show("You Win! Would you like to play again?", "Message", MessageBoxButtons.YesNo);
                // Yes, reset grid
                if (playAgainResult == DialogResult.Yes)
                {
                    resetBtn.PerformClick();
                }
                // No, exit application
                if (playAgainResult == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
        }
    }
}

