
namespace CS361_Tracker_App
{
    partial class Metrics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Metrics));
            this.lbl_Metrics = new System.Windows.Forms.Label();
            this.lbl_TimeFrame = new System.Windows.Forms.Label();
            this.btn_Weekly = new System.Windows.Forms.Button();
            this.btn_Monthly = new System.Windows.Forms.Button();
            this.btn_Yearly = new System.Windows.Forms.Button();
            this.data_Metrics = new System.Windows.Forms.DataGridView();
            this.btn_Hamburger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Metrics)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Metrics
            // 
            this.lbl_Metrics.AutoSize = true;
            this.lbl_Metrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Metrics.Location = new System.Drawing.Point(132, 30);
            this.lbl_Metrics.Name = "lbl_Metrics";
            this.lbl_Metrics.Size = new System.Drawing.Size(321, 97);
            this.lbl_Metrics.TabIndex = 0;
            this.lbl_Metrics.Text = "Metrics";
            // 
            // lbl_TimeFrame
            // 
            this.lbl_TimeFrame.AutoSize = true;
            this.lbl_TimeFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeFrame.Location = new System.Drawing.Point(192, 136);
            this.lbl_TimeFrame.Name = "lbl_TimeFrame";
            this.lbl_TimeFrame.Size = new System.Drawing.Size(181, 37);
            this.lbl_TimeFrame.TabIndex = 1;
            this.lbl_TimeFrame.Text = "TimeFrame";
            // 
            // btn_Weekly
            // 
            this.btn_Weekly.Location = new System.Drawing.Point(60, 693);
            this.btn_Weekly.Name = "btn_Weekly";
            this.btn_Weekly.Size = new System.Drawing.Size(75, 23);
            this.btn_Weekly.TabIndex = 2;
            this.btn_Weekly.Text = "Weekly";
            this.btn_Weekly.UseVisualStyleBackColor = true;
            this.btn_Weekly.Click += new System.EventHandler(this.btn_Weekly_Click);
            // 
            // btn_Monthly
            // 
            this.btn_Monthly.Location = new System.Drawing.Point(221, 692);
            this.btn_Monthly.Name = "btn_Monthly";
            this.btn_Monthly.Size = new System.Drawing.Size(75, 23);
            this.btn_Monthly.TabIndex = 3;
            this.btn_Monthly.Text = "Monthly";
            this.btn_Monthly.UseVisualStyleBackColor = true;
            this.btn_Monthly.Click += new System.EventHandler(this.btn_Monthly_Click);
            // 
            // btn_Yearly
            // 
            this.btn_Yearly.Location = new System.Drawing.Point(413, 692);
            this.btn_Yearly.Name = "btn_Yearly";
            this.btn_Yearly.Size = new System.Drawing.Size(75, 23);
            this.btn_Yearly.TabIndex = 4;
            this.btn_Yearly.Text = "Yearly";
            this.btn_Yearly.UseVisualStyleBackColor = true;
            this.btn_Yearly.Click += new System.EventHandler(this.btn_Yearly_Click);
            // 
            // data_Metrics
            // 
            this.data_Metrics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Metrics.Location = new System.Drawing.Point(167, 281);
            this.data_Metrics.Name = "data_Metrics";
            this.data_Metrics.Size = new System.Drawing.Size(240, 150);
            this.data_Metrics.TabIndex = 5;
            // 
            // btn_Hamburger
            // 
            this.btn_Hamburger.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hamburger.Image")));
            this.btn_Hamburger.Location = new System.Drawing.Point(538, 12);
            this.btn_Hamburger.Name = "btn_Hamburger";
            this.btn_Hamburger.Size = new System.Drawing.Size(34, 28);
            this.btn_Hamburger.TabIndex = 7;
            this.btn_Hamburger.UseVisualStyleBackColor = true;
            this.btn_Hamburger.Click += new System.EventHandler(this.btn_Hamburger_Click);
            // 
            // Metrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.btn_Hamburger);
            this.Controls.Add(this.data_Metrics);
            this.Controls.Add(this.btn_Yearly);
            this.Controls.Add(this.btn_Monthly);
            this.Controls.Add(this.btn_Weekly);
            this.Controls.Add(this.lbl_TimeFrame);
            this.Controls.Add(this.lbl_Metrics);
            this.Name = "Metrics";
            this.Text = "Metrics";
            ((System.ComponentModel.ISupportInitialize)(this.data_Metrics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Metrics;
        private System.Windows.Forms.Label lbl_TimeFrame;
        private System.Windows.Forms.Button btn_Weekly;
        private System.Windows.Forms.Button btn_Monthly;
        private System.Windows.Forms.Button btn_Yearly;
        private System.Windows.Forms.DataGridView data_Metrics;
        private System.Windows.Forms.Button btn_Hamburger;
    }
}