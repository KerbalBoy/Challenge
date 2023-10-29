namespace Challenge
{
    partial class SimulationGameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.aprLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.houseButton = new System.Windows.Forms.Button();
            this.carButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(38, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "1.5% APR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 82);
            this.label1.TabIndex = 4;
            this.label1.Text = "£500.00";
            // 
            // aprLabel
            // 
            this.aprLabel.AutoSize = true;
            this.aprLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprLabel.Location = new System.Drawing.Point(12, 138);
            this.aprLabel.Name = "aprLabel";
            this.aprLabel.Size = new System.Drawing.Size(82, 37);
            this.aprLabel.TabIndex = 5;
            this.aprLabel.Text = "APR";
            this.aprLabel.Click += new System.EventHandler(this.aprLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Year";
            // 
            // houseButton
            // 
            this.houseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.houseButton.Location = new System.Drawing.Point(280, 406);
            this.houseButton.Name = "houseButton";
            this.houseButton.Size = new System.Drawing.Size(209, 101);
            this.houseButton.TabIndex = 7;
            this.houseButton.Text = "House:\r\n£500,000\r\nDown Payment:\r\n£50,000";
            this.houseButton.UseVisualStyleBackColor = true;
            this.houseButton.Click += new System.EventHandler(this.houseButton_Click);
            // 
            // carButton
            // 
            this.carButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carButton.Location = new System.Drawing.Point(525, 406);
            this.carButton.Name = "carButton";
            this.carButton.Size = new System.Drawing.Size(209, 101);
            this.carButton.TabIndex = 8;
            this.carButton.Text = "Car:\r\n£10,000\r\nDown Payment:\r\n£1,000";
            this.carButton.UseVisualStyleBackColor = true;
            this.carButton.Click += new System.EventHandler(this.carButton_Click);
            // 
            // SimulationGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 529);
            this.Controls.Add(this.carButton);
            this.Controls.Add(this.houseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aprLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "SimulationGameForm";
            this.Text = "SimulationGameForm";
            this.Load += new System.EventHandler(this.SimulationGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aprLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button houseButton;
        private System.Windows.Forms.Button carButton;
    }
}