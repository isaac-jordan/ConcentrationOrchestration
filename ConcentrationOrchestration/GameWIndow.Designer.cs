namespace ConcentrationOrchestration
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.CurrentMentalState = new System.Windows.Forms.Label();
            this.BallImage = new System.Windows.Forms.PictureBox();
            this.BallTrackImage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.transparentControl1 = new ConcentrationOrchestration.TransparentControl();
            this.transparentControl2 = new ConcentrationOrchestration.TransparentControl();
            ((System.ComponentModel.ISupportInitialize)(this.BallImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallTrackImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentMentalState
            // 
            this.CurrentMentalState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentMentalState.AutoSize = true;
            this.CurrentMentalState.Location = new System.Drawing.Point(645, 444);
            this.CurrentMentalState.Name = "CurrentMentalState";
            this.CurrentMentalState.Size = new System.Drawing.Size(35, 13);
            this.CurrentMentalState.TabIndex = 2;
            this.CurrentMentalState.Text = "label1";
            // 
            // BallImage
            // 
            this.BallImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BallImage.BackColor = System.Drawing.Color.Transparent;
            this.BallImage.Image = ((System.Drawing.Image)(resources.GetObject("BallImage.Image")));
            this.BallImage.InitialImage = null;
            this.BallImage.Location = new System.Drawing.Point(437, 305);
            this.BallImage.Name = "BallImage";
            this.BallImage.Size = new System.Drawing.Size(68, 10);
            this.BallImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BallImage.TabIndex = 6;
            this.BallImage.TabStop = false;
            // 
            // BallTrackImage
            // 
            this.BallTrackImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BallTrackImage.Image = ((System.Drawing.Image)(resources.GetObject("BallTrackImage.Image")));
            this.BallTrackImage.Location = new System.Drawing.Point(437, 72);
            this.BallTrackImage.Name = "BallTrackImage";
            this.BallTrackImage.Size = new System.Drawing.Size(68, 375);
            this.BallTrackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BallTrackImage.TabIndex = 7;
            this.BallTrackImage.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(818, 460);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // transparentControl1
            // 
            this.transparentControl1.BackColor = System.Drawing.Color.Transparent;
            this.transparentControl1.Image = ((System.Drawing.Image)(resources.GetObject("transparentControl1.Image")));
            this.transparentControl1.Location = new System.Drawing.Point(12, 15);
            this.transparentControl1.Name = "transparentControl1";
            this.transparentControl1.Size = new System.Drawing.Size(282, 220);
            this.transparentControl1.TabIndex = 10;
            this.transparentControl1.Text = "transparentControl1";
            // 
            // transparentControl2
            // 
            this.transparentControl2.BackColor = System.Drawing.Color.Transparent;
            this.transparentControl2.Image = ((System.Drawing.Image)(resources.GetObject("transparentControl2.Image")));
            this.transparentControl2.Location = new System.Drawing.Point(375, -2);
            this.transparentControl2.Name = "transparentControl2";
            this.transparentControl2.Size = new System.Drawing.Size(190, 94);
            this.transparentControl2.TabIndex = 11;
            this.transparentControl2.Text = "transparentControl2";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 459);
            this.Controls.Add(this.transparentControl2);
            this.Controls.Add(this.transparentControl1);
            this.Controls.Add(this.BallImage);
            this.Controls.Add(this.CurrentMentalState);
            this.Controls.Add(this.BallTrackImage);
            this.Controls.Add(this.pictureBox2);
            this.Name = "GameWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BallImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallTrackImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label CurrentMentalState;
        private System.Windows.Forms.PictureBox BallImage;
        public System.Windows.Forms.PictureBox BallTrackImage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private TransparentControl transparentControl1;
        private TransparentControl transparentControl2;
    }
}

