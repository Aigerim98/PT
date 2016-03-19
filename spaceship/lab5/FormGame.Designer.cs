namespace lab5
{
    partial class FormGame
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
            this.rocket = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).BeginInit();
            this.SuspendLayout();
            // 
            // rocket
            // 
            this.rocket.Image = global::lab5.Properties.Resources.kosm001;
            this.rocket.Location = new System.Drawing.Point(231, 508);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(81, 65);
            this.rocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rocket.TabIndex = 0;
            this.rocket.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab5.Properties.Resources.kosmos_05;
            this.ClientSize = new System.Drawing.Size(590, 571);
            this.Controls.Add(this.rocket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormGame";
            this.Shown += new System.EventHandler(this.FormGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox rocket;
    }
}