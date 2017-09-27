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
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OutputDirectory_Label = new System.Windows.Forms.TextBox();
            this.OutputDirectoryBrowse_Button = new System.Windows.Forms.Button();
            this.SpreadsheetID_Label = new System.Windows.Forms.Label();
            this.SpreadsheetID_Textbox = new System.Windows.Forms.TextBox();
            this.SpreadsheetClear_Button = new System.Windows.Forms.Button();
            this.Columns_Button = new System.Windows.Forms.Label();
            this.Columns_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Columns_DataGridView = new System.Windows.Forms.DataGridView();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Directory";
            // 
            // OutputDirectory_Label
            // 
            this.OutputDirectory_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputDirectory_Label.Location = new System.Drawing.Point(15, 27);
            this.OutputDirectory_Label.Name = "OutputDirectory_Label";
            this.OutputDirectory_Label.Size = new System.Drawing.Size(186, 20);
            this.OutputDirectory_Label.TabIndex = 2;
            // 
            // OutputDirectoryBrowse_Button
            // 
            this.OutputDirectoryBrowse_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputDirectoryBrowse_Button.Location = new System.Drawing.Point(207, 27);
            this.OutputDirectoryBrowse_Button.Name = "OutputDirectoryBrowse_Button";
            this.OutputDirectoryBrowse_Button.Size = new System.Drawing.Size(75, 20);
            this.OutputDirectoryBrowse_Button.TabIndex = 3;
            this.OutputDirectoryBrowse_Button.Text = "Browse...";
            this.OutputDirectoryBrowse_Button.UseVisualStyleBackColor = true;
            // 
            // SpreadsheetID_Label
            // 
            this.SpreadsheetID_Label.AutoSize = true;
            this.SpreadsheetID_Label.Location = new System.Drawing.Point(15, 54);
            this.SpreadsheetID_Label.Name = "SpreadsheetID_Label";
            this.SpreadsheetID_Label.Size = new System.Drawing.Size(81, 13);
            this.SpreadsheetID_Label.TabIndex = 4;
            this.SpreadsheetID_Label.Text = "Spreadsheet ID";
            // 
            // SpreadsheetID_Textbox
            // 
            this.SpreadsheetID_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpreadsheetID_Textbox.Location = new System.Drawing.Point(18, 71);
            this.SpreadsheetID_Textbox.Name = "SpreadsheetID_Textbox";
            this.SpreadsheetID_Textbox.Size = new System.Drawing.Size(264, 20);
            this.SpreadsheetID_Textbox.TabIndex = 5;
            // 
            // SpreadsheetClear_Button
            // 
            this.SpreadsheetClear_Button.Location = new System.Drawing.Point(18, 98);
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
            this.Columns_Button.Location = new System.Drawing.Point(18, 128);
            this.Columns_Button.Name = "Columns_Button";
            this.Columns_Button.Size = new System.Drawing.Size(47, 13);
            this.Columns_Button.TabIndex = 7;
            this.Columns_Button.Text = "Columns";
            // 
            // Columns_NumericUpDown
            // 
            this.Columns_NumericUpDown.Location = new System.Drawing.Point(21, 145);
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
            this.Columns_DataGridView.Location = new System.Drawing.Point(21, 171);
            this.Columns_DataGridView.Name = "Columns_DataGridView";
            this.Columns_DataGridView.Size = new System.Drawing.Size(265, 72);
            this.Columns_DataGridView.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 489);
            this.Controls.Add(this.Columns_DataGridView);
            this.Controls.Add(this.Columns_NumericUpDown);
            this.Controls.Add(this.Columns_Button);
            this.Controls.Add(this.SpreadsheetClear_Button);
            this.Controls.Add(this.SpreadsheetID_Textbox);
            this.Controls.Add(this.SpreadsheetID_Label);
            this.Controls.Add(this.OutputDirectoryBrowse_Button);
            this.Controls.Add(this.OutputDirectory_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(314, 528);
            this.Name = "Form1";
            this.Text = "Sheets2CSV Settings";
            ((System.ComponentModel.ISupportInitialize)(this.Columns_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox OutputDirectory_Label;
        private System.Windows.Forms.Button OutputDirectoryBrowse_Button;
        private System.Windows.Forms.Label SpreadsheetID_Label;
        private System.Windows.Forms.TextBox SpreadsheetID_Textbox;
        private System.Windows.Forms.Button SpreadsheetClear_Button;
        private System.Windows.Forms.Label Columns_Button;
        private System.Windows.Forms.NumericUpDown Columns_NumericUpDown;
        private System.Windows.Forms.DataGridView Columns_DataGridView;
    }
}

