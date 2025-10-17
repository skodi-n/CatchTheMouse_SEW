namespace CatchTheMouse.GUI
{
    partial class StatisticsForm
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
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.tbxFirst = new System.Windows.Forms.TextBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.tbxLast = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 25;
            this.lstUsers.Location = new System.Drawing.Point(340, 125);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(524, 354);
            this.lstUsers.TabIndex = 0;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(407, 542);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(104, 25);
            this.lblFirst.TabIndex = 1;
            this.lblFirst.Text = "Vorname:";
            this.lblFirst.Click += new System.EventHandler(this.lblFirst_Click);
            // 
            // tbxFirst
            // 
            this.tbxFirst.Location = new System.Drawing.Point(577, 535);
            this.tbxFirst.Name = "tbxFirst";
            this.tbxFirst.Size = new System.Drawing.Size(209, 31);
            this.tbxFirst.TabIndex = 2;
            this.tbxFirst.TextChanged += new System.EventHandler(this.tbxFirst_TextChanged);
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(407, 595);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(127, 25);
            this.lblLast.TabIndex = 3;
            this.lblLast.Text = "Nachname: ";
            // 
            // tbxLast
            // 
            this.tbxLast.Location = new System.Drawing.Point(577, 592);
            this.tbxLast.Name = "tbxLast";
            this.tbxLast.Size = new System.Drawing.Size(209, 31);
            this.tbxLast.TabIndex = 4;
            this.tbxLast.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(577, 681);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(209, 40);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Spiel Starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 779);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbxLast);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.tbxFirst);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lstUsers);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox tbxFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox tbxLast;
        private System.Windows.Forms.Button btnStart;
    }
}