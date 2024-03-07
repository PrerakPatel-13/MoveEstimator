namespace MoveEstimator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HoursGetter = new System.Windows.Forms.TextBox();
            this.MilesGetter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Estimator = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Estimator);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MilesGetter);
            this.groupBox1.Controls.Add(this.HoursGetter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User_details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours";
            // 
            // HoursGetter
            // 
            this.HoursGetter.Location = new System.Drawing.Point(138, 62);
            this.HoursGetter.Name = "HoursGetter";
            this.HoursGetter.Size = new System.Drawing.Size(115, 20);
            this.HoursGetter.TabIndex = 1;
            // 
            // MilesGetter
            // 
            this.MilesGetter.Location = new System.Drawing.Point(138, 109);
            this.MilesGetter.Name = "MilesGetter";
            this.MilesGetter.Size = new System.Drawing.Size(115, 20);
            this.MilesGetter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Miles";
            // 
            // Estimator
            // 
            this.Estimator.Location = new System.Drawing.Point(138, 182);
            this.Estimator.Name = "Estimator";
            this.Estimator.Size = new System.Drawing.Size(115, 23);
            this.Estimator.TabIndex = 4;
            this.Estimator.Text = "MOVEESTIMATE";
            this.Estimator.UseVisualStyleBackColor = true;
            this.Estimator.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Estimator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MilesGetter;
        private System.Windows.Forms.TextBox HoursGetter;
        private System.Windows.Forms.Label label1;
    }
}

