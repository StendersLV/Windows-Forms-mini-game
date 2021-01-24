namespace WindowsFormsApp3
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
            this.START = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(125, 91);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(214, 44);
            this.START.TabIndex = 0;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(125, 158);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(214, 44);
            this.EXIT.TabIndex = 1;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 365);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.START);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button EXIT;
    }
}

