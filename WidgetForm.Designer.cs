
namespace TimeThing
{
    partial class WidgetFormClass
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WidgetFormClass));
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.BaseDisplayText = new System.Windows.Forms.Label();
            this.LocalTimeDisplay = new System.Windows.Forms.Label();
            this.LocalTrackBar = new System.Windows.Forms.TrackBar();
            this.OffsetDisplayText = new System.Windows.Forms.Label();
            this.OffsetTimeDisplay = new System.Windows.Forms.Label();
            this.OffsetTrackBar = new System.Windows.Forms.TrackBar();
            this.OBTZ = new System.Windows.Forms.Label();
            this.LBTZ = new System.Windows.Forms.Label();
            this.Twentyfourmodecheckbox = new System.Windows.Forms.CheckBox();
            this.Reposition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LocalTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ReturnBtn.Location = new System.Drawing.Point(689, 348);
            this.ReturnBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(80, 42);
            this.ReturnBtn.TabIndex = 2;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = false;
            this.ReturnBtn.Click += new System.EventHandler(this.Return_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(77)))), ((int)(((byte)(104)))));
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 334);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(786, 73);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // BaseDisplayText
            // 
            this.BaseDisplayText.AutoSize = true;
            this.BaseDisplayText.Font = new System.Drawing.Font("Shadows Into Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BaseDisplayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(97)))), ((int)(((byte)(53)))));
            this.BaseDisplayText.Location = new System.Drawing.Point(17, 40);
            this.BaseDisplayText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BaseDisplayText.Name = "BaseDisplayText";
            this.BaseDisplayText.Size = new System.Drawing.Size(193, 57);
            this.BaseDisplayText.TabIndex = 26;
            this.BaseDisplayText.Text = "Base Display:";
            // 
            // LocalTimeDisplay
            // 
            this.LocalTimeDisplay.AutoSize = true;
            this.LocalTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocalTimeDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(141)))), ((int)(((byte)(115)))));
            this.LocalTimeDisplay.Location = new System.Drawing.Point(263, 40);
            this.LocalTimeDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LocalTimeDisplay.Name = "LocalTimeDisplay";
            this.LocalTimeDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LocalTimeDisplay.Size = new System.Drawing.Size(123, 47);
            this.LocalTimeDisplay.TabIndex = 25;
            this.LocalTimeDisplay.Text = "00:00";
            // 
            // LocalTrackBar
            // 
            this.LocalTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocalTrackBar.Enabled = false;
            this.LocalTrackBar.LargeChange = 7200;
            this.LocalTrackBar.Location = new System.Drawing.Point(17, 97);
            this.LocalTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LocalTrackBar.Maximum = 86399;
            this.LocalTrackBar.Name = "LocalTrackBar";
            this.LocalTrackBar.Size = new System.Drawing.Size(751, 69);
            this.LocalTrackBar.SmallChange = 3600;
            this.LocalTrackBar.TabIndex = 24;
            this.LocalTrackBar.Value = 1;
            // 
            // OffsetDisplayText
            // 
            this.OffsetDisplayText.AutoSize = true;
            this.OffsetDisplayText.Font = new System.Drawing.Font("Shadows Into Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OffsetDisplayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(97)))), ((int)(((byte)(53)))));
            this.OffsetDisplayText.Location = new System.Drawing.Point(17, 196);
            this.OffsetDisplayText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OffsetDisplayText.Name = "OffsetDisplayText";
            this.OffsetDisplayText.Size = new System.Drawing.Size(209, 57);
            this.OffsetDisplayText.TabIndex = 29;
            this.OffsetDisplayText.Text = "Offset Display:";
            // 
            // OffsetTimeDisplay
            // 
            this.OffsetTimeDisplay.AutoSize = true;
            this.OffsetTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OffsetTimeDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(141)))), ((int)(((byte)(115)))));
            this.OffsetTimeDisplay.Location = new System.Drawing.Point(263, 197);
            this.OffsetTimeDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OffsetTimeDisplay.Name = "OffsetTimeDisplay";
            this.OffsetTimeDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OffsetTimeDisplay.Size = new System.Drawing.Size(123, 47);
            this.OffsetTimeDisplay.TabIndex = 28;
            this.OffsetTimeDisplay.Text = "00:00";
            // 
            // OffsetTrackBar
            // 
            this.OffsetTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OffsetTrackBar.Enabled = false;
            this.OffsetTrackBar.LargeChange = 7200;
            this.OffsetTrackBar.Location = new System.Drawing.Point(17, 253);
            this.OffsetTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OffsetTrackBar.Maximum = 86399;
            this.OffsetTrackBar.Name = "OffsetTrackBar";
            this.OffsetTrackBar.Size = new System.Drawing.Size(751, 69);
            this.OffsetTrackBar.SmallChange = 3600;
            this.OffsetTrackBar.TabIndex = 27;
            this.OffsetTrackBar.Value = 1;
            // 
            // OBTZ
            // 
            this.OBTZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OBTZ.AutoSize = true;
            this.OBTZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(77)))), ((int)(((byte)(104)))));
            this.OBTZ.Font = new System.Drawing.Font("Permanent Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OBTZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.OBTZ.Location = new System.Drawing.Point(279, 355);
            this.OBTZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OBTZ.Name = "OBTZ";
            this.OBTZ.Size = new System.Drawing.Size(258, 35);
            this.OBTZ.TabIndex = 31;
            this.OBTZ.Text = "Offset Timezone: 00";
            // 
            // LBTZ
            // 
            this.LBTZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LBTZ.AutoSize = true;
            this.LBTZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(77)))), ((int)(((byte)(104)))));
            this.LBTZ.Font = new System.Drawing.Font("Permanent Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBTZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.LBTZ.Location = new System.Drawing.Point(17, 355);
            this.LBTZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBTZ.Name = "LBTZ";
            this.LBTZ.Size = new System.Drawing.Size(236, 35);
            this.LBTZ.TabIndex = 30;
            this.LBTZ.Text = "Base Timezone: 00";
            // 
            // Twentyfourmodecheckbox
            // 
            this.Twentyfourmodecheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Twentyfourmodecheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.Twentyfourmodecheckbox.AutoSize = true;
            this.Twentyfourmodecheckbox.BackColor = System.Drawing.SystemColors.Control;
            this.Twentyfourmodecheckbox.ForeColor = System.Drawing.Color.Black;
            this.Twentyfourmodecheckbox.Location = new System.Drawing.Point(586, 355);
            this.Twentyfourmodecheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Twentyfourmodecheckbox.Name = "Twentyfourmodecheckbox";
            this.Twentyfourmodecheckbox.Size = new System.Drawing.Size(52, 35);
            this.Twentyfourmodecheckbox.TabIndex = 0;
            this.Twentyfourmodecheckbox.Text = "24h";
            this.Twentyfourmodecheckbox.UseVisualStyleBackColor = false;
            this.Twentyfourmodecheckbox.Visible = false;
            this.Twentyfourmodecheckbox.CheckedChanged += new System.EventHandler(this.Twentyfourmodecheckbox_CheckedChanged);
            // 
            // Reposition
            // 
            this.Reposition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Reposition.Location = new System.Drawing.Point(647, 348);
            this.Reposition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Reposition.Name = "Reposition";
            this.Reposition.Size = new System.Drawing.Size(33, 42);
            this.Reposition.TabIndex = 1;
            this.Reposition.Text = "↔️";
            this.Reposition.UseVisualStyleBackColor = true;
            this.Reposition.Visible = false;
            this.Reposition.Click += new System.EventHandler(this.Reposition_Click);
            // 
            // WidgetFormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(186)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(786, 407);
            this.ControlBox = false;
            this.Controls.Add(this.Reposition);
            this.Controls.Add(this.Twentyfourmodecheckbox);
            this.Controls.Add(this.OBTZ);
            this.Controls.Add(this.LBTZ);
            this.Controls.Add(this.OffsetDisplayText);
            this.Controls.Add(this.OffsetTimeDisplay);
            this.Controls.Add(this.OffsetTrackBar);
            this.Controls.Add(this.BaseDisplayText);
            this.Controls.Add(this.LocalTimeDisplay);
            this.Controls.Add(this.LocalTrackBar);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WidgetFormClass";
            this.Opacity = 0.65D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UTD Widget";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WidgetFormClass_FormClosing);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseHover);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.LocalTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button ReturnBtn;
        public System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.Label LocalTimeDisplay;
        public System.Windows.Forms.TrackBar LocalTrackBar;
        public System.Windows.Forms.Label OffsetTimeDisplay;
        public System.Windows.Forms.TrackBar OffsetTrackBar;
        private System.Windows.Forms.CheckBox Twentyfourmodecheckbox;
        private System.Windows.Forms.Button Reposition;
        public System.Windows.Forms.Label BaseDisplayText;
        public System.Windows.Forms.Label OffsetDisplayText;
        public System.Windows.Forms.Label LBTZ;
        public System.Windows.Forms.Label OBTZ;
    }
}

