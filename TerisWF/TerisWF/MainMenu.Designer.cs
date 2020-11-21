namespace TerisWF
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.PictureBox();
            this.btn_About = new System.Windows.Forms.PictureBox();
            this.btn_Tutorial = new System.Windows.Forms.PictureBox();
            this.btn_Start = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_About)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Tutorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Start)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BackgroundImage = global::TerisWF.Properties.Resources.PIC5;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_About);
            this.panel1.Controls.Add(this.btn_Tutorial);
            this.panel1.Controls.Add(this.btn_Start);
            this.panel1.Location = new System.Drawing.Point(48, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 456);
            this.panel1.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = global::TerisWF.Properties.Resources.exit_leave;
            this.btn_Exit.Location = new System.Drawing.Point(36, 296);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(187, 50);
            this.btn_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.MouseLeave += new System.EventHandler(this.btn_Exit_MouseLeave);
            this.btn_Exit.MouseHover += new System.EventHandler(this.btn_Exit_MouseHover);
            // 
            // btn_About
            // 
            this.btn_About.Image = global::TerisWF.Properties.Resources.about_leave;
            this.btn_About.Location = new System.Drawing.Point(36, 240);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(187, 50);
            this.btn_About.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_About.TabIndex = 1;
            this.btn_About.TabStop = false;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            this.btn_About.MouseLeave += new System.EventHandler(this.btn_About_MouseLeave);
            this.btn_About.MouseHover += new System.EventHandler(this.btn_About_MouseHover);
            // 
            // btn_Tutorial
            // 
            this.btn_Tutorial.Image = global::TerisWF.Properties.Resources.tutorial_leave;
            this.btn_Tutorial.Location = new System.Drawing.Point(36, 184);
            this.btn_Tutorial.Name = "btn_Tutorial";
            this.btn_Tutorial.Size = new System.Drawing.Size(187, 50);
            this.btn_Tutorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Tutorial.TabIndex = 2;
            this.btn_Tutorial.TabStop = false;
            this.btn_Tutorial.Click += new System.EventHandler(this.btn_Tutorial_Click);
            this.btn_Tutorial.MouseLeave += new System.EventHandler(this.btn_Tutorial_MouseLeave);
            this.btn_Tutorial.MouseHover += new System.EventHandler(this.btn_Tutorial_MouseHover);
            // 
            // btn_Start
            // 
            this.btn_Start.Image = global::TerisWF.Properties.Resources.start_leave;
            this.btn_Start.Location = new System.Drawing.Point(36, 128);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(187, 50);
            this.btn_Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Start.TabIndex = 0;
            this.btn_Start.TabStop = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            this.btn_Start.MouseLeave += new System.EventHandler(this.btn_Start_MouseLeave);
            this.btn_Start.MouseHover += new System.EventHandler(this.btn_Start_MouseHover);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 551);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(373, 590);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(373, 590);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_About)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Tutorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_About;
        private System.Windows.Forms.PictureBox btn_Tutorial;
        private System.Windows.Forms.PictureBox btn_Start;
        private System.Windows.Forms.PictureBox btn_Exit;
    }
}