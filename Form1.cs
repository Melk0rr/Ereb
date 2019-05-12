using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ereb
{
    public partial class Form1 : Form
    {
        /**
         * List of the panels used in the form
         */
        private List<Panel> panels = new List<Panel> ();

        /**
         * Index of the current pannel
         */
        private int currentPanelIndex = -1;

        /**
         * Constructor for the Form1 class
         */
        public Form1()
        {
            InitializeComponent();
            this.panels.Add(factionPanel); // Add faction panel
        }

        /**
         * Set the visibility of the chosen panel
         * @param {int} index : index of the panel
         * @param {Boolean} visible : visibility
         */
        private void setVisibility(int index, Boolean visible)
        {
            panels[index].Visible = visible;
            this.currentPanelIndex = (visible) ? index : --index;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void new_game_button_Click(object sender, EventArgs e)
        {
            this.setVisibility(0, true);
        }

        private void faction_to_menu_button_Click(object sender, EventArgs e)
        {
            this.setVisibility(0, false);
        }
    }
}
