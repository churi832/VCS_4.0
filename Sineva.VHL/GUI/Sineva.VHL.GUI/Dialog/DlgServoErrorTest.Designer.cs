
namespace Sineva.VHL.GUI
{
    partial class DlgServoErrorTest
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
            this.ucServoErrorTest1 = new Sineva.VHL.Device.Design.ucServoErrorTest();
            this.SuspendLayout();
            // 
            // ucServoErrorTest1
            // 
            this.ucServoErrorTest1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.ucServoErrorTest1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucServoErrorTest1.Location = new System.Drawing.Point(0, 0);
            this.ucServoErrorTest1.Name = "ucServoErrorTest1";
            this.ucServoErrorTest1.Size = new System.Drawing.Size(582, 488);
            this.ucServoErrorTest1.TabIndex = 0;
            // 
            // DlgServoErrorTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 488);
            this.Controls.Add(this.ucServoErrorTest1);
            this.Name = "DlgServoErrorTest";
            this.Text = "DlgServoErrorTest";
            this.ResumeLayout(false);

        }

        #endregion

        private Device.Design.ucServoErrorTest ucServoErrorTest1;
    }
}