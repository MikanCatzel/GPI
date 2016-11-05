using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPI
{
    public partial class MainWindow : Form
    {
        List<KeyValuePair<Panel, Button>> navBarControls;

        #region Color setting
        Color unselectedBtn = Color.Red;
        Color unselectedPnl = Color.DarkRed;
        Color selectedBtn = Color.Green;
        Color selectedPnl = Color.ForestGreen;
        #endregion


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            StoreNavButtons();
        }

        private void bNavBar_DTT_Click(object sender, EventArgs e)
        {
            ChangeSelectedButton(bNavBar_DTT);
        }

        private void bNavBar_Temp_Click(object sender, EventArgs e)
        {
            ChangeSelectedButton(bNavBar_Temp);
        }

        void StoreNavButtons ()
        {
            //Creates a list of all nav bar controls
            navBarControls = new List<KeyValuePair<Panel, Button>>();
            foreach(Control ctl in pNavBar.Controls)
            {
                if(ctl.GetType() == typeof(Panel) && !ctl.Name.Contains("Title"))
                {
                    Button btn = (Button)ctl.Controls[0];
                    navBarControls.Add(new KeyValuePair<Panel, Button>((Panel)ctl, btn));

                    ctl.BackColor = unselectedPnl;
                    btn.BackColor = unselectedBtn;
                }
            }
        }

        //Change the selected button and panels colour and all the other buttons and panels in the nav bar
        void ChangeSelectedButton (Button _selectedButton)
        {
            foreach(KeyValuePair<Panel, Button> ctl in navBarControls)
            {
                if(ctl.Value != _selectedButton)
                {
                    //Change the colours of the unselected buttons and panels
                    ctl.Key.BackColor = unselectedPnl;
                    ctl.Value.BackColor = unselectedBtn;
                }
                else
                {
                    ctl.Key.BackColor = selectedPnl;
                    ctl.Value.BackColor = selectedBtn;
                }
            }
        }

        private void bDebugSetValues_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string startTime = tbStartTime.Text;
            string endTime = tbEndTime.Text;

            //Here you change the labels
            Events dailyTimetable = new Events();
            if (endTime == "")
                dailyTimetable.AddEvent(title, startTime);
            else
                dailyTimetable.AddEvent(title, startTime, endTime);

            //lEventTitle.Text = dailyTimetable.title;
            //lEventStartTime.Text = dailyTimetable.startTime.ToString();
            //lEventEndTime.Text = dailyTimetable.endTime.ToString();

            Timetable tt = new Timetable(dailyTimetable);

            lEventTitle.Text = tt.allEvents[0].title;
            lEventStartTime.Text = tt.allEvents[0].startTime.ToString();
            lEventEndTime.Text = tt.allEvents[0].endTime.ToString();
        }
    }
}
