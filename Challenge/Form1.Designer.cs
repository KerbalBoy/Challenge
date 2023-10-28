namespace Challenge
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
            this.projectName = new System.Windows.Forms.Label();
            this.nourhanPage = new System.Windows.Forms.Button();
            this.misbahPage = new System.Windows.Forms.Button();
            this.irishaPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectName.Location = new System.Drawing.Point(160, 40);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(545, 39);
            this.projectName.TabIndex = 3;
            this.projectName.Text = "PROJECT NAME WILL GO HERE";
            // 
            // nourhanPage
            // 
            this.nourhanPage.Location = new System.Drawing.Point(144, 286);
            this.nourhanPage.Name = "nourhanPage";
            this.nourhanPage.Size = new System.Drawing.Size(135, 65);
            this.nourhanPage.TabIndex = 4;
            this.nourhanPage.Text = "Click me to go to Nourhan\'s page";
            this.nourhanPage.UseVisualStyleBackColor = true;
            this.nourhanPage.Click += new System.EventHandler(this.nourhanPage_Click);
            // 
            // misbahPage
            // 
            this.misbahPage.Location = new System.Drawing.Point(352, 286);
            this.misbahPage.Name = "misbahPage";
            this.misbahPage.Size = new System.Drawing.Size(135, 65);
            this.misbahPage.TabIndex = 5;
            this.misbahPage.Text = "Click me to go to Misbah\'s page";
            this.misbahPage.UseVisualStyleBackColor = true;
            this.misbahPage.Click += new System.EventHandler(this.misbahPage_Click);
            // 
            // irishaPage
            // 
            this.irishaPage.Location = new System.Drawing.Point(570, 286);
            this.irishaPage.Name = "irishaPage";
            this.irishaPage.Size = new System.Drawing.Size(135, 65);
            this.irishaPage.TabIndex = 6;
            this.irishaPage.Text = "Click me to go to Irisha\'s page";
            this.irishaPage.UseVisualStyleBackColor = true;
            this.irishaPage.Click += new System.EventHandler(this.irishaPage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.irishaPage);
            this.Controls.Add(this.misbahPage);
            this.Controls.Add(this.nourhanPage);
            this.Controls.Add(this.projectName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.Button nourhanPage;
        private System.Windows.Forms.Button misbahPage;
        private System.Windows.Forms.Button irishaPage;
    }
}

