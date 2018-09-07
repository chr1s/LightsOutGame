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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupGameGrid();           
        }

        // Button click event - changes colour.
        private void OnButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;            
            int buttonGridLocationX = button.Location.X / 60;
            int buttonGridLocationY = button.Location.Y / 60;
            button.BackColor = Color.Red;
        }

        // Setup the 5x5 game grid
        private void SetupGameGrid()
        {
            int gridColumn;
            int gridRow;

            // Buttons for game grid
            Button[,] btn = new Button[5, 5];
           
            // Create the 5x5 grid of buttons
            for (gridColumn = 0; gridColumn < 5; gridColumn++)
            {
                for (gridRow = 0; gridRow < 5; gridRow++)
                {
                    // Set the button height/width/location
                    btn[gridColumn, gridRow] = new Button
                    {
                        Height = 60,
                        Width = 60,
                        Location = new Point(60 * gridColumn, 60 * gridRow)
                    };

                    // Button click event handler
                    btn[gridColumn, gridRow].Click += new EventHandler(OnButtonClick);

                    // Add button to form
                    Controls.Add(btn[gridColumn, gridRow]);
                }
            }

        }

    }
}
