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
using System.Configuration;
using System.Collections.Specialized;
using SettingsUI;


namespace SettingsUI
{
    public partial class Form1 : Form
    {
        static string prev;

        public Form1()
        {
            InitializeComponent();
            Columns_DataGridView.RowCount = 1;
            Columns_DataGridView.ColumnCount = (int)Columns_NumericUpDown.Value;
        }

        private void printSettings(string path)
        {
            if (File.Exists(path + "\\Settings.txt"))
            {
                StreamReader config = new StreamReader(path + "\\Settings.txt");
                Log_richTextBox.AppendText("------------Current Settings------------");
                Log_richTextBox.AppendText(Environment.NewLine);
                config.ReadLine();
                Log_richTextBox.AppendText("Output Directory: " + config.ReadLine() + Environment.NewLine);
                Log_richTextBox.AppendText("Spreadsheet ID: " + config.ReadLine() + Environment.NewLine);
                Log_richTextBox.AppendText("Coulumns: " + config.ReadLine() + Environment.NewLine);
                Log_richTextBox.AppendText("Entity Type: " + config.ReadLine() + Environment.NewLine);
                Log_richTextBox.AppendText("Headers: " + config.ReadLine() + Environment.NewLine);
                Log_richTextBox.AppendText(Environment.NewLine);
                config.Close();
            }
            else
            {
                Log_richTextBox.AppendText("------------No Settings Available------------");
            }
            
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
            prev = Settings_Output_Textbox.Text;
            string headers = "";
            for (int i = 0; i < (int)Columns_NumericUpDown.Value; i++)
            {
                if(i == (int)Columns_NumericUpDown.Value-1)
                {
                    headers = headers + Columns_DataGridView.Rows[0].Cells[i].Value.ToString();
                }
                else
                {
                    headers = headers + Columns_DataGridView.Rows[0].Cells[i].Value.ToString() + ",";
                }
                
            }

            StreamWriter config = new StreamWriter(Settings_Output_Textbox.Text + "\\Settings.txt");
            config.WriteLine("true");
            config.WriteLine(OutputDirectory_TextBox.Text);
            config.WriteLine(SpreadsheetID_Textbox.Text);
            config.WriteLine(Columns_NumericUpDown.Value.ToString());
            config.WriteLine(Entity_Texbox.Text);
            config.WriteLine(headers);
            config.Close();


            printSettings(prev);

            MessageBox.Show("Saving Complete!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
        }

        private void Settings_Output_Button_Click(object sender, EventArgs e)
        {
            Settings_Output_Textbox.Text = Clipboard.GetText();
        }
    }
}
