using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ASCIITableGenerator
{
    
    public partial class frmASCII : Form
    {
        public frmASCII()
        {
            InitializeComponent();
            initializeMainForm();
        }

        private void initializeMainForm()
        {
            this.BackColor = Properties.Settings.Default.myBackColorForm;
            this.ForeColor = Properties.Settings.Default.myForeColorForm;
            this.lvwASCII.BackColor = Properties.Settings.Default.myBackcolorLvwLbx;
            this.lvwASCII.ForeColor = Properties.Settings.Default.myForeColorLvwLbx;
            this.lbxResults.BackColor = Properties.Settings.Default.myBackcolorLvwLbx;
            this.lbxResults.ForeColor = Properties.Settings.Default.myForeColorLvwLbx;
            this.btnClear.BackColor = Properties.Settings.Default.myBackColorButton;
            this.btnClear.ForeColor = Properties.Settings.Default.myForeColorButton;
            this.btnExit.BackColor = Properties.Settings.Default.myBackColorButton;
            this.btnExit.ForeColor = Properties.Settings.Default.myForeColorButton;
            this.tbxSearch.BackColor = Properties.Settings.Default.myBackColorTbx;
            this.tbxSearch.ForeColor = Properties.Settings.Default.myForeColorTbx;

            this.FormClosing += mainFormClosingEventHandler;
        }

        private void mainFormClosingEventHandler(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.myBackColorForm = this.BackColor;
            Properties.Settings.Default.myForeColorForm = this.ForeColor;
            Properties.Settings.Default.myBackcolorLvwLbx = this.lvwASCII.BackColor;
            Properties.Settings.Default.myForeColorLvwLbx = this.lvwASCII.ForeColor;
            Properties.Settings.Default.myBackcolorLvwLbx = this.lbxResults.BackColor;
            Properties.Settings.Default.myForeColorLvwLbx = this.lbxResults.ForeColor;
            Properties.Settings.Default.myBackColorButton = this.btnClear.BackColor;
            Properties.Settings.Default.myForeColorButton = this.btnClear.ForeColor;
            Properties.Settings.Default.myBackColorButton = this.btnExit.BackColor;
            Properties.Settings.Default.myForeColorButton = this.btnExit.ForeColor;
            Properties.Settings.Default.myBackColorTbx = this.tbxSearch.BackColor;
            Properties.Settings.Default.myForeColorTbx = this.tbxSearch.ForeColor;

            Properties.Settings.Default.Save();
        }

        private string GetAsciiShortName(int c)
        {
            if (c < 0) throw new Exception("Character value is negative");
            if (c >= 128) throw new Exception("Character value exceeds expected limit of 128");
            switch (c)
            {
                case 0: return "NULL";
                case 1: return "SOH";
                case 2: return "STX";
                case 3: return "ETX";
                case 4: return "EOT";
                case 5: return "ENQ";
                case 6: return "ACK";
                case 7: return "BEL";
                case 8: return "BS";
                case 9: return "HT";
                case 10: return "LF";
                case 11: return "VT";
                case 12: return "FF";
                case 13: return "CR";
                case 14: return "SO";
                case 15: return "SI";
                case 16: return "DLE";
                case 17: return "DC1";
                case 18: return "DC2";
                case 19: return "DC3";
                case 20: return "DC4";
                case 21: return "NAK";
                case 22: return "SYN";
                case 23: return "ETB";
                case 24: return "CAN";
                case 25: return "EM";
                case 26: return "S_B";
                case 27: return "ESC";
                case 28: return "FS";
                case 29: return "GS";
                case 30: return "RS";
                case 31: return "US";
                case 32: return "SPC";
                case 127: return "DEL";
                default: return ((char)c).ToString();
            }
        }

        private string GetAsciiLongName(int c)
        {
            if (c < 0) throw new Exception("Character value is negative");
            if (c >= 128) throw new Exception("Character value exceeds expected limit of 128");
            switch (c)
            {
                case 0: return "Null Character";
                case 1: return "Start of Header";
                case 2: return "Start of Text";
                case 3: return "End of Text";
                case 4: return "End of Transmission";
                case 5: return "Enquiry";
                case 6: return "Acknowledgment";
                case 7: return "Bell";
                case 8: return "Backspace";
                case 9: return "Horizontal Tab";
                case 10: return "Line feed";
                case 11: return "Vertical Tab";
                case 12: return "Form feed";
                case 13: return "Carriage return";
                case 14: return "Shift Out";
                case 15: return "Shift In";
                case 16: return "Data Link Escape";
                case 17: return "Device Control 1";
                case 18: return "Device Control 2";
                case 19: return "Device Control 3";
                case 20: return "Device Control 4";
                case 21: return "Negative Acknowledgement";
                case 22: return "Synchronous idle";
                case 23: return "End of Transmission Block";
                case 24: return "Cancel";
                case 25: return "End of Medium";
                case 26: return "SUB Substitute";
                case 27: return "Escape";
                case 28: return "File Separator";
                case 29: return "Group Separator";
                case 30: return "Record Separator";
                case 31: return "Unit Separator";
                case 32: return "Space";
                case 127: return "Delete";
                default: return ((char)c).ToString();
            }
        }

        private void InitListView()
        {
            for (var x=0; x < 128; x++)
            {
                ListViewItem lvi = lvwASCII.Items.Add(x.ToString());
                lvi.SubItems.Add(GetAsciiShortName(x));
                lvi.SubItems.Add(GetAsciiLongName(x));
            }
        }

        private void clear()
        {
            tbxSearch.Clear();
            tbxSearch.Focus();
            lbxResults.Items.Clear();
            lvwASCII.SelectedItems.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        /// <summary>
        /// On text change, validate the data to check for 1, 2, or 3 characters. 
        /// If over the maximum of 3 characters, produce a warning to the user.
        /// 
        /// This uses validateData2() to compare the amount of characters entered.
        /// </summary>        
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            lvwASCII.SelectedItems.Clear();
            if (string.IsNullOrEmpty(tbxSearch.Text)) return; // If input is blank, do nothing
            var searchText = tbxSearch.Text.ToUpper();
            foreach (ListViewItem item in lvwASCII.Items)
            {
                if (item.Text.ToUpper().Contains(searchText) ||
                    item.SubItems[1].Text.ToUpper().Contains(searchText) ||
                    item.SubItems[2].Text.ToUpper().Contains(searchText))
                {
                    item.Selected = true;
                }
            }
        }

        private void frmASCII_Load(object sender, EventArgs e)
        {
            //asciiTheme("light");
            //Theme Checkboxes
            

            //link to help file
            asciiHelp.HelpNamespace = Application.StartupPath + "\\asciihelp.chm";
            //define headers for listview
            lvwASCII.View = View.Details;
            ColumnHeader index, ascii, description, index2, ascii2, index3;
            index = new ColumnHeader();
            ascii = new ColumnHeader();
            description = new ColumnHeader();

            //set header attributes
            index.Text = "Index";
            index.TextAlign = HorizontalAlignment.Left;
            index.Width = 40;

            ascii.Text = "ASCII";
            ascii.TextAlign = HorizontalAlignment.Left;
            ascii.Width = 45;

            description.Text = "Description";
            description.TextAlign = HorizontalAlignment.Left;
            description.Width = 0;

            //add columns to listview
            lvwASCII.Columns.Add(index);
            lvwASCII.Columns.Add(ascii);
            lvwASCII.Columns.Add(description);

            InitListView();

            tbxSearch.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout abt = new frmAbout();
            abt.ShowDialog();
        }

        private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTheme(ApplicationThemes.DarkTheme);
        }

        private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTheme(ApplicationThemes.LightTheme);
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTheme(ApplicationThemes.GrayTheme);
        }

        private void SetTheme(IApplicationTheme theme)
        {
            darkThemeToolStripMenuItem.Checked = theme.ThemeName == ApplicationThemes.DarkTheme.ThemeName;
            lightThemeToolStripMenuItem.Checked = theme.ThemeName == ApplicationThemes.LightTheme.ThemeName;
            grayScaleToolStripMenuItem.Checked = theme.ThemeName == ApplicationThemes.GrayTheme.ThemeName;

            BackColor = theme.BackgroundColor;
            ForeColor = theme.ForegroundColor;
            lvwASCII.BackColor = theme.ControlBackgroundColor;
            lvwASCII.ForeColor = theme.ControlForegroundColor;
            lbxResults.BackColor = theme.ControlBackgroundColor;
            lbxResults.ForeColor = theme.ControlForegroundColor;
            tbxSearch.BackColor = theme.ControlBackgroundColor;
            tbxSearch.ForeColor = theme.ControlForegroundColor;
            btnClear.BackColor = theme.ButtonBackgroundColor;
            btnClear.ForeColor = theme.ButtonForegroundColor;
            btnExit.BackColor = theme.ButtonBackgroundColor;
            btnExit.ForeColor = theme.ButtonForegroundColor;
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, asciiHelp.HelpNamespace);
        }

        private void lvwASCII_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxResults.Items.Clear();
            foreach (ListViewItem items in lvwASCII.SelectedItems)
            {
                var text = items.Text + " - " + items.SubItems[1].Text + " - " + items.SubItems[2].Text;
                lbxResults.Items.Add(text);
            }
        }
    }

}
