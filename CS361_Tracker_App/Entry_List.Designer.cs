
namespace CS361_Tracker_App
{
    partial class Entry_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry_List));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_NewEntry = new System.Windows.Forms.Button();
            this.btn_Entry1 = new System.Windows.Forms.Button();
            this.btn_Edit1 = new System.Windows.Forms.Button();
            this.btn_Delete1 = new System.Windows.Forms.Button();
            this.btn_Hamburger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(47, 32);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(477, 73);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Walking Entries";
            // 
            // btn_NewEntry
            // 
            this.btn_NewEntry.Location = new System.Drawing.Point(264, 640);
            this.btn_NewEntry.Name = "btn_NewEntry";
            this.btn_NewEntry.Size = new System.Drawing.Size(75, 23);
            this.btn_NewEntry.TabIndex = 1;
            this.btn_NewEntry.Text = "New Entry";
            this.btn_NewEntry.UseVisualStyleBackColor = true;
            this.btn_NewEntry.Click += new System.EventHandler(this.btn_NewEntry_Click);
            // 
            // btn_Entry1
            // 
            this.btn_Entry1.Location = new System.Drawing.Point(88, 193);
            this.btn_Entry1.Name = "btn_Entry1";
            this.btn_Entry1.Size = new System.Drawing.Size(75, 23);
            this.btn_Entry1.TabIndex = 2;
            this.btn_Entry1.Text = "Entry 1";
            this.btn_Entry1.UseVisualStyleBackColor = true;
            // 
            // btn_Edit1
            // 
            this.btn_Edit1.Location = new System.Drawing.Point(253, 193);
            this.btn_Edit1.Name = "btn_Edit1";
            this.btn_Edit1.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit1.TabIndex = 3;
            this.btn_Edit1.Text = "Edit";
            this.btn_Edit1.UseVisualStyleBackColor = true;
            // 
            // btn_Delete1
            // 
            this.btn_Delete1.Location = new System.Drawing.Point(409, 193);
            this.btn_Delete1.Name = "btn_Delete1";
            this.btn_Delete1.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete1.TabIndex = 4;
            this.btn_Delete1.Text = "Delete";
            this.btn_Delete1.UseVisualStyleBackColor = true;
            this.btn_Delete1.Click += new System.EventHandler(this.btn_Delete1_Click);
            // 
            // btn_Hamburger
            // 
            this.btn_Hamburger.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hamburger.Image")));
            this.btn_Hamburger.Location = new System.Drawing.Point(497, 12);
            this.btn_Hamburger.Name = "btn_Hamburger";
            this.btn_Hamburger.Size = new System.Drawing.Size(75, 31);
            this.btn_Hamburger.TabIndex = 7;
            this.btn_Hamburger.UseVisualStyleBackColor = true;
            this.btn_Hamburger.Click += new System.EventHandler(this.btn_Hamburger_Click);
            // 
            // Entry_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.btn_Hamburger);
            this.Controls.Add(this.btn_Delete1);
            this.Controls.Add(this.btn_Edit1);
            this.Controls.Add(this.btn_Entry1);
            this.Controls.Add(this.btn_NewEntry);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Entry_List";
            this.Text = "Entry_List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_NewEntry;
        private System.Windows.Forms.Button btn_Entry1;
        private System.Windows.Forms.Button btn_Edit1;
        private System.Windows.Forms.Button btn_Delete1;
        private System.Windows.Forms.Button btn_Hamburger;
    }
}