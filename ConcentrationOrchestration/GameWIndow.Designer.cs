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
            this.BallImage = new System.Windows.Forms.PictureBox();
            this.BallTrackImage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.transparentControl1 = new ConcentrationOrchestration.TransparentControl();
            this.transparentControl2 = new ConcentrationOrchestration.TransparentControl();
            this.PerformanceIndicatorTrack = new System.Windows.Forms.PictureBox();
            this.PerformanceMeasure = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BallImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallTrackImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceIndicatorTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceMeasure)).BeginInit();
            this.SuspendLayout();
            // 
            // BallImage
            // 
            this.BallImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BallImage.BackColor = System.Drawing.Color.Transparent;
            this.BallImage.Image = ((System.Drawing.Image)(resources.GetObject("BallImage.Image")));
            this.BallImage.InitialImage = null;
            this.BallImage.Location = new System.Drawing.Point(437, 437);
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
            // PerformanceIndicatorTrack
            // 
            this.PerformanceIndicatorTrack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PerformanceIndicatorTrack.Image = ((System.Drawing.Image)(resources.GetObject("PerformanceIndicatorTrack.Image")));
            this.PerformanceIndicatorTrack.Location = new System.Drawing.Point(746, 28);
            this.PerformanceIndicatorTrack.Name = "PerformanceIndicatorTrack";
            this.PerformanceIndicatorTrack.Size = new System.Drawing.Size(40, 137);
            this.PerformanceIndicatorTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PerformanceIndicatorTrack.TabIndex = 12;
            this.PerformanceIndicatorTrack.TabStop = false;
            // 
            // PerformanceMeasure
            // 
            this.PerformanceMeasure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PerformanceMeasure.BackColor = System.Drawing.Color.Transparent;
            this.PerformanceMeasure.Image = ((System.Drawing.Image)(resources.GetObject("PerformanceMeasure.Image")));
            this.PerformanceMeasure.InitialImage = null;
            this.PerformanceMeasure.Location = new System.Drawing.Point(744, 155);
            this.PerformanceMeasure.Name = "PerformanceMeasure";
            this.PerformanceMeasure.Size = new System.Drawing.Size(42, 10);
            this.PerformanceMeasure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PerformanceMeasure.TabIndex = 13;
            this.PerformanceMeasure.TabStop = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 459);
            this.Controls.Add(this.PerformanceMeasure);
            this.Controls.Add(this.PerformanceIndicatorTrack);
            this.Controls.Add(this.transparentControl2);
            this.Controls.Add(this.transparentControl1);
            this.Controls.Add(this.BallImage);
            this.Controls.Add(this.BallTrackImage);
            this.Controls.Add(this.pictureBox2);
            this.Name = "GameWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BallImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallTrackImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceIndicatorTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceMeasure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox BallImage;
        public System.Windows.Forms.PictureBox BallTrackImage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private TransparentControl transparentControl1;
        private TransparentControl transparentControl2;
        public System.Windows.Forms.PictureBox PerformanceIndicatorTrack;
        private System.Windows.Forms.PictureBox PerformanceMeasure;
    }
}

