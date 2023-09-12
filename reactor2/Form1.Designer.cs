namespace reactor2
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
            this.reactor2Label = new System.Windows.Forms.Label();
            this.reactor1Label = new System.Windows.Forms.Label();
            this.reactor2Image = new System.Windows.Forms.Label();
            this.reactor1Image = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.reactorStart = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactorStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reactor2Label
            // 
            this.reactor2Label.AutoSize = true;
            this.reactor2Label.Location = new System.Drawing.Point(506, 175);
            this.reactor2Label.Name = "reactor2Label";
            this.reactor2Label.Size = new System.Drawing.Size(65, 16);
            this.reactor2Label.TabIndex = 17;
            this.reactor2Label.Text = "Reactor 2";
            // 
            // reactor1Label
            // 
            this.reactor1Label.AutoSize = true;
            this.reactor1Label.Location = new System.Drawing.Point(223, 175);
            this.reactor1Label.Name = "reactor1Label";
            this.reactor1Label.Size = new System.Drawing.Size(65, 16);
            this.reactor1Label.TabIndex = 16;
            this.reactor1Label.Text = "Reactor 1";
            // 
            // reactor2Image
            // 
            this.reactor2Image.BackColor = System.Drawing.Color.LimeGreen;
            this.reactor2Image.Cursor = System.Windows.Forms.Cursors.Cross;
            this.reactor2Image.Location = new System.Drawing.Point(476, 191);
            this.reactor2Image.Name = "reactor2Image";
            this.reactor2Image.Size = new System.Drawing.Size(129, 142);
            this.reactor2Image.TabIndex = 15;
            this.reactor2Image.Click += new System.EventHandler(this.reactor2Image_Click);
            // 
            // reactor1Image
            // 
            this.reactor1Image.BackColor = System.Drawing.Color.LimeGreen;
            this.reactor1Image.Cursor = System.Windows.Forms.Cursors.Cross;
            this.reactor1Image.Location = new System.Drawing.Point(199, 191);
            this.reactor1Image.Name = "reactor1Image";
            this.reactor1Image.Size = new System.Drawing.Size(129, 142);
            this.reactor1Image.TabIndex = 14;
            this.reactor1Image.Click += new System.EventHandler(this.reactor1Image_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.outputLabel.Location = new System.Drawing.Point(160, 351);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(481, 37);
            this.outputLabel.TabIndex = 13;
            this.outputLabel.Text = "Reactor Status: Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reactorStart
            // 
            this.reactorStart.Location = new System.Drawing.Point(363, 255);
            this.reactorStart.Name = "reactorStart";
            this.reactorStart.Size = new System.Drawing.Size(75, 23);
            this.reactorStart.TabIndex = 12;
            this.reactorStart.Text = "Start Reactor";
            this.reactorStart.UseVisualStyleBackColor = true;
            this.reactorStart.Click += new System.EventHandler(this.reactorStart_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLabel.Location = new System.Drawing.Point(195, 60);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(382, 39);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Nuclear Reactor Control";
            // 
            // reactorStop
            // 
            this.reactorStop.FlatAppearance.BorderSize = 0;
            this.reactorStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reactorStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reactorStop.Location = new System.Drawing.Point(363, 284);
            this.reactorStop.Name = "reactorStop";
            this.reactorStop.Size = new System.Drawing.Size(75, 23);
            this.reactorStop.TabIndex = 18;
            this.reactorStop.Text = "Shutdown";
            this.reactorStop.UseVisualStyleBackColor = true;
            this.reactorStop.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reactorStop);
            this.Controls.Add(this.reactor2Label);
            this.Controls.Add(this.reactor1Label);
            this.Controls.Add(this.reactor2Image);
            this.Controls.Add(this.reactor1Image);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.reactorStart);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nuclear Reactor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reactor2Label;
        private System.Windows.Forms.Label reactor1Label;
        private System.Windows.Forms.Label reactor2Image;
        private System.Windows.Forms.Label reactor1Image;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button reactorStart;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button reactorStop;
    }
}

