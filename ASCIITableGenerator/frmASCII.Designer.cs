namespace ASCIITableGenerator
{
    partial class frmASCII
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
            this.lvwASCII = new System.Windows.Forms.ListView();
            this.lvwASCII2 = new System.Windows.Forms.ListView();
            this.lvwASCII3 = new System.Windows.Forms.ListView();
            this.lbxResults = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblDirections = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwASCII
            // 
            this.lvwASCII.BackColor = System.Drawing.Color.Gray;
            this.lvwASCII.ForeColor = System.Drawing.Color.Firebrick;
            this.lvwASCII.HideSelection = false;
            this.lvwASCII.Location = new System.Drawing.Point(12, 12);
            this.lvwASCII.Name = "lvwASCII";
            this.lvwASCII.Size = new System.Drawing.Size(106, 381);
            this.lvwASCII.TabIndex = 0;
            this.lvwASCII.UseCompatibleStateImageBehavior = false;
            // 
            // lvwASCII2
            // 
            this.lvwASCII2.HideSelection = false;
            this.lvwASCII2.Location = new System.Drawing.Point(12, 12);
            this.lvwASCII2.Name = "lvwASCII2";
            this.lvwASCII2.Size = new System.Drawing.Size(106, 381);
            this.lvwASCII2.TabIndex = 1;
            this.lvwASCII2.UseCompatibleStateImageBehavior = false;
            this.lvwASCII2.Visible = false;
            // 
            // lvwASCII3
            // 
            this.lvwASCII3.HideSelection = false;
            this.lvwASCII3.Location = new System.Drawing.Point(12, 12);
            this.lvwASCII3.Name = "lvwASCII3";
            this.lvwASCII3.Size = new System.Drawing.Size(106, 381);
            this.lvwASCII3.TabIndex = 2;
            this.lvwASCII3.UseCompatibleStateImageBehavior = false;
            this.lvwASCII3.Visible = false;
            // 
            // lbxResults
            // 
            this.lbxResults.FormattingEnabled = true;
            this.lbxResults.Location = new System.Drawing.Point(124, 12);
            this.lbxResults.Name = "lbxResults";
            this.lbxResults.Size = new System.Drawing.Size(120, 381);
            this.lbxResults.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.Location = new System.Drawing.Point(28, 399);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.Location = new System.Drawing.Point(147, 399);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(12, 446);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(230, 20);
            this.tbxSearch.TabIndex = 6;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(56, 430);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(143, 13);
            this.lblDirections.TabIndex = 7;
            this.lblDirections.Text = "Enter Character to search for";
            // 
            // frmASCII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(254, 475);
            this.ControlBox = false;
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lvwASCII);
            this.Controls.Add(this.lbxResults);
            this.Controls.Add(this.lvwASCII3);
            this.Controls.Add(this.lvwASCII2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmASCII";
            this.Text = "ASCII Character Search";
            this.Load += new System.EventHandler(this.frmASCII_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwASCII;
        private System.Windows.Forms.ListView lvwASCII2;
        private System.Windows.Forms.ListView lvwASCII3;
        private System.Windows.Forms.ListBox lbxResults;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblDirections;
    }
}

