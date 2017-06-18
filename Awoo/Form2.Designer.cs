namespace Awoo
{
    partial class Awoo
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
            this.label1 = new System.Windows.Forms.Label();
            this.AwooText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Awoooooooooo!";
            // 
            // AwooText
            // 
            this.AwooText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AwooText.Location = new System.Drawing.Point(33, 92);
            this.AwooText.Name = "AwooText";
            this.AwooText.Size = new System.Drawing.Size(212, 64);
            this.AwooText.TabIndex = 1;
            this.AwooText.Text = "\\noooooooooooooooooo...";
            // 
            // Awoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.AwooText);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 500);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Awoo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Awoo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Awoo_FormClosing);
            this.Load += new System.EventHandler(this.Awoo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AwooText;
    }
}