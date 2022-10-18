
namespace CS361_Tracker_App
{
    partial class Hamburger
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
            this.btn_MainPage = new System.Windows.Forms.Button();
            this.btn_Entries = new System.Windows.Forms.Button();
            this.btn_Metrics = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MainPage
            // 
            this.btn_MainPage.Location = new System.Drawing.Point(255, 137);
            this.btn_MainPage.Name = "btn_MainPage";
            this.btn_MainPage.Size = new System.Drawing.Size(75, 23);
            this.btn_MainPage.TabIndex = 0;
            this.btn_MainPage.Text = "Main Page";
            this.btn_MainPage.UseVisualStyleBackColor = true;
            this.btn_MainPage.Click += new System.EventHandler(this.btn_MainPage_Click);
            // 
            // btn_Entries
            // 
            this.btn_Entries.Location = new System.Drawing.Point(255, 230);
            this.btn_Entries.Name = "btn_Entries";
            this.btn_Entries.Size = new System.Drawing.Size(75, 23);
            this.btn_Entries.TabIndex = 1;
            this.btn_Entries.Text = "Entries";
            this.btn_Entries.UseVisualStyleBackColor = true;
            this.btn_Entries.Click += new System.EventHandler(this.btn_Entries_Click);
            // 
            // btn_Metrics
            // 
            this.btn_Metrics.Location = new System.Drawing.Point(255, 315);
            this.btn_Metrics.Name = "btn_Metrics";
            this.btn_Metrics.Size = new System.Drawing.Size(75, 23);
            this.btn_Metrics.TabIndex = 2;
            this.btn_Metrics.Text = "Metrics (Advanced)";
            this.btn_Metrics.UseVisualStyleBackColor = true;
            this.btn_Metrics.Click += new System.EventHandler(this.btn_Metrics_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Location = new System.Drawing.Point(255, 403);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(75, 23);
            this.btn_Settings.TabIndex = 3;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // Hamburger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.btn_Metrics);
            this.Controls.Add(this.btn_Entries);
            this.Controls.Add(this.btn_MainPage);
            this.Name = "Hamburger";
            this.Text = "Hamburger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MainPage;
        private System.Windows.Forms.Button btn_Entries;
        private System.Windows.Forms.Button btn_Metrics;
        private System.Windows.Forms.Button btn_Settings;
    }
}