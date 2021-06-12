
namespace TimeThing
{
    partial class CustomiserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomiserForm));
            this.Prim = new System.Windows.Forms.Label();
            this.PrimBtn = new System.Windows.Forms.Button();
            this.SecBtn = new System.Windows.Forms.Button();
            this.TC1Btn = new System.Windows.Forms.Button();
            this.TC2Btn = new System.Windows.Forms.Button();
            this.Sec = new System.Windows.Forms.Label();
            this.TC1 = new System.Windows.Forms.Label();
            this.TC2 = new System.Windows.Forms.Label();
            this.Gen = new System.Windows.Forms.Label();
            this.GenBtn = new System.Windows.Forms.Button();
            this.PrimSelector = new System.Windows.Forms.ColorDialog();
            this.SecSelector = new System.Windows.Forms.ColorDialog();
            this.TC1Selector = new System.Windows.Forms.ColorDialog();
            this.TC2Selector = new System.Windows.Forms.ColorDialog();
            this.GTCSelector = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // Prim
            // 
            this.Prim.AutoSize = true;
            this.Prim.ForeColor = System.Drawing.SystemColors.Window;
            this.Prim.Location = new System.Drawing.Point(12, 9);
            this.Prim.Name = "Prim";
            this.Prim.Size = new System.Drawing.Size(87, 15);
            this.Prim.TabIndex = 0;
            this.Prim.Text = "Primary Colour";
            // 
            // PrimBtn
            // 
            this.PrimBtn.Location = new System.Drawing.Point(150, 5);
            this.PrimBtn.Name = "PrimBtn";
            this.PrimBtn.Size = new System.Drawing.Size(75, 23);
            this.PrimBtn.TabIndex = 1;
            this.PrimBtn.Text = "Customise";
            this.PrimBtn.UseVisualStyleBackColor = true;
            this.PrimBtn.Click += new System.EventHandler(this.PrimBtn_Click);
            // 
            // SecBtn
            // 
            this.SecBtn.Location = new System.Drawing.Point(150, 34);
            this.SecBtn.Name = "SecBtn";
            this.SecBtn.Size = new System.Drawing.Size(75, 23);
            this.SecBtn.TabIndex = 2;
            this.SecBtn.Text = "Customise";
            this.SecBtn.UseVisualStyleBackColor = true;
            this.SecBtn.Click += new System.EventHandler(this.SecBtn_Click);
            // 
            // TC1Btn
            // 
            this.TC1Btn.Location = new System.Drawing.Point(150, 63);
            this.TC1Btn.Name = "TC1Btn";
            this.TC1Btn.Size = new System.Drawing.Size(75, 23);
            this.TC1Btn.TabIndex = 3;
            this.TC1Btn.Text = "Customise";
            this.TC1Btn.UseVisualStyleBackColor = true;
            this.TC1Btn.Click += new System.EventHandler(this.TC1Btn_Click);
            // 
            // TC2Btn
            // 
            this.TC2Btn.Location = new System.Drawing.Point(150, 92);
            this.TC2Btn.Name = "TC2Btn";
            this.TC2Btn.Size = new System.Drawing.Size(75, 23);
            this.TC2Btn.TabIndex = 4;
            this.TC2Btn.Text = "Customise";
            this.TC2Btn.UseVisualStyleBackColor = true;
            this.TC2Btn.Click += new System.EventHandler(this.TC2Btn_Click);
            // 
            // Sec
            // 
            this.Sec.AutoSize = true;
            this.Sec.ForeColor = System.Drawing.SystemColors.Window;
            this.Sec.Location = new System.Drawing.Point(12, 38);
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(101, 15);
            this.Sec.TabIndex = 5;
            this.Sec.Text = "Secondary Colour";
            // 
            // TC1
            // 
            this.TC1.AutoSize = true;
            this.TC1.ForeColor = System.Drawing.SystemColors.Window;
            this.TC1.Location = new System.Drawing.Point(12, 67);
            this.TC1.Name = "TC1";
            this.TC1.Size = new System.Drawing.Size(81, 15);
            this.TC1.TabIndex = 6;
            this.TC1.Text = "Time Colour 1";
            // 
            // TC2
            // 
            this.TC2.AutoSize = true;
            this.TC2.ForeColor = System.Drawing.SystemColors.Window;
            this.TC2.Location = new System.Drawing.Point(12, 96);
            this.TC2.Name = "TC2";
            this.TC2.Size = new System.Drawing.Size(81, 15);
            this.TC2.TabIndex = 7;
            this.TC2.Text = "Time Colour 2";
            // 
            // Gen
            // 
            this.Gen.AutoSize = true;
            this.Gen.ForeColor = System.Drawing.SystemColors.Window;
            this.Gen.Location = new System.Drawing.Point(12, 125);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(110, 15);
            this.Gen.TabIndex = 8;
            this.Gen.Text = "General Text Colour";
            // 
            // GenBtn
            // 
            this.GenBtn.Location = new System.Drawing.Point(150, 121);
            this.GenBtn.Name = "GenBtn";
            this.GenBtn.Size = new System.Drawing.Size(75, 23);
            this.GenBtn.TabIndex = 9;
            this.GenBtn.Text = "Customise";
            this.GenBtn.UseVisualStyleBackColor = true;
            this.GenBtn.Click += new System.EventHandler(this.GenBtn_Click);
            // 
            // PrimSelector
            // 
            this.PrimSelector.AnyColor = true;
            this.PrimSelector.FullOpen = true;
            this.PrimSelector.SolidColorOnly = true;
            this.PrimSelector.Color = Properties.Settings.Default.MainColour;
            // 
            // SecSelector
            // 
            this.SecSelector.AnyColor = true;
            this.SecSelector.FullOpen = true;
            this.SecSelector.SolidColorOnly = true;
            this.SecSelector.Color = Properties.Settings.Default.AccentColour;
            // 
            // TC1Selector
            // 
            this.TC1Selector.AnyColor = true;
            this.TC1Selector.FullOpen = true;
            this.TC1Selector.SolidColorOnly = true;
            this.TC1Selector.Color = Properties.Settings.Default.DisplayTextColour;
            // 
            // TC2Selector
            // 
            this.TC2Selector.AnyColor = true;
            this.TC2Selector.FullOpen = true;
            this.TC2Selector.SolidColorOnly = true;
            this.TC2Selector.Color = Properties.Settings.Default.TimesColour;
            // 
            // GTCSelector
            // 
            this.GTCSelector.AnyColor = true;
            this.GTCSelector.FullOpen = true;
            this.GTCSelector.SolidColorOnly = true;
            this.GTCSelector.Color = Properties.Settings.Default.TxtColour;
            // 
            // CustomiserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(241, 154);
            this.Controls.Add(this.GenBtn);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.TC2);
            this.Controls.Add(this.TC1);
            this.Controls.Add(this.Sec);
            this.Controls.Add(this.TC2Btn);
            this.Controls.Add(this.TC1Btn);
            this.Controls.Add(this.SecBtn);
            this.Controls.Add(this.PrimBtn);
            this.Controls.Add(this.Prim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(258, 194);
            this.MinimumSize = new System.Drawing.Size(256, 192);
            this.Name = "CustomiserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colour Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PrimBtn;
        private System.Windows.Forms.Button SecBtn;
        private System.Windows.Forms.Button TC1Btn;
        private System.Windows.Forms.Button TC2Btn;
        private System.Windows.Forms.Button GenBtn;
        public System.Windows.Forms.Label Prim;
        public System.Windows.Forms.Label Sec;
        public System.Windows.Forms.Label TC1;
        public System.Windows.Forms.Label TC2;
        public System.Windows.Forms.Label Gen;
        public System.Windows.Forms.ColorDialog PrimSelector;
        public System.Windows.Forms.ColorDialog SecSelector;
        public System.Windows.Forms.ColorDialog TC1Selector;
        public System.Windows.Forms.ColorDialog TC2Selector;
        public System.Windows.Forms.ColorDialog GTCSelector;
    }
}