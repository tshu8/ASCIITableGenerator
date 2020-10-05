using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        int min = 33;
        int max = 127;
        Dictionary<string, string> descDict = new Dictionary<string, string>();
        Dictionary<string, string> charDict = new Dictionary<string, string>();
        Dictionary<string, string> charDict2 = new Dictionary<string, string>();

        public frmASCII()
        {
            InitializeComponent();
        }

        public void descDictionary()
        {

            descDict.Add("0", "Null Character");
            descDict.Add("1", "Start of Header");
            descDict.Add("2", "Start of Text");
            descDict.Add("3", "End of Text");
            descDict.Add("4", "End of Transmission");
            descDict.Add("5", "Enquiry");
            descDict.Add("6", "Acknowledgment");
            descDict.Add("7", "Bell");
            descDict.Add("8", "Backspace");
            descDict.Add("9", "Horizontal Tab");
            descDict.Add("10", "Line feed");
            descDict.Add("11", "Vertical Tab");
            descDict.Add("12", "Form feed");
            descDict.Add("13", "Carriage return");
            descDict.Add("14", "Shift Out");
            descDict.Add("15", "Shift In");
            descDict.Add("16", "Data Link Escape");
            descDict.Add("17", "Device Control 1");
            descDict.Add("18", "Device Control 2");
            descDict.Add("19", "Device Control 3");
            descDict.Add("20", "Device Control 4");
            descDict.Add("21", "Negative Acknowledgement");
            descDict.Add("22", "Synchronous idle");
            descDict.Add("23", "End of Transmission Block");
            descDict.Add("24", "Cancel");
            descDict.Add("25", "End of Medium");
            descDict.Add("26", "SUB Substitute");
            descDict.Add("27", "Escape");
            descDict.Add("28", "File Separator");
            descDict.Add("29", "Group Separator");
            descDict.Add("30", "Record Separator");
            descDict.Add("31", "Unit Separator");
            descDict.Add("32", "Space");
            for (int k = min; k < max; k++)
            {
                char l = (char)k;

            }
            for (int j = min; j < max; j++)
            {
                char d = (char)j;

                descDict.Add(j.ToString(), d.ToString());

            }
            foreach (KeyValuePair<string, string> kvp in descDict)
            {
                ListViewItem lvi = lvwASCII2.Items.Add(kvp.Value);
                string temp = string.Join(kvp.Value, kvp.Key);
                lvi.SubItems.Add(temp);
            }


        }

        public void charDictionary()
        {

            charDict.Add("0 ", "NULL ");// + "Null Character");
            charDict.Add("1 ", "SOH");// , "Start of Header");
            charDict.Add("2", "STX");// , "Start of Text");
            charDict.Add("3", "ETX");// , "End of Text");
            charDict.Add("4", "EOT");// , "End of Transmission");
            charDict.Add("5", "ENQ");// , "Enquiry");
            charDict.Add("6", "ACK");// , "Acknowledgment");
            charDict.Add("7", "BEL");// , "Bell");
            charDict.Add("8", "BS");// , "Backspace");
            charDict.Add("9", "HT");// , "Horizontal Tab");
            charDict.Add("10", "LF");// , "Line feed");
            charDict.Add("11", "VT");// , "Vertical Tab");
            charDict.Add("12", "FF");// , "Form feed");
            charDict.Add("13", "CR");// , "Carriage return");
            charDict.Add("14", "SO");// , "Shift Out");
            charDict.Add("15", "SI");// , "Shift In");
            charDict.Add("16", "DLE");// , "Data Link Escape");
            charDict.Add("17", "DC1");// , "Device Control 1");
            charDict.Add("18", "DC2");// , "Device Control 2");
            charDict.Add("19", "DC3");// , "Device Control 3");
            charDict.Add("20", "DC4");// , "Device Control 4");
            charDict.Add("21", "NAK");// , "Negative Acknowledgement");
            charDict.Add("22", "SYN");// , "Synchronous idle");
            charDict.Add("23", "ETB");// , "End of Transmission Block");
            charDict.Add("24", "CAN");// , "Cancel");
            charDict.Add("25", "EM");// , "End of Medium");
            charDict.Add("26", "S_B");// , "SUB Substitute");
            charDict.Add("27", "ESC");// , "Escape");
            charDict.Add("28", "FS");// , "File Separator");
            charDict.Add("29", "GS");// , "Group Separator");
            charDict.Add("30", "RS");// , "Record Separator");
            charDict.Add("31", "US");// , "Unit Separator");
            charDict.Add("32", "SPC");// , "Space");



            for (int k = min; k < max; k++)
            {
                char l = (char)k;

            }
            for (int j = min; j < max; j++)
            {
                char d = (char)j;

                charDict.Add(j.ToString(), d.ToString());

            }
            foreach (KeyValuePair<string, string> kvp in charDict)
            {
                ListViewItem lvi = lvwASCII.Items.Add(kvp.Key);
                string temp = string.Join(kvp.Key, kvp.Value);
                string temp2 = kvp.Key.ToString();
                lvi.SubItems.Add(temp);
            }

            charDict.Add("127", "DEL");
        }


        public void charDictionary2()
        {

            charDict2.Add("0 ", "NULL ");// + "Null Character");
            charDict2.Add("1 ", "SOH");// , "Start of Header");
            charDict2.Add("2", "STX");// , "Start of Text");
            charDict2.Add("3", "ETX");// , "End of Text");
            charDict2.Add("4", "EOT");// , "End of Transmission");
            charDict2.Add("5", "ENQ");// , "Enquiry");
            charDict2.Add("6", "ACK");// , "Acknowledgment");
            charDict2.Add("7", "BEL");// , "Bell");
            charDict2.Add("8", "BS");// , "Backspace");
            charDict2.Add("9", "HT");// , "Horizontal Tab");
            charDict2.Add("10", "LF");// , "Line feed");
            charDict2.Add("11", "VT");// , "Vertical Tab");
            charDict2.Add("12", "FF");// , "Form feed");
            charDict2.Add("13", "CR");// , "Carriage return");
            charDict2.Add("14", "SO");// , "Shift Out");
            charDict2.Add("15", "SI");// , "Shift In");
            charDict2.Add("16", "DLE");// , "Data Link Escape");
            charDict2.Add("17", "DC1");// , "Device Control 1");
            charDict2.Add("18", "DC2");// , "Device Control 2");
            charDict2.Add("19", "DC3");// , "Device Control 3");
            charDict2.Add("20", "DC4");// , "Device Control 4");
            charDict2.Add("21", "NAK");// , "Negative Acknowledgement");
            charDict2.Add("22", "SYN");// , "Synchronous idle");
            charDict2.Add("23", "ETB");// , "End of Transmission Block");
            charDict2.Add("24", "CAN");// , "Cancel");
            charDict2.Add("25", "EM");// , "End of Medium");
            charDict2.Add("26", "S_B");// , "SUB Substitute");
            charDict2.Add("27", "ESC");// , "Escape");
            charDict2.Add("28", "FS");// , "File Separator");
            charDict2.Add("29", "GS");// , "Group Separator");
            charDict2.Add("30", "RS");// , "Record Separator");
            charDict2.Add("31", "US");// , "Unit Separator");
            charDict2.Add("32", "SPC");// , "Space");



            for (int k = min; k < max; k++)
            {
                char l = (char)k;

            }
            for (int j = min; j < max; j++)
            {
                char d = (char)j;

                charDict2.Add(j.ToString(), d.ToString());

            }
            foreach (KeyValuePair<string, string> kvp in charDict2)
            {
                ListViewItem lvi = lvwASCII3.Items.Add(kvp.Value);
                string temp = string.Join(kvp.Value, kvp.Key);
                string temp2 = kvp.Key.ToString();
                lvi.SubItems.Add(temp);
            }

            charDict2.Add("127", "DEL");
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxSearch.Clear();
            tbxSearch.Focus();
            lbxResults.Items.Clear();
        }


        string search = "";
        string result = "";
        string resultSub = "";
        int searchValue;
        bool found = false;
        bool foundTwo = false;

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            search = tbxSearch.Text;
            //search for listbox

            for (int i = 0; i <= lvwASCII3.Items.Count - 1; i++)
            {
                //tried the search length you suggested, and, it broke the search, could be I have it setup wrong
                if (lvwASCII3.Items[i].Text.ToString().Contains(search))
                {                    
                    //Clear the listbox each time a character changes to act like a true filter.
                    //You can judge to see if it's better or not. --Dave--
                    lbxResults.Items.Clear();                     
                    
                    found = true;
                    result = lvwASCII2.Items[i].Text.ToString(); // Added to the results until your search is done and added a line break for each one. 
                    resultSub = lvwASCII.Items[i].Text.ToString();
                    searchValue = i;

                    lbxResults.Items.Add(lvwASCII.Items[i].Text.ToString() + " " + lvwASCII2.Items[i].Text.ToString());
                    //break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxSearch.Clear();
                tbxSearch.Focus();
            }
            else if (tbxSearch.Text == "")
            {
                tbxSearch.Clear();
                tbxSearch.Text = "";
                lbxResults.Items.Clear();
            }

        }

        private void frmASCII_Load(object sender, EventArgs e)
        {
            tbxSearch.Focus();
            //define headers for listview
            lvwASCII.View = View.Details;
            lvwASCII2.View = View.Details;
            lvwASCII3.View = View.Details;
            lvwASCII2.Visible = false;
            ColumnHeader index, ascii, description, index2, ascii2, index3;
            index = new ColumnHeader();
            ascii = new ColumnHeader();
            description = new ColumnHeader();
            index2 = new ColumnHeader();
            index3 = new ColumnHeader();
            ascii2 = new ColumnHeader();

            //set header attributes
            index.Text = "Index";
            index.TextAlign = HorizontalAlignment.Left;
            index.Width = 40;

            index2.Text = "Index";
            index2.TextAlign = HorizontalAlignment.Left;
            index2.Width = 40;

            index3.Text = "Index";
            index3.TextAlign = HorizontalAlignment.Left;
            index3.Width = 40;


            ascii.Text = "ASCII";
            ascii.TextAlign = HorizontalAlignment.Left;
            ascii.Width = 45;

            ascii2.Text = "ASCII";
            ascii2.TextAlign = HorizontalAlignment.Left;
            ascii2.Width = 45;

            description.Text = "Description";
            description.TextAlign = HorizontalAlignment.Left;
            description.Width = 150;

            //add columns to listview
            lvwASCII.Columns.Add(index);
            lvwASCII.Columns.Add(ascii);
            lvwASCII2.Columns.Add(description);
            lvwASCII2.Columns.Add(index2);
            lvwASCII3.Columns.Add(ascii2);
            lvwASCII3.Columns.Add(index3);

            charDictionary();
            descDictionary();
            charDictionary2();


        }


    }

}
