namespace SettingsUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Outputdirectory_Label = new System.Windows.Forms.Label();
            this.OutputDirectory_TextBox = new System.Windows.Forms.TextBox();
            this.OutputDirectoryBrowse_Button = new System.Windows.Forms.Button();
            this.SpreadsheetID_Label = new System.Windows.Forms.Label();
            this.SpreadsheetID_Textbox = new System.Windows.Forms.TextBox();
            this.SpreadsheetClear_Button = new System.Windows.Forms.Button();
            this.Columns_Button = new System.Windows.Forms.Label();
            this.Columns_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Columns_DataGridView = new System.Windows.Forms.DataGridView();
            this.Save_Button = new System.Windows.Forms.Button();
            this.IdPaste_Button = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Optionset_legend = new System.Windows.Forms.Label();
            this.Date_Legend = new System.Windows.Forms.Label();
            this.Legend_Label = new System.Windows.Forms.Label();
            this.Entity_Texbox = new System.Windows.Forms.TextBox();
            this.Entity_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Columns_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // Outputdirectory_Label
            // 
            this.Outputdirectory_Label.AutoSize = true;
            this.Outputdirectory_Label.Location = new System.Drawing.Point(12, 9);
            this.Outputdirectory_Label.Name = "Outputdirectory_Label";
            this.Outputdirectory_Label.Size = new System.Drawing.Size(84, 13);
            this.Outputdirectory_Label.TabIndex = 1;
            this.Outputdirectory_Label.Text = "Output Directory";
            // 
            // OutputDirectory_TextBox
            // 
            this.OutputDirectory_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputDirectory_TextBox.Location = new System.Drawing.Point(15, 27);
            this.OutputDirectory_TextBox.Name = "OutputDirectory_TextBox";
            this.OutputDirectory_TextBox.Size = new System.Drawing.Size(336, 20);
            this.OutputDirectory_TextBox.TabIndex = 2;
            // 
            // OutputDirectoryBrowse_Button
            // 
            this.OutputDirectoryBrowse_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputDirectoryBrowse_Button.Location = new System.Drawing.Point(357, 27);
            this.OutputDirectoryBrowse_Button.Name = "OutputDirectoryBrowse_Button";
            this.OutputDirectoryBrowse_Button.Size = new System.Drawing.Size(75, 20);
            this.OutputDirectoryBrowse_Button.TabIndex = 3;
            this.OutputDirectoryBrowse_Button.Text = "Browse...";
            this.OutputDirectoryBrowse_Button.UseVisualStyleBackColor = true;
            this.OutputDirectoryBrowse_Button.Click += new System.EventHandler(this.OutputDirectoryBrowse_Button_Click);
            // 
            // SpreadsheetID_Label
            // 
            this.SpreadsheetID_Label.AutoSize = true;
            this.SpreadsheetID_Label.Location = new System.Drawing.Point(12, 54);
            this.SpreadsheetID_Label.Name = "SpreadsheetID_Label";
            this.SpreadsheetID_Label.Size = new System.Drawing.Size(81, 13);
            this.SpreadsheetID_Label.TabIndex = 4;
            this.SpreadsheetID_Label.Text = "Spreadsheet ID";
            // 
            // SpreadsheetID_Textbox
            // 
            this.SpreadsheetID_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpreadsheetID_Textbox.Location = new System.Drawing.Point(15, 70);
            this.SpreadsheetID_Textbox.Name = "SpreadsheetID_Textbox";
            this.SpreadsheetID_Textbox.Size = new System.Drawing.Size(417, 20);
            this.SpreadsheetID_Textbox.TabIndex = 5;
            // 
            // SpreadsheetClear_Button
            // 
            this.SpreadsheetClear_Button.Location = new System.Drawing.Point(15, 96);
            this.SpreadsheetClear_Button.Name = "SpreadsheetClear_Button";
            this.SpreadsheetClear_Button.Size = new System.Drawing.Size(75, 23);
            this.SpreadsheetClear_Button.TabIndex = 6;
            this.SpreadsheetClear_Button.Text = "Clear";
            this.SpreadsheetClear_Button.UseVisualStyleBackColor = true;
            this.SpreadsheetClear_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Columns_Button
            // 
            this.Columns_Button.AutoSize = true;
            this.Columns_Button.Location = new System.Drawing.Point(12, 129);
            this.Columns_Button.Name = "Columns_Button";
            this.Columns_Button.Size = new System.Drawing.Size(47, 13);
            this.Columns_Button.TabIndex = 7;
            this.Columns_Button.Text = "Columns";
            // 
            // Columns_NumericUpDown
            // 
            this.Columns_NumericUpDown.Location = new System.Drawing.Point(15, 145);
            this.Columns_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Columns_NumericUpDown.Name = "Columns_NumericUpDown";
            this.Columns_NumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.Columns_NumericUpDown.TabIndex = 8;
            this.Columns_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Columns_NumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Columns_DataGridView
            // 
            this.Columns_DataGridView.AllowUserToAddRows = false;
            this.Columns_DataGridView.AllowUserToDeleteRows = false;
            this.Columns_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Columns_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Columns_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns_DataGridView.Location = new System.Drawing.Point(15, 171);
            this.Columns_DataGridView.Name = "Columns_DataGridView";
            this.Columns_DataGridView.Size = new System.Drawing.Size(417, 72);
            this.Columns_DataGridView.TabIndex = 9;
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Save_Button.Location = new System.Drawing.Point(15, 292);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(417, 63);
            this.Save_Button.TabIndex = 10;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // IdPaste_Button
            // 
            this.IdPaste_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdPaste_Button.Location = new System.Drawing.Point(357, 96);
            this.IdPaste_Button.Name = "IdPaste_Button";
            this.IdPaste_Button.Size = new System.Drawing.Size(75, 23);
            this.IdPaste_Button.TabIndex = 11;
            this.IdPaste_Button.Text = "Paste";
            this.IdPaste_Button.UseVisualStyleBackColor = true;
            this.IdPaste_Button.Click += new System.EventHandler(this.IdPaste_Button_Click);
            // 
            // Optionset_legend
            // 
            this.Optionset_legend.AutoSize = true;
            this.Optionset_legend.Location = new System.Drawing.Point(12, 259);
            this.Optionset_legend.Name = "Optionset_legend";
            this.Optionset_legend.Size = new System.Drawing.Size(212, 13);
            this.Optionset_legend.TabIndex = 12;
            this.Optionset_legend.Text = "*  :  Specifies That Column Is An Option Set";
            // 
            // Date_Legend
            // 
            this.Date_Legend.AutoSize = true;
            this.Date_Legend.Location = new System.Drawing.Point(12, 272);
            this.Date_Legend.Name = "Date_Legend";
            this.Date_Legend.Size = new System.Drawing.Size(215, 13);
            this.Date_Legend.TabIndex = 13;
            this.Date_Legend.Text = "+ : Specifies That Column Is In Date Format ";
            // 
            // Legend_Label
            // 
            this.Legend_Label.AutoSize = true;
            this.Legend_Label.Location = new System.Drawing.Point(12, 246);
            this.Legend_Label.Name = "Legend_Label";
            this.Legend_Label.Size = new System.Drawing.Size(227, 13);
            this.Legend_Label.TabIndex = 14;
            this.Legend_Label.Text = "Please Add Column Definers before submitting:";
            // 
            // Entity_Texbox
            // 
            this.Entity_Texbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Entity_Texbox.Location = new System.Drawing.Point(332, 145);
            this.Entity_Texbox.Name = "Entity_Texbox";
            this.Entity_Texbox.Size = new System.Drawing.Size(100, 20);
            this.Entity_Texbox.TabIndex = 15;
            // 
            // Entity_Label
            // 
            this.Entity_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Entity_Label.AutoSize = true;
            this.Entity_Label.Location = new System.Drawing.Point(329, 129);
            this.Entity_Label.Name = "Entity_Label";
            this.Entity_Label.Size = new System.Drawing.Size(33, 13);
            this.Entity_Label.TabIndex = 16;
            this.Entity_Label.Text = "Entity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 367);
            this.Controls.Add(this.Entity_Label);
            this.Controls.Add(this.Entity_Texbox);
            this.Controls.Add(this.Legend_Label);
            this.Controls.Add(this.Date_Legend);
            this.Controls.Add(this.Optionset_legend);
            this.Controls.Add(this.IdPaste_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Columns_DataGridView);
            this.Controls.Add(this.Columns_NumericUpDown);
            this.Controls.Add(this.Columns_Button);
            this.Controls.Add(this.SpreadsheetClear_Button);
            this.Controls.Add(this.SpreadsheetID_Textbox);
            this.Controls.Add(this.SpreadsheetID_Label);
            this.Controls.Add(this.OutputDirectoryBrowse_Button);
            this.Controls.Add(this.OutputDirectory_TextBox);
            this.Controls.Add(this.Outputdirectory_Label);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(460, 406);
            this.Name = "Form1";
            this.Text = "Sheets2CSV Settings";
            ((System.ComponentModel.ISupportInitialize)(this.Columns_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Outputdirectory_Label;
        private System.Windows.Forms.TextBox OutputDirectory_TextBox;
        private System.Windows.Forms.Button OutputDirectoryBrowse_Button;
        private System.Windows.Forms.Label SpreadsheetID_Label;
        private System.Windows.Forms.TextBox SpreadsheetID_Textbox;
        private System.Windows.Forms.Button SpreadsheetClear_Button;
        private System.Windows.Forms.Label Columns_Button;
        private System.Windows.Forms.NumericUpDown Columns_NumericUpDown;
        private System.Windows.Forms.DataGridView Columns_DataGridView;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button IdPaste_Button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label Optionset_legend;
        private System.Windows.Forms.Label Date_Legend;
        private System.Windows.Forms.Label Legend_Label;
        private System.Windows.Forms.TextBox Entity_Texbox;
        private System.Windows.Forms.Label Entity_Label;
    }
}

