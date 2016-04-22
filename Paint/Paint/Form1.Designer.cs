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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.eraser = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.pen = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.romb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(560, 120);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(733, 24);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::Paint.Properties.Resources._1460118867_menu_dropdown;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Paint.Properties.Resources._1460116346_new10;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Paint.Properties.Resources._1460116378_folder_open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Paint.Properties.Resources._1460116230_floppy;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Paint.Properties.Resources._1460117223_Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // eraser
            // 
            this.eraser.Image = global::Paint.Properties.Resources._1460198028_eraser;
            this.eraser.Location = new System.Drawing.Point(619, 47);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(57, 67);
            this.eraser.TabIndex = 10;
            this.eraser.UseVisualStyleBackColor = true;
            this.eraser.Click += new System.EventHandler(this.shape_click);
            // 
            // color
            // 
            this.color.Image = global::Paint.Properties.Resources._1460194610_drawing_06;
            this.color.Location = new System.Drawing.Point(560, 47);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(53, 67);
            this.color.TabIndex = 6;
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // line
            // 
            this.line.Image = global::Paint.Properties.Resources._1460114283_minus;
            this.line.Location = new System.Drawing.Point(344, 518);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(77, 67);
            this.line.TabIndex = 5;
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.shape_click);
            // 
            // rectangle
            // 
            this.rectangle.Image = global::Paint.Properties.Resources._1460057046_button_shape_rectangle1;
            this.rectangle.Location = new System.Drawing.Point(95, 518);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(77, 67);
            this.rectangle.TabIndex = 4;
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.shape_click);
            // 
            // triangle
            // 
            this.triangle.Image = global::Paint.Properties.Resources._1460057108_button_shape_triangle;
            this.triangle.Location = new System.Drawing.Point(178, 518);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(77, 67);
            this.triangle.TabIndex = 3;
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.Click += new System.EventHandler(this.shape_click);
            // 
            // circle
            // 
            this.circle.Image = global::Paint.Properties.Resources._1460057158_icon_ios7_circle_outline;
            this.circle.Location = new System.Drawing.Point(261, 518);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(77, 67);
            this.circle.TabIndex = 2;
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.shape_click);
            // 
            // pen
            // 
            this.pen.Image = global::Paint.Properties.Resources._1460056991_15_Pencil;
            this.pen.Location = new System.Drawing.Point(12, 518);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(77, 67);
            this.pen.TabIndex = 1;
            this.pen.UseVisualStyleBackColor = true;
            this.pen.Click += new System.EventHandler(this.shape_click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.Location = new System.Drawing.Point(12, 47);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(542, 465);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // romb
            // 
            this.romb.Location = new System.Drawing.Point(427, 518);
            this.romb.Name = "romb";
            this.romb.Size = new System.Drawing.Size(77, 67);
            this.romb.TabIndex = 13;
            this.romb.Text = "ромб";
            this.romb.UseVisualStyleBackColor = true;
            this.romb.Click += new System.EventHandler(this.shape_click);
            // 
            // button1
            // 
            this.button1.Image = global::Paint.Properties.Resources._1460114468_preferences_desktop_color;
            this.button1.Location = new System.Drawing.Point(560, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 67);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.romb);
            this.Controls.Add(this.eraser);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.color);
            this.Controls.Add(this.line);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.triangle);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.pen);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Button romb;
        private System.Windows.Forms.Button button1;
    }
}

