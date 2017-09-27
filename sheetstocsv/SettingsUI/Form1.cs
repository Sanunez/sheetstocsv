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
using sheetstocsv;

namespace SettingsUI
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Columns_DataGridView.RowCount = 1;
            Columns_DataGridView.ColumnCount = (int)Columns_NumericUpDown.Value;
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
            sheetstocsv.Properties.Settings.Default.outputdir = OutputDirectory_TextBox.Text;
            sheetstocsv.Properties.Settings.Default.spreadsheetID = SpreadsheetID_Textbox.Text;
            sheetstocsv.Properties.Settings.Default.Entity = Entity_Texbox.Text;
            sheetstocsv.Properties.Settings.Default.headernum = (int)Columns_NumericUpDown.Value;
            string headers = "";
            for (int i = 0; i < (int)Columns_NumericUpDown.Value; i++)
            {
                headers = headers + Columns_DataGridView.Rows[0].Cells[i].Value.ToString() + ",";
            }
            sheetstocsv.Properties.Settings.Default.headers = headers;
            sheetstocsv.Properties.Settings.Default.configured = true;
            sheetstocsv.Properties.Settings.Default.Save();

            MessageBox.Show("Saving Complete!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
