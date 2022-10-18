
namespace CS361_Tracker_App
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Metrics = new System.Windows.Forms.Button();
            this.btn_Entries = new System.Windows.Forms.Button();
            this.data_Pie = new System.Windows.Forms.DataGridView();
            this.lbl_Tip = new System.Windows.Forms.Label();
            this.btn_Hamburger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Pie)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(42, 43);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(508, 73);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Your Day So Far";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 143);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btn_Metrics
            // 
            this.btn_Metrics.Location = new System.Drawing.Point(55, 679);
            this.btn_Metrics.Name = "btn_Metrics";
            this.btn_Metrics.Size = new System.Drawing.Size(113, 23);
            this.btn_Metrics.TabIndex = 2;
            this.btn_Metrics.Text = "Metrics (Advanced)";
            this.btn_Metrics.UseVisualStyleBackColor = true;
            this.btn_Metrics.Click += new System.EventHandler(this.btn_Metrics_Click);
            // 
            // btn_Entries
            // 
            this.btn_Entries.Location = new System.Drawing.Point(357, 679);
            this.btn_Entries.Name = "btn_Entries";
            this.btn_Entries.Size = new System.Drawing.Size(75, 23);
            this.btn_Entries.TabIndex = 3;
            this.btn_Entries.Text = "Entries";
            this.btn_Entries.UseVisualStyleBackColor = true;
            this.btn_Entries.Click += new System.EventHandler(this.btn_Entries_Click);
            // 
            // data_Pie
            // 
            this.data_Pie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Pie.Location = new System.Drawing.Point(145, 442);
            this.data_Pie.Name = "data_Pie";
            this.data_Pie.Size = new System.Drawing.Size(240, 150);
            this.data_Pie.TabIndex = 4;
            // 
            // lbl_Tip
            // 
            this.lbl_Tip.AutoSize = true;
            this.lbl_Tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tip.Location = new System.Drawing.Point(112, 328);
            this.lbl_Tip.Name = "lbl_Tip";
            this.lbl_Tip.Size = new System.Drawing.Size(347, 52);
            this.lbl_Tip.TabIndex = 5;
            this.lbl_Tip.Text = "Use the Metrics section to track\r\nyour health and activity goals.";
            // 
            // btn_Hamburger
            // 
            this.btn_Hamburger.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hamburger.Image")));
            this.btn_Hamburger.Location = new System.Drawing.Point(538, 12);
            this.btn_Hamburger.Name = "btn_Hamburger";
            this.btn_Hamburger.Size = new System.Drawing.Size(34, 28);
            this.btn_Hamburger.TabIndex = 6;
            this.btn_Hamburger.UseVisualStyleBackColor = true;
            this.btn_Hamburger.Click += new System.EventHandler(this.btn_Hamburger_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.btn_Hamburger);
            this.Controls.Add(this.lbl_Tip);
            this.Controls.Add(this.data_Pie);
            this.Controls.Add(this.btn_Entries);
            this.Controls.Add(this.btn_Metrics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.data_Pie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Metrics;
        private System.Windows.Forms.Button btn_Entries;
        private System.Windows.Forms.DataGridView data_Pie;
        private System.Windows.Forms.Label lbl_Tip;
        private System.Windows.Forms.Button btn_Hamburger;
    }
}