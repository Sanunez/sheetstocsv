using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
