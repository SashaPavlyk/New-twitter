namespace WFAPPTwitter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserPhotoBox = new System.Windows.Forms.PictureBox();
            this.EditProfileButton = new System.Windows.Forms.Button();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserAgeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserPhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPhotoBox
            // 
            this.UserPhotoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserPhotoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserPhotoBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserPhotoBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPhotoBox.Image")));
            this.UserPhotoBox.Location = new System.Drawing.Point(12, 12);
            this.UserPhotoBox.Name = "UserPhotoBox";
            this.UserPhotoBox.Size = new System.Drawing.Size(205, 193);
            this.UserPhotoBox.TabIndex = 0;
            this.UserPhotoBox.TabStop = false;
            // 
            // EditProfileButton
            // 
            this.EditProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EditProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditProfileButton.Location = new System.Drawing.Point(12, 292);
            this.EditProfileButton.Name = "EditProfileButton";
            this.EditProfileButton.Size = new System.Drawing.Size(90, 23);
            this.EditProfileButton.TabIndex = 1;
            this.EditProfileButton.Text = "Edit Profile";
            this.EditProfileButton.UseVisualStyleBackColor = false;
            this.EditProfileButton.Click += new System.EventHandler(this.EditProfileButton_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UserNameLabel.Location = new System.Drawing.Point(13, 212);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(89, 27);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "Unknown";
            // 
            // UserAgeLabel
            // 
            this.UserAgeLabel.AutoSize = true;
            this.UserAgeLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserAgeLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserAgeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UserAgeLabel.Location = new System.Drawing.Point(18, 252);
            this.UserAgeLabel.Name = "UserAgeLabel";
            this.UserAgeLabel.Size = new System.Drawing.Size(58, 27);
            this.UserAgeLabel.TabIndex = 3;
            this.UserAgeLabel.Text = "Age?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFAPPTwitter.Properties.Resources.bck;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserAgeLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.EditProfileButton);
            this.Controls.Add(this.UserPhotoBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserPhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UserPhotoBox;
        private System.Windows.Forms.Button EditProfileButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserAgeLabel;
    }
}

