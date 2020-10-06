namespace ASCIITableGenerator
{
    partial class frmColor
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
            this.btnDark = new System.Windows.Forms.Button();
            this.btnLight = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDark
            // 
            this.btnDark.BackColor = System.Drawing.Color.Black;
            this.btnDark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDark.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDark.Location = new System.Drawing.Point(12, 12);
            this.btnDark.Name = "btnDark";
            this.btnDark.Size = new System.Drawing.Size(100, 100);
            this.btnDark.TabIndex = 0;
            this.btnDark.Text = "&Dark\r\nTheme";
            this.btnDark.UseVisualStyleBackColor = false;
            this.btnDark.Click += new System.EventHandler(this.btnDark_Click);
            // 
            // btnLight
            // 
            this.btnLight.BackColor = System.Drawing.Color.White;
            this.btnLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLight.ForeColor = System.Drawing.Color.Black;
            this.btnLight.Location = new System.Drawing.Point(142, 12);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(100, 100);
            this.btnLight.TabIndex = 1;
            this.btnLight.Text = "&Light\r\nTheme";
            this.btnLight.UseVisualStyleBackColor = false;
            // 
            // btnGray
            // 
            this.btnGray.BackColor = System.Drawing.Color.DimGray;
            this.btnGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGray.ForeColor = System.Drawing.Color.Black;
            this.btnGray.Location = new System.Drawing.Point(12, 118);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(100, 100);
            this.btnGray.TabIndex = 2;
            this.btnGray.Text = "&Gray\r\nScale";
            this.btnGray.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.Location = new System.Drawing.Point(142, 118);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 100);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 226);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnLight);
            this.Controls.Add(this.btnDark);
            this.Name = "frmColor";
            this.Text = "Themes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDark;
        private System.Windows.Forms.Button btnLight;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnClose;
    }
}