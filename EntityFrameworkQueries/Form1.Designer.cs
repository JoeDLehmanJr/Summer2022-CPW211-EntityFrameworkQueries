namespace EntityFrameworkQueries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSelectAllVendars = new System.Windows.Forms.Button();
            this.BtnAllCaliVendors = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSelectAllVendars
            // 
            this.BtnSelectAllVendars.Location = new System.Drawing.Point(27, 23);
            this.BtnSelectAllVendars.Name = "BtnSelectAllVendars";
            this.BtnSelectAllVendars.Size = new System.Drawing.Size(170, 23);
            this.BtnSelectAllVendars.TabIndex = 0;
            this.BtnSelectAllVendars.Text = "Select * From vendors";
            this.BtnSelectAllVendars.UseVisualStyleBackColor = true;
            this.BtnSelectAllVendars.Click += new System.EventHandler(this.BtnSelectAllVendars_Click);
            // 
            // BtnAllCaliVendors
            // 
            this.BtnAllCaliVendors.Location = new System.Drawing.Point(27, 112);
            this.BtnAllCaliVendors.Name = "BtnAllCaliVendors";
            this.BtnAllCaliVendors.Size = new System.Drawing.Size(549, 23);
            this.BtnAllCaliVendors.TabIndex = 1;
            this.BtnAllCaliVendors.Text = "Select From Vendors Where VendorState = \'CA\' OrderBy VendorName ASC";
            this.BtnAllCaliVendors.UseVisualStyleBackColor = true;
            this.BtnAllCaliVendors.Click += new System.EventHandler(this.BtnAllCaliVendors_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnAllCaliVendors);
            this.Controls.Add(this.BtnSelectAllVendars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnSelectAllVendars;
        private Button BtnAllCaliVendors;
        private Button button3;
    }
}