
namespace CS361_Tracker_App
{
    partial class Entry_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry_Add));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.btn_UploadPicture = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Hamburger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(-2, 22);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(574, 97);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Walking Entry";
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(254, 245);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(100, 20);
            this.txt_Title.TabIndex = 1;
            this.txt_Title.Text = "Title";
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(254, 329);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(100, 20);
            this.txt_Location.TabIndex = 2;
            this.txt_Location.Text = "Location";
            // 
            // txt_Time
            // 
            this.txt_Time.Location = new System.Drawing.Point(254, 396);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(100, 20);
            this.txt_Time.TabIndex = 3;
            this.txt_Time.Text = "Time";
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(208, 454);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(200, 78);
            this.txt_Notes.TabIndex = 4;
            this.txt_Notes.Text = "Entry Notes";
            // 
            // btn_UploadPicture
            // 
            this.btn_UploadPicture.Location = new System.Drawing.Point(263, 571);
            this.btn_UploadPicture.Name = "btn_UploadPicture";
            this.btn_UploadPicture.Size = new System.Drawing.Size(91, 23);
            this.btn_UploadPicture.TabIndex = 5;
            this.btn_UploadPicture.Text = "Upload Picture";
            this.btn_UploadPicture.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(136, 667);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(370, 667);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 7;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Hamburger
            // 
            this.btn_Hamburger.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hamburger.Image")));
            this.btn_Hamburger.Location = new System.Drawing.Point(536, 12);
            this.btn_Hamburger.Name = "btn_Hamburger";
            this.btn_Hamburger.Size = new System.Drawing.Size(36, 27);
            this.btn_Hamburger.TabIndex = 8;
            this.btn_Hamburger.UseVisualStyleBackColor = true;
            this.btn_Hamburger.Click += new System.EventHandler(this.btn_Hamburger_Click);
            // 
            // Entry_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.btn_Hamburger);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_UploadPicture);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Entry_Add";
            this.Text = "Entry_Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.TextBox txt_Time;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Button btn_UploadPicture;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Hamburger;
    }
}