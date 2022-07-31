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
            this.BtnSelectSpecificColumns = new System.Windows.Forms.Button();
            this.BtnMiscQueries = new System.Windows.Forms.Button();
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
            // BtnSelectSpecificColumns
            // 
            this.BtnSelectSpecificColumns.Location = new System.Drawing.Point(27, 187);
            this.BtnSelectSpecificColumns.Name = "BtnSelectSpecificColumns";
            this.BtnSelectSpecificColumns.Size = new System.Drawing.Size(549, 23);
            this.BtnSelectSpecificColumns.TabIndex = 2;
            this.BtnSelectSpecificColumns.Text = "Select VendorName, VendorCity, VendorState From Vendors";
            this.BtnSelectSpecificColumns.UseVisualStyleBackColor = true;
            this.BtnSelectSpecificColumns.Click += new System.EventHandler(this.BtnSelectSpecificColumns_Click);
            // 
            // BtnMiscQueries
            // 
            this.BtnMiscQueries.Location = new System.Drawing.Point(27, 297);
            this.BtnMiscQueries.Name = "BtnMiscQueries";
            this.BtnMiscQueries.Size = new System.Drawing.Size(549, 23);
            this.BtnMiscQueries.TabIndex = 3;
            this.BtnMiscQueries.Text = "Misc. Queries";
            this.BtnMiscQueries.UseVisualStyleBackColor = true;
            this.BtnMiscQueries.Click += new System.EventHandler(this.BtnMiscQueries_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMiscQueries);
            this.Controls.Add(this.BtnSelectSpecificColumns);
            this.Controls.Add(this.BtnAllCaliVendors);
            this.Controls.Add(this.BtnSelectAllVendars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnSelectAllVendars;
        private Button BtnAllCaliVendors;
        private Button BtnSelectSpecificColumns;
        private Button BtnMiscQueries;
    }
}