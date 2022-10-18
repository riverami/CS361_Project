
namespace CS361_Tracker_App
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.btn_Hamburger = new System.Windows.Forms.Button();
            this.btn_Tutorial = new System.Windows.Forms.Button();
            this.btn_DeactivateAccount = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Hamburger
            // 
            this.btn_Hamburger.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hamburger.Image")));
            this.btn_Hamburger.Location = new System.Drawing.Point(539, 12);
            this.btn_Hamburger.Name = "btn_Hamburger";
            this.btn_Hamburger.Size = new System.Drawing.Size(33, 27);
            this.btn_Hamburger.TabIndex = 7;
            this.btn_Hamburger.UseVisualStyleBackColor = true;
            this.btn_Hamburger.Click += new System.EventHandler(this.btn_Hamburger_Click);
            // 
            // btn_Tutorial
            // 
            this.btn_Tutorial.Location = new System.Drawing.Point(265, 503);
            this.btn_Tutorial.Name = "btn_Tutorial";
            this.btn_Tutorial.Size = new System.Drawing.Size(119, 23);
            this.btn_Tutorial.TabIndex = 8;
            this.btn_Tutorial.Text = "Tutorial";
            this.btn_Tutorial.UseVisualStyleBackColor = true;
            this.btn_Tutorial.Click += new System.EventHandler(this.btn_Tutorial_Click);
            // 
            // btn_DeactivateAccount
            // 
            this.btn_DeactivateAccount.Location = new System.Drawing.Point(265, 574);
            this.btn_DeactivateAccount.Name = "btn_DeactivateAccount";
            this.btn_DeactivateAccount.Size = new System.Drawing.Size(119, 23);
            this.btn_DeactivateAccount.TabIndex = 9;
            this.btn_DeactivateAccount.Text = "Deactivate Account";
            this.btn_DeactivateAccount.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(287, 684);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(124, 44);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(354, 97);
            this.lbl_Title.TabIndex = 11;
            this.lbl_Title.Text = "Settings";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_DeactivateAccount);
            this.Controls.Add(this.btn_Tutorial);
            this.Controls.Add(this.btn_Hamburger);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Hamburger;
        private System.Windows.Forms.Button btn_Tutorial;
        private System.Windows.Forms.Button btn_DeactivateAccount;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Title;
    }
}