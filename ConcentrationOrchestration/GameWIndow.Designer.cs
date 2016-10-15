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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BallImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallTrackImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentMentalState
            // 
            this.CurrentMentalState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentMentalState.AutoSize = true;
            this.CurrentMentalState.Location = new System.Drawing.Point(647, 506);
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
            this.BallImage.Location = new System.Drawing.Point(373, 485);
            this.BallImage.Name = "BallImage";
            this.BallImage.Size = new System.Drawing.Size(74, 74);
            this.BallImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BallImage.TabIndex = 6;
            this.BallImage.TabStop = false;
            // 
            // BallTrackImage
            // 
            this.BallTrackImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BallTrackImage.Image = ((System.Drawing.Image)(resources.GetObject("BallTrackImage.Image")));
            this.BallTrackImage.Location = new System.Drawing.Point(317, 8);
            this.BallTrackImage.Name = "BallTrackImage";
            this.BallTrackImage.Size = new System.Drawing.Size(184, 564);
            this.BallTrackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BallTrackImage.TabIndex = 7;
            this.BallTrackImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 583);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BallImage);
            this.Controls.Add(this.CurrentMentalState);
            this.Controls.Add(this.BallTrackImage);
            this.Name = "GameWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BallImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallTrackImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label CurrentMentalState;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BallImage;
        public System.Windows.Forms.PictureBox BallTrackImage;
    }
}

