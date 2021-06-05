
namespace TimeThing
{
    partial class WidgetMoverClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WidgetMoverClass));
            this.TL = new System.Windows.Forms.Button();
            this.BL = new System.Windows.Forms.Button();
            this.TR = new System.Windows.Forms.Button();
            this.BR = new System.Windows.Forms.Button();
            this.FreeButton = new System.Windows.Forms.Button();
            this.FreeMoveLock = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // TL
            // 
            this.TL.BackColor = System.Drawing.SystemColors.Control;
            this.TL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TL.Location = new System.Drawing.Point(12, 12);
            this.TL.Name = "TL";
            this.TL.Size = new System.Drawing.Size(100, 100);
            this.TL.TabIndex = 0;
            this.TL.Text = "Top\r\nLeft\r\n";
            this.TL.UseVisualStyleBackColor = false;
            this.TL.Click += new System.EventHandler(this.TL_Click);
            // 
            // BL
            // 
            this.BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BL.BackColor = System.Drawing.SystemColors.Control;
            this.BL.Location = new System.Drawing.Point(12, 124);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(100, 100);
            this.BL.TabIndex = 1;
            this.BL.Text = "Bottom\r\nLeft\r\n";
            this.BL.UseVisualStyleBackColor = false;
            this.BL.Click += new System.EventHandler(this.BL_Click);
            // 
            // TR
            // 
            this.TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TR.BackColor = System.Drawing.SystemColors.Control;
            this.TR.Location = new System.Drawing.Point(172, 12);
            this.TR.Name = "TR";
            this.TR.Size = new System.Drawing.Size(100, 100);
            this.TR.TabIndex = 2;
            this.TR.Text = "Top\r\nRight";
            this.TR.UseVisualStyleBackColor = false;
            this.TR.Click += new System.EventHandler(this.TR_Click);
            // 
            // BR
            // 
            this.BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BR.BackColor = System.Drawing.SystemColors.Control;
            this.BR.Location = new System.Drawing.Point(172, 124);
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(100, 100);
            this.BR.TabIndex = 3;
            this.BR.Text = "Bottom\r\nRight";
            this.BR.UseVisualStyleBackColor = false;
            this.BR.Click += new System.EventHandler(this.BR_Click);
            // 
            // FreeButton
            // 
            this.FreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FreeButton.Location = new System.Drawing.Point(164, 240);
            this.FreeButton.Name = "FreeButton";
            this.FreeButton.Size = new System.Drawing.Size(108, 25);
            this.FreeButton.TabIndex = 6;
            this.FreeButton.Text = "Free Movement";
            this.FreeButton.UseVisualStyleBackColor = true;
            this.FreeButton.Click += new System.EventHandler(this.FreeButton_Click);
            // 
            // FreeMoveLock
            // 
            this.FreeMoveLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FreeMoveLock.AutoSize = true;
            this.FreeMoveLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(77)))), ((int)(((byte)(104)))));
            this.FreeMoveLock.Enabled = false;
            this.FreeMoveLock.Location = new System.Drawing.Point(15, 244);
            this.FreeMoveLock.Name = "FreeMoveLock";
            this.FreeMoveLock.Size = new System.Drawing.Size(109, 19);
            this.FreeMoveLock.TabIndex = 5;
            this.FreeMoveLock.Text = "Unlock Position";
            this.FreeMoveLock.UseVisualStyleBackColor = false;
            this.FreeMoveLock.CheckedChanged += new System.EventHandler(this.FreeMoveLock_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(77)))), ((int)(((byte)(104)))));
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 230);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(284, 45);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // WidgetMoverClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(186)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(284, 275);
            this.Controls.Add(this.FreeMoveLock);
            this.Controls.Add(this.FreeButton);
            this.Controls.Add(this.BR);
            this.Controls.Add(this.TR);
            this.Controls.Add(this.BL);
            this.Controls.Add(this.TL);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 39);
            this.Name = "WidgetMoverClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WidgetMover";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TL;
        private System.Windows.Forms.Button BL;
        private System.Windows.Forms.Button TR;
        private System.Windows.Forms.Button BR;
        private System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.CheckBox FreeMoveLock;
        public System.Windows.Forms.Button FreeButton;
    }
}