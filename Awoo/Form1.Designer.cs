namespace Awoo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AwooButton = new System.Windows.Forms.Button();
            this.Progbar = new System.Windows.Forms.ProgressBar();
            this.ProgBarText = new System.Windows.Forms.Label();
            this.MsgLabel = new System.Windows.Forms.Label();
            this.spinner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spinner)).BeginInit();
            this.SuspendLayout();
            // 
            // AwooButton
            // 
            this.AwooButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AwooButton.Location = new System.Drawing.Point(12, 12);
            this.AwooButton.Name = "AwooButton";
            this.AwooButton.Size = new System.Drawing.Size(280, 25);
            this.AwooButton.TabIndex = 0;
            this.AwooButton.Text = "Awoo";
            this.AwooButton.UseVisualStyleBackColor = true;
            this.AwooButton.Click += new System.EventHandler(this.AwooButton_Click);
            // 
            // Progbar
            // 
            this.Progbar.Location = new System.Drawing.Point(12, 126);
            this.Progbar.Name = "Progbar";
            this.Progbar.Size = new System.Drawing.Size(280, 23);
            this.Progbar.Step = 25;
            this.Progbar.TabIndex = 1;
            // 
            // ProgBarText
            // 
            this.ProgBarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProgBarText.Location = new System.Drawing.Point(58, 98);
            this.ProgBarText.Name = "ProgBarText";
            this.ProgBarText.Size = new System.Drawing.Size(195, 25);
            this.ProgBarText.TabIndex = 2;
            this.ProgBarText.Text = "Ready";
            this.ProgBarText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MsgLabel
            // 
            this.MsgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MsgLabel.Location = new System.Drawing.Point(84, 40);
            this.MsgLabel.Name = "MsgLabel";
            this.MsgLabel.Size = new System.Drawing.Size(169, 21);
            this.MsgLabel.TabIndex = 3;
            this.MsgLabel.Text = "Click To Start A Howl";
            this.MsgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spinner
            // 
            this.spinner.Image = ((System.Drawing.Image)(resources.GetObject("spinner.Image")));
            this.spinner.Location = new System.Drawing.Point(62, 45);
            this.spinner.Name = "spinner";
            this.spinner.Size = new System.Drawing.Size(16, 16);
            this.spinner.TabIndex = 4;
            this.spinner.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 161);
            this.Controls.Add(this.spinner);
            this.Controls.Add(this.MsgLabel);
            this.Controls.Add(this.ProgBarText);
            this.Controls.Add(this.Progbar);
            this.Controls.Add(this.AwooButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Awoo Tool v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AwooButton;
        private System.Windows.Forms.ProgressBar Progbar;
        private System.Windows.Forms.Label ProgBarText;
        private System.Windows.Forms.Label MsgLabel;
        private System.Windows.Forms.PictureBox spinner;
    }
}

