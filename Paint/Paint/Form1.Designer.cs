namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.color = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.pen = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // color
            // 
            this.color.Image = global::Paint.Properties.Resources._1460114468_preferences_desktop_color;
            this.color.Location = new System.Drawing.Point(560, 12);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(88, 67);
            this.color.TabIndex = 6;
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // line
            // 
            this.line.Image = global::Paint.Properties.Resources._1460114283_minus;
            this.line.Location = new System.Drawing.Point(344, 483);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(77, 67);
            this.line.TabIndex = 5;
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.shape_click);
            // 
            // rectangle
            // 
            this.rectangle.Image = global::Paint.Properties.Resources._1460057046_button_shape_rectangle1;
            this.rectangle.Location = new System.Drawing.Point(95, 483);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(77, 67);
            this.rectangle.TabIndex = 4;
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.shape_click);
            // 
            // triangle
            // 
            this.triangle.Image = global::Paint.Properties.Resources._1460057108_button_shape_triangle;
            this.triangle.Location = new System.Drawing.Point(178, 483);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(77, 67);
            this.triangle.TabIndex = 3;
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.Click += new System.EventHandler(this.shape_click);
            // 
            // circle
            // 
            this.circle.Image = global::Paint.Properties.Resources._1460057158_icon_ios7_circle_outline;
            this.circle.Location = new System.Drawing.Point(261, 483);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(77, 67);
            this.circle.TabIndex = 2;
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.shape_click);
            // 
            // pen
            // 
            this.pen.Image = global::Paint.Properties.Resources._1460056991_15_Pencil;
            this.pen.Location = new System.Drawing.Point(12, 483);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(77, 67);
            this.pen.TabIndex = 1;
            this.pen.UseVisualStyleBackColor = true;
            this.pen.Click += new System.EventHandler(this.shape_click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(542, 465);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(559, 85);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 562);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.color);
            this.Controls.Add(this.line);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.triangle);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.pen);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button pen;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

