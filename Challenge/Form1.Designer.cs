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
            this.clickMe = new System.Windows.Forms.Button();
            this.textHere = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickMe
            // 
            this.clickMe.Location = new System.Drawing.Point(340, 217);
            this.clickMe.Name = "clickMe";
            this.clickMe.Size = new System.Drawing.Size(75, 23);
            this.clickMe.TabIndex = 0;
            this.clickMe.Text = "Click Me!";
            this.clickMe.UseVisualStyleBackColor = true;
            this.clickMe.Click += new System.EventHandler(this.clickMe_Click);
            // 
            // textHere
            // 
            this.textHere.AutoSize = true;
            this.textHere.Location = new System.Drawing.Point(456, 217);
            this.textHere.Name = "textHere";
            this.textHere.Size = new System.Drawing.Size(81, 13);
            this.textHere.TabIndex = 1;
            this.textHere.Text = "Text goes here!";
            this.textHere.Click += new System.EventHandler(this.textHere_Click);
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectName.Location = new System.Drawing.Point(225, 34);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(502, 39);
            this.projectName.TabIndex = 3;
            this.projectName.Text = "PROJECT NAME GOES HERE";
            this.projectName.Click += new System.EventHandler(this.textHere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.textHere);
            this.Controls.Add(this.clickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickMe;
        private System.Windows.Forms.Label textHere;
        private System.Windows.Forms.Label projectName;
    }
}

