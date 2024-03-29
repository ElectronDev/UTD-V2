﻿
namespace TimeThing
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OffsetTrackBar = new System.Windows.Forms.TrackBar();
            this.LocalTrackBar = new System.Windows.Forms.TrackBar();
            this.LBTZ = new System.Windows.Forms.Label();
            this.OffsetTimeDisplay = new System.Windows.Forms.Label();
            this.Twentyfourmodecheckbox = new System.Windows.Forms.CheckBox();
            this.LocalTimeDisplay = new System.Windows.Forms.Label();
            this.UnixLabel = new System.Windows.Forms.Label();
            this.CurrentTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OBTZ = new System.Windows.Forms.Label();
            this.LTZD = new System.Windows.Forms.Label();
            this.OTZD = new System.Windows.Forms.Label();
            this.BaseAddBtn = new System.Windows.Forms.Button();
            this.OffsetAddBtn = new System.Windows.Forms.Button();
            this.BaseSubBtn = new System.Windows.Forms.Button();
            this.OffsetSubBtn = new System.Windows.Forms.Button();
            this.BaseDisplayText = new System.Windows.Forms.Label();
            this.OffsetDisplayText = new System.Windows.Forms.Label();
            this.WidgetOpen = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CustomiseBtn = new System.Windows.Forms.Button();
            this.CopyUnixBtn = new System.Windows.Forms.Button();
            this.OffsetPicker = new System.Windows.Forms.DateTimePicker();
            this.BasePicker = new System.Windows.Forms.DateTimePicker();
            this.Minimize = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OffsetTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // OffsetTrackBar
            // 
            this.OffsetTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OffsetTrackBar.Enabled = false;
            this.OffsetTrackBar.LargeChange = 7200;
            this.OffsetTrackBar.Location = new System.Drawing.Point(420, 530);
            this.OffsetTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OffsetTrackBar.Maximum = 86399;
            this.OffsetTrackBar.Name = "OffsetTrackBar";
            this.OffsetTrackBar.Size = new System.Drawing.Size(1370, 69);
            this.OffsetTrackBar.SmallChange = 3600;
            this.OffsetTrackBar.TabIndex = 9;
            this.OffsetTrackBar.Value = 1;
            this.OffsetTrackBar.MouseCaptureChanged += new System.EventHandler(this.OffsetTrackBar_MouseCaptureChanged);
            // 
            // LocalTrackBar
            // 
            this.LocalTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocalTrackBar.Enabled = false;
            this.LocalTrackBar.LargeChange = 7200;
            this.LocalTrackBar.Location = new System.Drawing.Point(411, 195);
            this.LocalTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LocalTrackBar.Maximum = 86399;
            this.LocalTrackBar.Name = "LocalTrackBar";
            this.LocalTrackBar.Size = new System.Drawing.Size(1381, 69);
            this.LocalTrackBar.SmallChange = 3600;
            this.LocalTrackBar.TabIndex = 8;
            this.LocalTrackBar.Value = 1;
            this.LocalTrackBar.MouseCaptureChanged += new System.EventHandler(this.LocalTrackBar_MouseCaptureChanged);
            // 
            // LBTZ
            // 
            this.LBTZ.AutoSize = true;
            this.LBTZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.LBTZ.Font = new System.Drawing.Font("Permanent Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBTZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.LBTZ.Location = new System.Drawing.Point(20, 310);
            this.LBTZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBTZ.Name = "LBTZ";
            this.LBTZ.Size = new System.Drawing.Size(236, 35);
            this.LBTZ.TabIndex = 3;
            this.LBTZ.Text = "Base Timezone: 00";
            // 
            // OffsetTimeDisplay
            // 
            this.OffsetTimeDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OffsetTimeDisplay.AutoSize = true;
            this.OffsetTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OffsetTimeDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(174)))), ((int)(((byte)(173)))));
            this.OffsetTimeDisplay.Location = new System.Drawing.Point(423, 463);
            this.OffsetTimeDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OffsetTimeDisplay.Name = "OffsetTimeDisplay";
            this.OffsetTimeDisplay.Size = new System.Drawing.Size(145, 55);
            this.OffsetTimeDisplay.TabIndex = 5;
            this.OffsetTimeDisplay.Text = "00:00";
            // 
            // Twentyfourmodecheckbox
            // 
            this.Twentyfourmodecheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Twentyfourmodecheckbox.AutoSize = true;
            this.Twentyfourmodecheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.Twentyfourmodecheckbox.Font = new System.Drawing.Font("Shadows Into Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Twentyfourmodecheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.Twentyfourmodecheckbox.Location = new System.Drawing.Point(133, 637);
            this.Twentyfourmodecheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Twentyfourmodecheckbox.Name = "Twentyfourmodecheckbox";
            this.Twentyfourmodecheckbox.Size = new System.Drawing.Size(128, 42);
            this.Twentyfourmodecheckbox.TabIndex = 5;
            this.Twentyfourmodecheckbox.Text = "24h mode";
            this.Twentyfourmodecheckbox.UseVisualStyleBackColor = false;
            this.Twentyfourmodecheckbox.CheckedChanged += new System.EventHandler(this.Twentyfourmode_CheckedChanged);
            // 
            // LocalTimeDisplay
            // 
            this.LocalTimeDisplay.AutoSize = true;
            this.LocalTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocalTimeDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(174)))), ((int)(((byte)(173)))));
            this.LocalTimeDisplay.Location = new System.Drawing.Point(423, 127);
            this.LocalTimeDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LocalTimeDisplay.Name = "LocalTimeDisplay";
            this.LocalTimeDisplay.Size = new System.Drawing.Size(145, 55);
            this.LocalTimeDisplay.TabIndex = 7;
            this.LocalTimeDisplay.Text = "00:00";
            // 
            // UnixLabel
            // 
            this.UnixLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UnixLabel.AutoSize = true;
            this.UnixLabel.Font = new System.Drawing.Font("Rancho", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnixLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(174)))), ((int)(((byte)(173)))));
            this.UnixLabel.Location = new System.Drawing.Point(420, 703);
            this.UnixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnixLabel.Name = "UnixLabel";
            this.UnixLabel.Size = new System.Drawing.Size(118, 53);
            this.UnixLabel.TabIndex = 8;
            this.UnixLabel.Text = "Unix: {}";
            // 
            // CurrentTimeCheckBox
            // 
            this.CurrentTimeCheckBox.AutoSize = true;
            this.CurrentTimeCheckBox.Checked = true;
            this.CurrentTimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CurrentTimeCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(174)))), ((int)(((byte)(173)))));
            this.CurrentTimeCheckBox.Location = new System.Drawing.Point(420, 11);
            this.CurrentTimeCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrentTimeCheckBox.Name = "CurrentTimeCheckBox";
            this.CurrentTimeCheckBox.Size = new System.Drawing.Size(147, 29);
            this.CurrentTimeCheckBox.TabIndex = 0;
            this.CurrentTimeCheckBox.Text = "Current Times";
            this.CurrentTimeCheckBox.UseVisualStyleBackColor = true;
            this.CurrentTimeCheckBox.CheckedChanged += new System.EventHandler(this.CurrentTime_CheckedChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Font = new System.Drawing.Font("Shadows Into Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Location = new System.Drawing.Point(1535, 703);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(125, 53);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Visible = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(402, 767);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.pictureBox1.Image = global::TimeThing.Properties.Resources.image00000;
            this.pictureBox1.Location = new System.Drawing.Point(133, 688);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(53, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Permanent Marker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label3.Location = new System.Drawing.Point(187, 703);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "©️ElectronDev 2022";
            this.label3.Click += new System.EventHandler(this.Copyright_Click);
            // 
            // OBTZ
            // 
            this.OBTZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OBTZ.AutoSize = true;
            this.OBTZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.OBTZ.Font = new System.Drawing.Font("Permanent Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OBTZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.OBTZ.Location = new System.Drawing.Point(17, 570);
            this.OBTZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OBTZ.Name = "OBTZ";
            this.OBTZ.Size = new System.Drawing.Size(258, 35);
            this.OBTZ.TabIndex = 16;
            this.OBTZ.Text = "Offset Timezone: 00";
            // 
            // LTZD
            // 
            this.LTZD.AutoSize = true;
            this.LTZD.Font = new System.Drawing.Font("Annie Use Your Telescope", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LTZD.ForeColor = System.Drawing.Color.Silver;
            this.LTZD.Location = new System.Drawing.Point(423, 275);
            this.LTZD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTZD.Name = "LTZD";
            this.LTZD.Size = new System.Drawing.Size(85, 46);
            this.LTZD.TabIndex = 17;
            this.LTZD.Text = "LTZD";
            // 
            // OTZD
            // 
            this.OTZD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OTZD.AutoSize = true;
            this.OTZD.Font = new System.Drawing.Font("Annie Use Your Telescope", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OTZD.ForeColor = System.Drawing.Color.Silver;
            this.OTZD.Location = new System.Drawing.Point(423, 610);
            this.OTZD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OTZD.Name = "OTZD";
            this.OTZD.Size = new System.Drawing.Size(84, 46);
            this.OTZD.TabIndex = 18;
            this.OTZD.Text = "OTZD";
            // 
            // BaseAddBtn
            // 
            this.BaseAddBtn.Font = new System.Drawing.Font("Shadows Into Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BaseAddBtn.Location = new System.Drawing.Point(20, 264);
            this.BaseAddBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BaseAddBtn.Name = "BaseAddBtn";
            this.BaseAddBtn.Size = new System.Drawing.Size(90, 41);
            this.BaseAddBtn.TabIndex = 1;
            this.BaseAddBtn.Text = "Add";
            this.BaseAddBtn.UseVisualStyleBackColor = true;
            this.BaseAddBtn.Click += new System.EventHandler(this.BaseAddBtn_Click);
            // 
            // OffsetAddBtn
            // 
            this.OffsetAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OffsetAddBtn.Font = new System.Drawing.Font("Shadows Into Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OffsetAddBtn.Location = new System.Drawing.Point(17, 524);
            this.OffsetAddBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OffsetAddBtn.Name = "OffsetAddBtn";
            this.OffsetAddBtn.Size = new System.Drawing.Size(90, 41);
            this.OffsetAddBtn.TabIndex = 3;
            this.OffsetAddBtn.Text = "Add";
            this.OffsetAddBtn.UseVisualStyleBackColor = true;
            this.OffsetAddBtn.Click += new System.EventHandler(this.OffsetAddBtn_Click);
            // 
            // BaseSubBtn
            // 
            this.BaseSubBtn.Font = new System.Drawing.Font("Shadows Into Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BaseSubBtn.Location = new System.Drawing.Point(118, 264);
            this.BaseSubBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BaseSubBtn.Name = "BaseSubBtn";
            this.BaseSubBtn.Size = new System.Drawing.Size(115, 41);
            this.BaseSubBtn.TabIndex = 2;
            this.BaseSubBtn.Text = "Subtract";
            this.BaseSubBtn.UseVisualStyleBackColor = true;
            this.BaseSubBtn.Click += new System.EventHandler(this.BaseSubBtn_Click);
            // 
            // OffsetSubBtn
            // 
            this.OffsetSubBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OffsetSubBtn.Font = new System.Drawing.Font("Shadows Into Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OffsetSubBtn.Location = new System.Drawing.Point(115, 524);
            this.OffsetSubBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OffsetSubBtn.Name = "OffsetSubBtn";
            this.OffsetSubBtn.Size = new System.Drawing.Size(115, 41);
            this.OffsetSubBtn.TabIndex = 4;
            this.OffsetSubBtn.Text = "Subtract";
            this.OffsetSubBtn.UseVisualStyleBackColor = true;
            this.OffsetSubBtn.Click += new System.EventHandler(this.OffsetSubBtn_Click);
            // 
            // BaseDisplayText
            // 
            this.BaseDisplayText.AutoSize = true;
            this.BaseDisplayText.Font = new System.Drawing.Font("Shadows Into Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BaseDisplayText.ForeColor = System.Drawing.Color.Silver;
            this.BaseDisplayText.Location = new System.Drawing.Point(426, 45);
            this.BaseDisplayText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BaseDisplayText.Name = "BaseDisplayText";
            this.BaseDisplayText.Size = new System.Drawing.Size(261, 77);
            this.BaseDisplayText.TabIndex = 23;
            this.BaseDisplayText.Text = "Base Display:";
            // 
            // OffsetDisplayText
            // 
            this.OffsetDisplayText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OffsetDisplayText.AutoSize = true;
            this.OffsetDisplayText.Font = new System.Drawing.Font("Shadows Into Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OffsetDisplayText.ForeColor = System.Drawing.Color.Silver;
            this.OffsetDisplayText.Location = new System.Drawing.Point(423, 386);
            this.OffsetDisplayText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OffsetDisplayText.Name = "OffsetDisplayText";
            this.OffsetDisplayText.Size = new System.Drawing.Size(282, 77);
            this.OffsetDisplayText.TabIndex = 24;
            this.OffsetDisplayText.Text = "Offset Display:";
            // 
            // WidgetOpen
            // 
            this.WidgetOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WidgetOpen.Font = new System.Drawing.Font("Shadows Into Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WidgetOpen.Location = new System.Drawing.Point(17, 628);
            this.WidgetOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WidgetOpen.Name = "WidgetOpen";
            this.WidgetOpen.Size = new System.Drawing.Size(107, 70);
            this.WidgetOpen.TabIndex = 6;
            this.WidgetOpen.Text = "Swap to\r\nWidget";
            this.WidgetOpen.UseVisualStyleBackColor = true;
            this.WidgetOpen.Click += new System.EventHandler(this.WidgetOpen_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::TimeThing.Properties.Resources.UTD_logo;
            this.pictureBox2.Location = new System.Drawing.Point(20, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.ProgramName_Click);
            // 
            // CustomiseBtn
            // 
            this.CustomiseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomiseBtn.Font = new System.Drawing.Font("Shadows Into Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomiseBtn.Location = new System.Drawing.Point(17, 708);
            this.CustomiseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomiseBtn.Name = "CustomiseBtn";
            this.CustomiseBtn.Size = new System.Drawing.Size(107, 38);
            this.CustomiseBtn.TabIndex = 27;
            this.CustomiseBtn.Text = "Customise";
            this.CustomiseBtn.UseVisualStyleBackColor = true;
            this.CustomiseBtn.Click += new System.EventHandler(this.CustomiseBtn_Click);
            // 
            // CopyUnixBtn
            // 
            this.CopyUnixBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyUnixBtn.Font = new System.Drawing.Font("Shadows Into Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CopyUnixBtn.Location = new System.Drawing.Point(1668, 702);
            this.CopyUnixBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CopyUnixBtn.Name = "CopyUnixBtn";
            this.CopyUnixBtn.Size = new System.Drawing.Size(125, 53);
            this.CopyUnixBtn.TabIndex = 28;
            this.CopyUnixBtn.Text = "Copy Unix";
            this.CopyUnixBtn.UseVisualStyleBackColor = true;
            this.CopyUnixBtn.Click += new System.EventHandler(this.CopyUnix_Click);
            // 
            // OffsetPicker
            // 
            this.OffsetPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OffsetPicker.CalendarFont = new System.Drawing.Font("Permanent Marker", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OffsetPicker.CustomFormat = "dd MMMM yyyy  |  hh:mm:ss";
            this.OffsetPicker.Font = new System.Drawing.Font("Cambria Math", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OffsetPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OffsetPicker.Location = new System.Drawing.Point(1361, 482);
            this.OffsetPicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OffsetPicker.Name = "OffsetPicker";
            this.OffsetPicker.Size = new System.Drawing.Size(427, 33);
            this.OffsetPicker.TabIndex = 29;
            this.OffsetPicker.Visible = false;
            this.OffsetPicker.ValueChanged += new System.EventHandler(this.OffsetPicker_ValueChanged);
            // 
            // BasePicker
            // 
            this.BasePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BasePicker.CalendarFont = new System.Drawing.Font("Permanent Marker", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BasePicker.CustomFormat = "dd MMMM yyyy  |  hh:mm:ss";
            this.BasePicker.Font = new System.Drawing.Font("Cambria Math", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BasePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BasePicker.Location = new System.Drawing.Point(1361, 147);
            this.BasePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BasePicker.Name = "BasePicker";
            this.BasePicker.Size = new System.Drawing.Size(427, 33);
            this.BasePicker.TabIndex = 30;
            this.BasePicker.Visible = false;
            this.BasePicker.ValueChanged += new System.EventHandler(this.BasePicker_ValueChanged);
            // 
            // Minimize
            // 
            this.Minimize.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Minimize.BalloonTipText = "UTD has been Minimized to your system tray!\r\nClick the icon or this balloon tip t" +
    "o reopen it";
            this.Minimize.BalloonTipTitle = "Universal Time Display";
            this.Minimize.Icon = ((System.Drawing.Icon)(resources.GetObject("Minimize.Icon")));
            this.Minimize.Text = "UTD\r\nClick me to reopen the main window!";
            this.Minimize.BalloonTipClicked += new System.EventHandler(this.Minimize_BalloonTipClicked);
            this.Minimize.Click += new System.EventHandler(this.Minimize_BalloonTipClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1810, 767);
            this.Controls.Add(this.BasePicker);
            this.Controls.Add(this.OffsetPicker);
            this.Controls.Add(this.CopyUnixBtn);
            this.Controls.Add(this.CustomiseBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.WidgetOpen);
            this.Controls.Add(this.OffsetDisplayText);
            this.Controls.Add(this.BaseDisplayText);
            this.Controls.Add(this.OffsetSubBtn);
            this.Controls.Add(this.BaseSubBtn);
            this.Controls.Add(this.OffsetAddBtn);
            this.Controls.Add(this.BaseAddBtn);
            this.Controls.Add(this.OTZD);
            this.Controls.Add(this.LTZD);
            this.Controls.Add(this.OBTZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CurrentTimeCheckBox);
            this.Controls.Add(this.UnixLabel);
            this.Controls.Add(this.LocalTimeDisplay);
            this.Controls.Add(this.Twentyfourmodecheckbox);
            this.Controls.Add(this.OffsetTimeDisplay);
            this.Controls.Add(this.LBTZ);
            this.Controls.Add(this.LocalTrackBar);
            this.Controls.Add(this.OffsetTrackBar);
            this.Controls.Add(this.splitter1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1998, 1009);
            this.MinimumSize = new System.Drawing.Size(1526, 713);
            this.Name = "Form1";
            this.Text = "Universal Time Display";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.OffsetTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label UnixLabel;
        public System.Windows.Forms.Label OffsetTimeDisplay;
        public System.Windows.Forms.Label LocalTimeDisplay;
        public System.Windows.Forms.TrackBar LocalTrackBar;
        public System.Windows.Forms.TrackBar OffsetTrackBar;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button BaseAddBtn;
        private System.Windows.Forms.Button OffsetAddBtn;
        private System.Windows.Forms.Button BaseSubBtn;
        private System.Windows.Forms.Button OffsetSubBtn;
        private System.Windows.Forms.Button WidgetOpen;
        public System.Windows.Forms.CheckBox Twentyfourmodecheckbox;
        private System.Windows.Forms.Button CustomiseBtn;
        public System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.CheckBox CurrentTimeCheckBox;
        public System.Windows.Forms.Label LTZD;
        public System.Windows.Forms.Label OTZD;
        public System.Windows.Forms.Label BaseDisplayText;
        public System.Windows.Forms.Label OffsetDisplayText;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label LBTZ;
        public System.Windows.Forms.Label OBTZ;
        private System.Windows.Forms.Button CopyUnixBtn;
        public System.Windows.Forms.DateTimePicker OffsetPicker;
        public System.Windows.Forms.DateTimePicker BasePicker;
        public System.Windows.Forms.NotifyIcon Minimize;
    }
}

