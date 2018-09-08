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
        // 2d array for all the grid buttons
        Button[,] btn = new Button[5,5];

        public Form1()
        {                      
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            SetupGameGrid();           
        }

        // Randomise the colour being on or off (light or dark.) 75% chance that the light is on.
        private void RandomiseButtonColour(Button button, Random rnd)
        {
            
            int lightOnOrOff = rnd.Next(0, 100);
            if (lightOnOrOff < 75)
            {
                // Turn light on.
                button.BackColor = Color.LightGreen;                
            }
            else
            {
                // Turn light off.
                button.BackColor = Color.DarkGreen;
            }
            
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

        }

        // Swap button colours
        private void ToggleLight(Button button)
        {
            if (button.BackColor == Color.DarkGreen)
            {
                button.BackColor = Color.LightGreen;
            }

            else if (button.BackColor == Color.LightGreen)
            {
                button.BackColor = Color.DarkGreen;
            }
        }

        // Setup the 5x5 game grid.
        private void SetupGameGrid()
        {
            int gridColumn;
            int gridRow;

            // Used later to randomly assign button starting colours.
            Random rnd = new Random();
            
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
                    };

                    // Randomise button colour.                    
                    RandomiseButtonColour(btn[gridColumn, gridRow], rnd);

                    // Button click event handler.
                    btn[gridColumn, gridRow].Click += new EventHandler(OnButtonClick);

                    // Add button to form.
                    Controls.Add(btn[gridColumn, gridRow]);
                }
            }

        }

    }
}
