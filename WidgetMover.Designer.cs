
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
            this.BL.Location = new System.Drawing.Point(12, 149);
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
            this.BR.Location = new System.Drawing.Point(172, 149);
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(100, 100);
            this.BR.TabIndex = 3;
            this.BR.Text = "Bottom\r\nRight";
            this.BR.UseVisualStyleBackColor = false;
            this.BR.Click += new System.EventHandler(this.BR_Click);
            // 
            // WidgetMoverClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BR);
            this.Controls.Add(this.TR);
            this.Controls.Add(this.BL);
            this.Controls.Add(this.TL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "WidgetMoverClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WidgetMover";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TL;
        private System.Windows.Forms.Button BL;
        private System.Windows.Forms.Button TR;
        private System.Windows.Forms.Button BR;
    }
}