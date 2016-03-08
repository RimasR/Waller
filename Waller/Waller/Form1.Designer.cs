namespace Waller
{
    partial class FormWaller
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
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelWallpaperPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(12, 113);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(260, 20);
            this.textBoxURL.TabIndex = 0;
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(12, 97);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(60, 13);
            this.labelUrl.TabIndex = 1;
            this.labelUrl.Text = "Enter URL:";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(12, 139);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(65, 23);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelWallpaperPath
            // 
            this.labelWallpaperPath.AutoSize = true;
            this.labelWallpaperPath.Location = new System.Drawing.Point(12, 191);
            this.labelWallpaperPath.Name = "labelWallpaperPath";
            this.labelWallpaperPath.Size = new System.Drawing.Size(0, 13);
            this.labelWallpaperPath.TabIndex = 3;
            // 
            // FormWaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelWallpaperPath);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.textBoxURL);
            this.Name = "FormWaller";
            this.Text = "Waller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelWallpaperPath;
    }
}

