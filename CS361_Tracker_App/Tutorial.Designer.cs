
namespace CS361_Tracker_App
{
    partial class Tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorial));
            this.Title = new System.Windows.Forms.Label();
            this.btn_Skip = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.lbl_FlavorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(121, 43);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(332, 97);
            this.Title.TabIndex = 0;
            this.Title.Text = "Tutorial";
            // 
            // btn_Skip
            // 
            this.btn_Skip.Location = new System.Drawing.Point(106, 587);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 1;
            this.btn_Skip.Text = "Skip";
            this.btn_Skip.UseVisualStyleBackColor = true;
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(378, 587);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // lbl_FlavorText
            // 
            this.lbl_FlavorText.AutoSize = true;
            this.lbl_FlavorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FlavorText.Location = new System.Drawing.Point(213, 188);
            this.lbl_FlavorText.Name = "lbl_FlavorText";
            this.lbl_FlavorText.Size = new System.Drawing.Size(158, 300);
            this.lbl_FlavorText.TabIndex = 3;
            this.lbl_FlavorText.Text = resources.GetString("lbl_FlavorText.Text");
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.lbl_FlavorText);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.Title);
            this.Name = "Tutorial";
            this.Text = "Tutorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btn_Skip;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label lbl_FlavorText;
    }
}