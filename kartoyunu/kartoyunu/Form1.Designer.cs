namespace kartoyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            labelOyuncuIsim = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            progressBarOyuncu = new ProgressBar();
            labelRakipIsim = new Label();
            labelOyuncuCan = new Label();
            labelRakipCan = new Label();
            progressBarRakip = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(51, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 184);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(270, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 184);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(487, 106);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 184);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // labelOyuncuIsim
            // 
            labelOyuncuIsim.AutoSize = true;
            labelOyuncuIsim.Location = new Point(-1, 9);
            labelOyuncuIsim.Name = "labelOyuncuIsim";
            labelOyuncuIsim.Size = new Size(36, 20);
            labelOyuncuIsim.TabIndex = 3;
            labelOyuncuIsim.Text = "isim";
            // 
            // button1
            // 
            button1.Location = new Point(65, 312);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "SEÇ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(286, 312);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "SEÇ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(502, 312);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "SEÇ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // progressBarOyuncu
            // 
            progressBarOyuncu.Location = new Point(51, 40);
            progressBarOyuncu.Name = "progressBarOyuncu";
            progressBarOyuncu.Size = new Size(125, 29);
            progressBarOyuncu.TabIndex = 7;
            // 
            // labelRakipIsim
            // 
            labelRakipIsim.AutoSize = true;
            labelRakipIsim.Location = new Point(523, 9);
            labelRakipIsim.Name = "labelRakipIsim";
            labelRakipIsim.Size = new Size(73, 20);
            labelRakipIsim.TabIndex = 8;
            labelRakipIsim.Text = "rakip isim";
            labelRakipIsim.Click += labelRakipIsim_Click;
            // 
            // labelOyuncuCan
            // 
            labelOyuncuCan.AutoSize = true;
            labelOyuncuCan.Location = new Point(158, 9);
            labelOyuncuCan.Name = "labelOyuncuCan";
            labelOyuncuCan.Size = new Size(36, 20);
            labelOyuncuCan.TabIndex = 9;
            labelOyuncuCan.Text = "can ";
            // 
            // labelRakipCan
            // 
            labelRakipCan.AutoSize = true;
            labelRakipCan.Location = new Point(704, 9);
            labelRakipCan.Name = "labelRakipCan";
            labelRakipCan.RightToLeft = RightToLeft.No;
            labelRakipCan.Size = new Size(69, 20);
            labelRakipCan.TabIndex = 10;
            labelRakipCan.Text = "rakip can";
            // 
            // progressBarRakip
            // 
            progressBarRakip.Location = new Point(629, 40);
            progressBarRakip.Name = "progressBarRakip";
            progressBarRakip.Size = new Size(125, 29);
            progressBarRakip.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBarRakip);
            Controls.Add(labelRakipCan);
            Controls.Add(labelOyuncuCan);
            Controls.Add(labelRakipIsim);
            Controls.Add(progressBarOyuncu);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelOyuncuIsim);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label labelOyuncuIsim;
        private Button button1;
        private Button button2;
        private Button button3;
        private ProgressBar progressBarOyuncu;
        private Label labelRakipIsim;
        private Label labelOyuncuCan;
        private Label labelRakipCan;
        private ProgressBar progressBarRakip;
    }
}
