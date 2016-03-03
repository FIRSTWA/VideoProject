namespace FRCOverlayGenerator
{
    partial class FRCOverlayController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRCOverlayController));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetMatch = new System.Windows.Forms.Button();
            this.Match = new System.Windows.Forms.NumericUpDown();
            this.Level = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Regional = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GetSCHED = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Match)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripDropDownButton1,
            this.toolStripLabel1,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1924, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 25);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 25);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(160, 28);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 210);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(290, 202);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Match:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Response:";
            // 
            // GetMatch
            // 
            this.GetMatch.Location = new System.Drawing.Point(163, 156);
            this.GetMatch.Name = "GetMatch";
            this.GetMatch.Size = new System.Drawing.Size(99, 23);
            this.GetMatch.TabIndex = 5;
            this.GetMatch.Text = "Get Match";
            this.GetMatch.UseVisualStyleBackColor = true;
            this.GetMatch.Click += new System.EventHandler(this.GetMatch_Click);
            // 
            // Match
            // 
            this.Match.Location = new System.Drawing.Point(23, 156);
            this.Match.Name = "Match";
            this.Match.Size = new System.Drawing.Size(120, 22);
            this.Match.TabIndex = 2;
            this.Match.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Match.ValueChanged += new System.EventHandler(this.Match_ValueChanged);
            // 
            // Level
            // 
            this.Level.FormattingEnabled = true;
            this.Level.Items.AddRange(new object[] {
            "qual",
            "playoff"});
            this.Level.Location = new System.Drawing.Point(23, 109);
            this.Level.MaxDropDownItems = 2;
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(98, 24);
            this.Level.TabIndex = 6;
            this.Level.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Level:";
            // 
            // Regional
            // 
            this.Regional.Location = new System.Drawing.Point(25, 60);
            this.Regional.Name = "Regional";
            this.Regional.Size = new System.Drawing.Size(95, 22);
            this.Regional.TabIndex = 8;
            this.Regional.TextChanged += new System.EventHandler(this.Regional_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Regional Code: (TESTING W/ SCMB)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // GetSCHED
            // 
            this.GetSCHED.ForeColor = System.Drawing.Color.Black;
            this.GetSCHED.Location = new System.Drawing.Point(132, 60);
            this.GetSCHED.Name = "GetSCHED";
            this.GetSCHED.Size = new System.Drawing.Size(129, 22);
            this.GetSCHED.TabIndex = 10;
            this.GetSCHED.Text = "GetSCHED";
            this.GetSCHED.UseVisualStyleBackColor = true;
            this.GetSCHED.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRCOverlayController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 806);
            this.Controls.Add(this.GetSCHED);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Regional);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.GetMatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Match);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRCOverlayController";
            this.Text = "FRCOverlayController";
            this.Load += new System.EventHandler(this.FRCOverlayController_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Match)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetMatch;
        private System.Windows.Forms.NumericUpDown Match;
        private System.Windows.Forms.ComboBox Level;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Regional;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GetSCHED;
    }
}

