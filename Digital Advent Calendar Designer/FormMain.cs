using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Digital_Advent_Calendar_Designer;
using Digital_Advent_Calendar_Designer.Calendar;

namespace Digital_Advent_Calendar_Designer
{
    public partial class FormMain : Form
    {

        public Calendar.Calendar Calendar { get; set; }
        public List<ICalendarItem> Items { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                richTextBoxHelp.LoadFile("help.rtf");
            }
            catch (IOException)
            {
                richTextBoxHelp.Text = "Unable to load help. ";
            }
        }

        public void NewCalendar()
        {
            // Delete all controls except for background. 
            foreach (Control c in panelCalendarPreview.Controls)
                if (c != pictureBoxCalendar)
                    panelCalendarPreview.Controls.Remove(c);

            Calendar = new Calendar.Calendar();

            Calendar.SaveDirectory = @"C:\Users\woegeo\Desktop\CalendarSave\";

            Calendar.TitleChanged += Calendar_TitleChanged;
            for (int i = 1; i <= Program.NUM_DOORS; i++)
                Calendar.Doors.Add(new Door(Calendar, i));

            Items = new List<ICalendarItem>();
            Items.Add(Calendar);
            Items.AddRange(Calendar.Doors);

            comboBoxItems.DataSource = Items;
            comboBoxItems.DisplayMember = "CalendarControlName";

            Calendar.BackgroundImage = new Bitmap(1, 1);
            pictureBoxCalendar.DataBindings.Clear();
            pictureBoxCalendar.DataBindings.Add(new Binding("Image", Calendar, "BackgroundImage"));

            // TODO: reset all user controls. 
            updateWindowText();

            // Calculate possible door positions. 
            List<Point> positions = new List<Point>();
            for (int i = 1; i <= 25; i++)
            {
                int x = -25 + ((i % 5 == 0) ? 5 : i % 5) * 50;
                int y = 85 + (int)Math.Floor((double)((i - 1) / 5)) * 50;
                positions.Add(new Point(x, y));
            }

            foreach (Door d in Calendar.Doors)
            {
                d.Properties.Width = 100;
                d.Properties.Height = 100;
                d.Properties.Color = Color.Black;
                d.BackColor = Color.White;


                d.RefreshGraphics();
                d.MouseDown += Door_MouseDown;
                d.MouseMove += Door_MouseMove;
                d.MouseUp += Door_MouseUp;
                d.LocationChanged += Door_LocationChanged;
                d.BringToFront();
                panelCalendarPreview.Controls.Add(d);

                Random rnd = new Random();
                int index = rnd.Next(0, positions.Count - 1);
                d.Left = positions.ElementAt(index).X;
                d.Top = positions.ElementAt(index).Y;
                positions.RemoveAt(index);
            }

            pictureBoxCalendar.SendToBack();
        }

        void Door_LocationChanged(object sender, EventArgs e)
        {
            ((Door)sender).Properties.X = (int)Math.Round(((-1) * (pictureBoxCalendar.Left - ((Door)sender).Left)) / Program.SCALE_FACTOR, 0);
            ((Door)sender).Properties.Y = (int)Math.Round(((-1) * (pictureBoxCalendar.Top - ((Door)sender).Top)) / Program.SCALE_FACTOR, 0);
        }

        private void Calendar_TitleChanged(object sender, PropertyChangedEventArgs e)
        {
            updateWindowText();
        }

        private void updateWindowText()
        {
            this.Text = Program.App.GenerateWindowText(Calendar.Title);
        }

        private void newCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCalendar();
        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxItems.SelectedItem.GetType() == typeof(Calendar.Door))
                propertyGridMain.SelectedObject = ((Door)comboBoxItems.SelectedItem).Properties;
            else
                propertyGridMain.SelectedObject = comboBoxItems.SelectedItem;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendar.Save();
        }

        #region Drag and Drop

        private Point MouseDownLocation;

        private void Door_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
                ((Control)sender).BringToFront();
            }
        }

        private void Door_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Control)sender).Left = e.X + ((Control)sender).Left - MouseDownLocation.X;
                ((Control)sender).Top = e.Y + ((Control)sender).Top - MouseDownLocation.Y;
            }
        }

        private void Door_MouseUp(object sender, EventArgs e)
        {
            propertyGridMain.SelectedObject = ((Door)sender).Properties;
            comboBoxItems.SelectedItem = sender;
        }

        #endregion

        private void propertyGridMain_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (propertyGridMain.SelectedObject.GetType() == typeof(DoorProperties))
                ((DoorProperties)propertyGridMain.SelectedObject).Parent.RefreshGraphics();
        }

        private void exportCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendar.Export();
        }

        private void helpBoxToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxHelp.Visible = helpBoxToolStripMenuItem.Checked;
            groupBoxProperties.Dock = helpBoxToolStripMenuItem.Checked ? DockStyle.Left : DockStyle.Fill;
        }

        private void propertiesBoxToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxProperties.Visible = propertiesBoxToolStripMenuItem.Checked;
        }

        private bool helpBoxVisibleBeforeResize = true;
        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (!helpBoxVisibleBeforeResize)
                return;
            if (this.Width < groupBoxHelp.Left + 15)
            {
                helpBoxToolStripMenuItem.Checked = false;
                helpBoxToolStripMenuItem.Enabled = false;
            }
            else
            {
                helpBoxToolStripMenuItem.Checked = true;
                helpBoxToolStripMenuItem.Enabled = true;
            }
        }

        private void FormMain_ResizeBegin(object sender, EventArgs e)
        {
            if (this.Width > groupBoxHelp.Left + 15)
                helpBoxVisibleBeforeResize = helpBoxToolStripMenuItem.Checked;
        }


    }
}
