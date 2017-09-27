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
using System.Collections.Specialized;

namespace SettingsUI
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Columns_DataGridView.RowCount = 1;
            Columns_DataGridView.ColumnCount = (int)Columns_NumericUpDown.Value;
            printSettings();

            
        }

        private void printSettings()
        {
            Log_Textbox.AppendText("Current Settings:\n");
            Log_Textbox.AppendText("Output Directory: " + Properties.Settings.Default.outputdir + "\n");
            Log_Textbox.AppendText("Spreadsheet ID: " + Properties.Settings.Default.spreadsheetID + "\n");
            Log_Textbox.AppendText("Coulumns: " + Properties.Settings.Default.headernum + "\n");
            Log_Textbox.AppendText("Entity Type: " + Properties.Settings.Default.Entity + "\n");
            Log_Textbox.AppendText("Headers: " + Properties.Settings.Default.headers + "\n");
            Log_Textbox.AppendText("\n");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Columns_DataGridView.ColumnCount = (int)Columns_NumericUpDown.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpreadsheetID_Textbox.Clear();
        }

        private void IdPaste_Button_Click(object sender, EventArgs e)
        {
            SpreadsheetID_Textbox.Text = Clipboard.GetText();
        }

        private void OutputDirectoryBrowse_Button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                OutputDirectory_TextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.outputdir = OutputDirectory_TextBox.Text;
            Properties.Settings.Default.spreadsheetID = SpreadsheetID_Textbox.Text;
            Properties.Settings.Default.Entity = Entity_Texbox.Text;
            Properties.Settings.Default.headernum = (int)Columns_NumericUpDown.Value;
            string headers = "";
            for (int i = 0; i < (int)Columns_NumericUpDown.Value; i++)
            {
                headers = headers + Columns_DataGridView.Rows[0].Cells[i].Value.ToString() + ",";
            }
            Properties.Settings.Default.headers = headers;
            Properties.Settings.Default.configured = true;
            Properties.Settings.Default.Save();
            printSettings();
            MessageBox.Show("Saving Complete!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
        }
    }
}
