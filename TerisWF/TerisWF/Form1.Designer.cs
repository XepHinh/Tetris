namespace TerisWF
{
    partial class Tetris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tetris));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.picNextTetromino = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNextTetromino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.tmrTick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Teletoon Lowercase", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Image = global::TerisWF.Properties.Resources._1;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = ".TETRIS.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLevel
            // 
            this.lblLevel.Font = new System.Drawing.Font("Teletoon Lowercase", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.Khaki;
            this.lblLevel.Image = global::TerisWF.Properties.Resources._3;
            this.lblLevel.Location = new System.Drawing.Point(255, 117);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(92, 25);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "Levels: 0";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picNextTetromino
            // 
            this.picNextTetromino.BackColor = System.Drawing.Color.White;
            this.picNextTetromino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNextTetromino.Location = new System.Drawing.Point(254, 205);
            this.picNextTetromino.Name = "picNextTetromino";
            this.picNextTetromino.Size = new System.Drawing.Size(92, 92);
            this.picNextTetromino.TabIndex = 4;
            this.picNextTetromino.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Teletoon Lowercase", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Image = global::TerisWF.Properties.Resources._4;
            this.label2.Location = new System.Drawing.Point(255, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Next: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Teletoon Lowercase", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Khaki;
            this.lblScore.Image = global::TerisWF.Properties.Resources._2;
            this.lblScore.Location = new System.Drawing.Point(254, 78);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(92, 30);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.White;
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(12, 78);
            this.picBox.MaximumSize = new System.Drawing.Size(230, 460);
            this.picBox.MinimumSize = new System.Drawing.Size(230, 460);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(230, 460);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 551);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picNextTetromino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tetris";
            this.Text = "Tetris";
            ((System.ComponentModel.ISupportInitialize)(this.picNextTetromino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblScore;        
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picNextTetromino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLevel;
    }
}

