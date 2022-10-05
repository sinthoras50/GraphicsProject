
namespace GraphicsProject
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDownRotationZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRotationY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRotationX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownTranslateZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTranslateY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTranslateX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTranslateZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTranslateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTranslateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load .obj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.numericUpDownRotationZ);
            this.panel1.Controls.Add(this.numericUpDownRotationY);
            this.panel1.Controls.Add(this.numericUpDownRotationX);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numericUpDownTranslateZ);
            this.panel1.Controls.Add(this.numericUpDownTranslateY);
            this.panel1.Controls.Add(this.numericUpDownTranslateX);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDownY);
            this.panel1.Controls.Add(this.numericUpDownZ);
            this.panel1.Controls.Add(this.numericUpDownX);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(839, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 814);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 47);
            this.button2.TabIndex = 15;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDownRotationZ
            // 
            this.numericUpDownRotationZ.DecimalPlaces = 2;
            this.numericUpDownRotationZ.Enabled = false;
            this.numericUpDownRotationZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownRotationZ.Location = new System.Drawing.Point(188, 304);
            this.numericUpDownRotationZ.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRotationZ.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownRotationZ.Name = "numericUpDownRotationZ";
            this.numericUpDownRotationZ.Size = new System.Drawing.Size(57, 22);
            this.numericUpDownRotationZ.TabIndex = 14;
            this.numericUpDownRotationZ.ValueChanged += new System.EventHandler(this.numericUpDownRotationZ_ValueChanged);
            // 
            // numericUpDownRotationY
            // 
            this.numericUpDownRotationY.DecimalPlaces = 2;
            this.numericUpDownRotationY.Enabled = false;
            this.numericUpDownRotationY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownRotationY.Location = new System.Drawing.Point(122, 304);
            this.numericUpDownRotationY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRotationY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownRotationY.Name = "numericUpDownRotationY";
            this.numericUpDownRotationY.Size = new System.Drawing.Size(57, 22);
            this.numericUpDownRotationY.TabIndex = 13;
            this.numericUpDownRotationY.ValueChanged += new System.EventHandler(this.numericUpDownRotationY_ValueChanged);
            // 
            // numericUpDownRotationX
            // 
            this.numericUpDownRotationX.DecimalPlaces = 2;
            this.numericUpDownRotationX.Enabled = false;
            this.numericUpDownRotationX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownRotationX.Location = new System.Drawing.Point(57, 304);
            this.numericUpDownRotationX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRotationX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownRotationX.Name = "numericUpDownRotationX";
            this.numericUpDownRotationX.Size = new System.Drawing.Size(57, 22);
            this.numericUpDownRotationX.TabIndex = 12;
            this.numericUpDownRotationX.ValueChanged += new System.EventHandler(this.numericUpDownRotationX_ValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rotation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Translation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownTranslateZ
            // 
            this.numericUpDownTranslateZ.DecimalPlaces = 2;
            this.numericUpDownTranslateZ.Enabled = false;
            this.numericUpDownTranslateZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownTranslateZ.Location = new System.Drawing.Point(187, 233);
            this.numericUpDownTranslateZ.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTranslateZ.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownTranslateZ.Name = "numericUpDownTranslateZ";
            this.numericUpDownTranslateZ.Size = new System.Drawing.Size(57, 22);
            this.numericUpDownTranslateZ.TabIndex = 9;
            this.numericUpDownTranslateZ.ValueChanged += new System.EventHandler(this.numericUpDownTranslateZ_ValueChanged);
            // 
            // numericUpDownTranslateY
            // 
            this.numericUpDownTranslateY.DecimalPlaces = 2;
            this.numericUpDownTranslateY.Enabled = false;
            this.numericUpDownTranslateY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownTranslateY.Location = new System.Drawing.Point(122, 233);
            this.numericUpDownTranslateY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTranslateY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownTranslateY.Name = "numericUpDownTranslateY";
            this.numericUpDownTranslateY.Size = new System.Drawing.Size(57, 22);
            this.numericUpDownTranslateY.TabIndex = 8;
            this.numericUpDownTranslateY.ValueChanged += new System.EventHandler(this.numericUpDownTranslateY_ValueChanged);
            // 
            // numericUpDownTranslateX
            // 
            this.numericUpDownTranslateX.DecimalPlaces = 2;
            this.numericUpDownTranslateX.Enabled = false;
            this.numericUpDownTranslateX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownTranslateX.Location = new System.Drawing.Point(57, 233);
            this.numericUpDownTranslateX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTranslateX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownTranslateX.Name = "numericUpDownTranslateX";
            this.numericUpDownTranslateX.Size = new System.Drawing.Size(57, 22);
            this.numericUpDownTranslateX.TabIndex = 7;
            this.numericUpDownTranslateX.ValueChanged += new System.EventHandler(this.numericUpDownTranslateX_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Scale";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.DecimalPlaces = 2;
            this.numericUpDownY.Enabled = false;
            this.numericUpDownY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownY.Location = new System.Drawing.Point(122, 167);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(57, 22);
            this.numericUpDownY.TabIndex = 5;
            this.numericUpDownY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDownY_ValueChanged);
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.DecimalPlaces = 2;
            this.numericUpDownZ.Enabled = false;
            this.numericUpDownZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownZ.Location = new System.Drawing.Point(188, 167);
            this.numericUpDownZ.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownZ.Name = "numericUpDownZ";
            this.numericUpDownZ.Size = new System.Drawing.Size(57, 22);
            this.numericUpDownZ.TabIndex = 4;
            this.numericUpDownZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownZ.ValueChanged += new System.EventHandler(this.numericUpDownZ_ValueChanged);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.DecimalPlaces = 2;
            this.numericUpDownX.Enabled = false;
            this.numericUpDownX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownX.Location = new System.Drawing.Point(57, 167);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(57, 22);
            this.numericUpDownX.TabIndex = 3;
            this.numericUpDownX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDownX_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 814);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // radioButton1
            // 
            this.radioButton1.Enabled = false;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 20);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "STR";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Enabled = false;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 20);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "SRT";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(57, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 75);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multiplication order";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1147, 838);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Graphics Project";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTranslateZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTranslateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTranslateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownTranslateZ;
        private System.Windows.Forms.NumericUpDown numericUpDownTranslateY;
        private System.Windows.Forms.NumericUpDown numericUpDownTranslateX;
        private System.Windows.Forms.NumericUpDown numericUpDownRotationZ;
        private System.Windows.Forms.NumericUpDown numericUpDownRotationY;
        private System.Windows.Forms.NumericUpDown numericUpDownRotationX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

