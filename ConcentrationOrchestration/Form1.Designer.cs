namespace ConcentrationOrchestration
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.StartTrainNeutralButton = new System.Windows.Forms.Button();
            this.CurrentMentalState = new System.Windows.Forms.Label();
            this.StartTrainFrownButton = new System.Windows.Forms.Button();
            this.StartTrainSmileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Use Trained Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartTrainNeutralButton
            // 
            this.StartTrainNeutralButton.Location = new System.Drawing.Point(554, 84);
            this.StartTrainNeutralButton.Name = "StartTrainNeutralButton";
            this.StartTrainNeutralButton.Size = new System.Drawing.Size(148, 23);
            this.StartTrainNeutralButton.TabIndex = 1;
            this.StartTrainNeutralButton.Text = "Start Training Neutral";
            this.StartTrainNeutralButton.UseVisualStyleBackColor = true;
            this.StartTrainNeutralButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // CurrentMentalState
            // 
            this.CurrentMentalState.AutoSize = true;
            this.CurrentMentalState.Location = new System.Drawing.Point(363, 106);
            this.CurrentMentalState.Name = "CurrentMentalState";
            this.CurrentMentalState.Size = new System.Drawing.Size(35, 13);
            this.CurrentMentalState.TabIndex = 2;
            this.CurrentMentalState.Text = "label1";
            // 
            // StartTrainFrownButton
            // 
            this.StartTrainFrownButton.Location = new System.Drawing.Point(554, 113);
            this.StartTrainFrownButton.Name = "StartTrainFrownButton";
            this.StartTrainFrownButton.Size = new System.Drawing.Size(148, 23);
            this.StartTrainFrownButton.TabIndex = 3;
            this.StartTrainFrownButton.Text = "Start Training Frown";
            this.StartTrainFrownButton.UseVisualStyleBackColor = true;
            this.StartTrainFrownButton.Click += new System.EventHandler(this.StartTrainFrownButton_Click);
            // 
            // StartTrainSmileButton
            // 
            this.StartTrainSmileButton.Location = new System.Drawing.Point(554, 142);
            this.StartTrainSmileButton.Name = "StartTrainSmileButton";
            this.StartTrainSmileButton.Size = new System.Drawing.Size(148, 23);
            this.StartTrainSmileButton.TabIndex = 4;
            this.StartTrainSmileButton.Text = "Start Training Smile";
            this.StartTrainSmileButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 583);
            this.Controls.Add(this.StartTrainSmileButton);
            this.Controls.Add(this.StartTrainFrownButton);
            this.Controls.Add(this.CurrentMentalState);
            this.Controls.Add(this.StartTrainNeutralButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StartTrainNeutralButton;
        public System.Windows.Forms.Label CurrentMentalState;
        private System.Windows.Forms.Button StartTrainFrownButton;
        private System.Windows.Forms.Button StartTrainSmileButton;
    }
}

