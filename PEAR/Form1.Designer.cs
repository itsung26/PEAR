namespace PEAR
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lagStatusIndicatorTextFront = new System.Windows.Forms.Label();
            this.offLabel = new System.Windows.Forms.Label();
            this.keybindSelector = new System.Windows.Forms.TextBox();
            this.clearKeybindButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PEAR.Properties.Resources.pear32;
            this.pictureBox1.Location = new System.Drawing.Point(114, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 60);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lagStatusIndicatorTextFront
            // 
            this.lagStatusIndicatorTextFront.AutoSize = true;
            this.lagStatusIndicatorTextFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagStatusIndicatorTextFront.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lagStatusIndicatorTextFront.Location = new System.Drawing.Point(44, 109);
            this.lagStatusIndicatorTextFront.Name = "lagStatusIndicatorTextFront";
            this.lagStatusIndicatorTextFront.Size = new System.Drawing.Size(144, 32);
            this.lagStatusIndicatorTextFront.TabIndex = 6;
            this.lagStatusIndicatorTextFront.Text = "lag status:";
            // 
            // offLabel
            // 
            this.offLabel.AutoSize = true;
            this.offLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offLabel.ForeColor = System.Drawing.Color.Red;
            this.offLabel.Location = new System.Drawing.Point(183, 111);
            this.offLabel.Name = "offLabel";
            this.offLabel.Size = new System.Drawing.Size(70, 32);
            this.offLabel.TabIndex = 7;
            this.offLabel.Text = "OFF";
            // 
            // keybindSelector
            // 
            this.keybindSelector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.keybindSelector.Location = new System.Drawing.Point(50, 144);
            this.keybindSelector.Name = "keybindSelector";
            this.keybindSelector.ReadOnly = true;
            this.keybindSelector.Size = new System.Drawing.Size(203, 26);
            this.keybindSelector.TabIndex = 8;
            this.keybindSelector.Text = "enter a keybind...";
            // 
            // clearKeybindButton
            // 
            this.clearKeybindButton.Location = new System.Drawing.Point(91, 176);
            this.clearKeybindButton.Name = "clearKeybindButton";
            this.clearKeybindButton.Size = new System.Drawing.Size(114, 35);
            this.clearKeybindButton.TabIndex = 9;
            this.clearKeybindButton.Text = "clear keybind";
            this.clearKeybindButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(296, 373);
            this.Controls.Add(this.clearKeybindButton);
            this.Controls.Add(this.keybindSelector);
            this.Controls.Add(this.offLabel);
            this.Controls.Add(this.lagStatusIndicatorTextFront);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEAR lagswitch";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lagStatusIndicatorTextFront;
        private System.Windows.Forms.Label offLabel;
        private System.Windows.Forms.TextBox keybindSelector;
        private System.Windows.Forms.Button clearKeybindButton;
    }
}

