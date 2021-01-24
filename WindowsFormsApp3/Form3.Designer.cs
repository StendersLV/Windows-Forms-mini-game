namespace WindowsFormsApp3
{
    partial class Form3
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
            this.Exit = new System.Windows.Forms.Button();
            this.START = new System.Windows.Forms.Button();
            this.DONE = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.Label();
            this.number1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(3, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(140, 43);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(12, 303);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(450, 50);
            this.START.TabIndex = 1;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // DONE
            // 
            this.DONE.Enabled = false;
            this.DONE.Location = new System.Drawing.Point(12, 247);
            this.DONE.Name = "DONE";
            this.DONE.Size = new System.Drawing.Size(450, 50);
            this.DONE.TabIndex = 2;
            this.DONE.Text = "DONE";
            this.DONE.UseVisualStyleBackColor = true;
            this.DONE.Click += new System.EventHandler(this.DONE_Click);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(437, 9);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(36, 37);
            this.timer.TabIndex = 3;
            this.timer.Text = "0";
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(121, 109);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(36, 37);
            this.plus.TabIndex = 5;
            this.plus.Text = "+";
            // 
            // number2
            // 
            this.number2.AutoSize = true;
            this.number2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2.Location = new System.Drawing.Point(172, 110);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(36, 37);
            this.number2.TabIndex = 6;
            this.number2.Text = "0";
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1.Location = new System.Drawing.Point(66, 110);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(36, 37);
            this.number1.TabIndex = 7;
            this.number1.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "TIME:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.DONE);
            this.Controls.Add(this.START);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button DONE;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label number2;
        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}