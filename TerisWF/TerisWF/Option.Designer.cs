namespace TerisWF.Properties
{
    partial class Option_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option_menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trk_Sound = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_speaker = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Sound)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_speaker)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Teletoon Lowercase", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = ".OPTION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Teletoon Lowercase", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(133)))));
            this.label2.Location = new System.Drawing.Point(34, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 94);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOUND ON/OFF";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trk_Sound
            // 
            this.trk_Sound.BackColor = System.Drawing.Color.Silver;
            this.trk_Sound.Location = new System.Drawing.Point(86, 212);
            this.trk_Sound.Maximum = 100;
            this.trk_Sound.Name = "trk_Sound";
            this.trk_Sound.Size = new System.Drawing.Size(159, 45);
            this.trk_Sound.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImage = global::TerisWF.Properties.Resources.hm;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_speaker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trk_Sound);
            this.panel1.Location = new System.Drawing.Point(24, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 445);
            this.panel1.TabIndex = 4;
            // 
            // btn_speaker
            // 
            this.btn_speaker.BackColor = System.Drawing.Color.Silver;
            this.btn_speaker.Image = ((System.Drawing.Image)(resources.GetObject("btn_speaker.Image")));
            this.btn_speaker.Location = new System.Drawing.Point(135, 263);
            this.btn_speaker.Name = "btn_speaker";
            this.btn_speaker.Size = new System.Drawing.Size(60, 60);
            this.btn_speaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_speaker.TabIndex = 3;
            this.btn_speaker.TabStop = false;
            // 
            // Option_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(357, 551);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(373, 590);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(373, 590);
            this.Name = "Option_menu";
            this.Text = "Option";
            ((System.ComponentModel.ISupportInitialize)(this.trk_Sound)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_speaker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trk_Sound;
        private System.Windows.Forms.PictureBox btn_speaker;
        private System.Windows.Forms.Panel panel1;
    }
}