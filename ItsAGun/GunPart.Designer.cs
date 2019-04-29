namespace ItsAGun
{
    partial class GunPart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GunPart));
            this.trig1 = new System.Windows.Forms.Label();
            this.trig2 = new System.Windows.Forms.Label();
            this.trig3 = new System.Windows.Forms.Label();
            this.trig4 = new System.Windows.Forms.Label();
            this.triggerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trig1
            // 
            this.trig1.AutoSize = true;
            this.trig1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trig1.Location = new System.Drawing.Point(96, -10);
            this.trig1.Name = "trig1";
            this.trig1.Size = new System.Drawing.Size(36, 55);
            this.trig1.TabIndex = 0;
            this.trig1.Text = "|";
            // 
            // trig2
            // 
            this.trig2.AutoSize = true;
            this.trig2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trig2.Location = new System.Drawing.Point(71, -6);
            this.trig2.Name = "trig2";
            this.trig2.Size = new System.Drawing.Size(21, 31);
            this.trig2.TabIndex = 1;
            this.trig2.Text = "|";
            this.trig2.Click += new System.EventHandler(this.trig2_Click);
            // 
            // trig3
            // 
            this.trig3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trig3.Location = new System.Drawing.Point(63, 4);
            this.trig3.Name = "trig3";
            this.trig3.Size = new System.Drawing.Size(16, 31);
            this.trig3.TabIndex = 2;
            this.trig3.Text = "-";
            this.trig3.Click += new System.EventHandler(this.trig3_Click);
            // 
            // trig4
            // 
            this.trig4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trig4.Location = new System.Drawing.Point(-4, 24);
            this.trig4.Name = "trig4";
            this.trig4.Size = new System.Drawing.Size(113, 26);
            this.trig4.TabIndex = 3;
            this.trig4.Text = "-------------";
            // 
            // triggerButton
            // 
            this.triggerButton.BackColor = System.Drawing.Color.Transparent;
            this.triggerButton.Enabled = false;
            this.triggerButton.ForeColor = System.Drawing.Color.Transparent;
            this.triggerButton.Location = new System.Drawing.Point(68, 35);
            this.triggerButton.Name = "triggerButton";
            this.triggerButton.Size = new System.Drawing.Size(51, 10);
            this.triggerButton.TabIndex = 4;
            this.triggerButton.UseVisualStyleBackColor = false;
            this.triggerButton.Visible = false;
            // 
            // GunPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(116, 44);
            this.ControlBox = false;
            this.Controls.Add(this.triggerButton);
            this.Controls.Add(this.trig4);
            this.Controls.Add(this.trig3);
            this.Controls.Add(this.trig2);
            this.Controls.Add(this.trig1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GunPart";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GunPart_FormClosing);
            this.LocationChanged += new System.EventHandler(this.GunPart_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label trig1;
        private System.Windows.Forms.Label trig2;
        private System.Windows.Forms.Label trig3;
        private System.Windows.Forms.Label trig4;
        private System.Windows.Forms.Button triggerButton;
    }
}

