namespace CatchTheMouse.GUI
{
    partial class CatchTheMouse
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.flwCTM = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flwCTM
            // 
            this.flwCTM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwCTM.Location = new System.Drawing.Point(0, 0);
            this.flwCTM.Name = "flwCTM";
            this.flwCTM.Size = new System.Drawing.Size(944, 909);
            this.flwCTM.TabIndex = 0;
            this.flwCTM.Paint += new System.Windows.Forms.PaintEventHandler(this.flwCTM_Paint);
            // 
            // CatchTheMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 909);
            this.Controls.Add(this.flwCTM);
            this.Name = "CatchTheMouse";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CatchTheMouse_Load);
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.FlowLayoutPanel flwCTM;
    }
}

