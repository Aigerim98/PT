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
            this.components = new System.ComponentModel.Container();
            this.rocket = new System.Windows.Forms.PictureBox();
            this.gun = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            // gun
            // 
            this.gun.AutoSize = true;
            this.gun.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gun.Enabled = false;
            this.gun.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gun.Location = new System.Drawing.Point(264, 489);
            this.gun.Name = "gun";
            this.gun.Size = new System.Drawing.Size(14, 13);
            this.gun.TabIndex = 1;
            this.gun.UseVisualStyleBackColor = false;
            this.gun.CheckedChanged += new System.EventHandler(this.gun_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab5.Properties.Resources.kosmos_05;
            this.ClientSize = new System.Drawing.Size(590, 571);
            this.Controls.Add(this.gun);
            this.Controls.Add(this.rocket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormGame";
            this.Shown += new System.EventHandler(this.FormGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rocket;
        private System.Windows.Forms.RadioButton gun;
        private System.Windows.Forms.Timer timer1;
    }
}