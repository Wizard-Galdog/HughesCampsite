using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HughesCampsite
{
    public partial class SplashScreen : Form
    {
        Timer tmr;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size; //Makes the form size of the splashscreen constant and not changeable by the user
            this.MinimumSize = this.Size;
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer(); //Creates a new instance of the timer
            tmr.Interval = 3000; //Timer has a interval of 3 seconds
            tmr.Start(); //Starts the timer
            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e) //Event handler for the timer
        {
            tmr.Stop();             //after 3 sec stop the timer
            this.Close();             //Closes this form
        }
    }
}
