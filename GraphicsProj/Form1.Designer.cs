
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownLightningX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLightningY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLightningZ = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownRotationZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRotationY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRotationX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownTranslateX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTranslateZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTranslateY = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightningX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightningY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightningZ)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTranslateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTranslateZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTranslateY)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load .obj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.numericUpDownZ);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(672, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 650);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownLightningX, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownLightningY, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownLightningZ, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(58, 466);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(186, 80);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.Location = new System.Drawing.Point(65, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lightning";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownLightningX
            // 
            this.numericUpDownLightningX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownLightningX.DecimalPlaces = 2;
            this.numericUpDownLightningX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownLightningX.Location = new System.Drawing.Point(3, 49);
            this.numericUpDownLightningX.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownLightningX.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numericUpDownLightningX.Name = "numericUpDownLightningX";
            this.numericUpDownLightningX.Size = new System.Drawing.Size(56, 22);
            this.numericUpDownLightningX.TabIndex = 1;
            this.numericUpDownLightningX.ValueChanged += new System.EventHandler(this.numericUpDownLightningX_ValueChanged);
            // 
            // numericUpDownLightningY
            // 
            this.numericUpDownLightningY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownLightningY.DecimalPlaces = 2;
            this.numericUpDownLightningY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownLightningY.Location = new System.Drawing.Point(65, 49);
            this.numericUpDownLightningY.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownLightningY.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numericUpDownLightningY.Name = "numericUpDownLightningY";
            this.numericUpDownLightningY.Size = new System.Drawing.Size(56, 22);
            this.numericUpDownLightningY.TabIndex = 2;
            this.numericUpDownLightningY.ValueChanged += new System.EventHandler(this.numericUpDownLightningY_ValueChanged);
            // 
            // numericUpDownLightningZ
            // 
            this.numericUpDownLightningZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownLightningZ.DecimalPlaces = 2;
            this.numericUpDownLightningZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownLightningZ.Location = new System.Drawing.Point(127, 49);
            this.numericUpDownLightningZ.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownLightningZ.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numericUpDownLightningZ.Name = "numericUpDownLightningZ";
            this.numericUpDownLightningZ.Size = new System.Drawing.Size(56, 22);
            this.numericUpDownLightningZ.TabIndex = 3;
            this.numericUpDownLightningZ.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownLightningZ.ValueChanged += new System.EventHandler(this.numericUpDownLightningZ_ValueChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(57, 437);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(128, 20);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "Scale translation";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownRotationZ, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownX, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownRotationY, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownY, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownRotationX, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownTranslateX, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownTranslateZ, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownTranslateY, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(58, 115);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(188, 220);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(126, 40);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 28);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Link";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(64, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Scale";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownRotationZ
            // 
            this.numericUpDownRotationZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownRotationZ.DecimalPlaces = 2;
            this.numericUpDownRotationZ.Enabled = false;
            this.numericUpDownRotationZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownRotationZ.Location = new System.Drawing.Point(127, 189);
            this.numericUpDownRotationZ.Margin = new System.Windows.Forms.Padding(2);
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
            this.numericUpDownRotationZ.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownRotationZ.TabIndex = 14;
            this.numericUpDownRotationZ.ValueChanged += new System.EventHandler(this.numericUpDownRotationZ_ValueChanged);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownX.DecimalPlaces = 2;
            this.numericUpDownX.Enabled = false;
            this.numericUpDownX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownX.Location = new System.Drawing.Point(2, 43);
            this.numericUpDownX.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownX.TabIndex = 3;
            this.numericUpDownX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDownX_ValueChanged);
            // 
            // numericUpDownRotationY
            // 
            this.numericUpDownRotationY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownRotationY.DecimalPlaces = 2;
            this.numericUpDownRotationY.Enabled = false;
            this.numericUpDownRotationY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownRotationY.Location = new System.Drawing.Point(64, 189);
            this.numericUpDownRotationY.Margin = new System.Windows.Forms.Padding(2);
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
            this.numericUpDownRotationY.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownRotationY.TabIndex = 13;
            this.numericUpDownRotationY.ValueChanged += new System.EventHandler(this.numericUpDownRotationY_ValueChanged);
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownY.DecimalPlaces = 2;
            this.numericUpDownY.Enabled = false;
            this.numericUpDownY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownY.Location = new System.Drawing.Point(64, 43);
            this.numericUpDownY.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownY.TabIndex = 5;
            this.numericUpDownY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDownY_ValueChanged);
            // 
            // numericUpDownRotationX
            // 
            this.numericUpDownRotationX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownRotationX.DecimalPlaces = 2;
            this.numericUpDownRotationX.Enabled = false;
            this.numericUpDownRotationX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownRotationX.Location = new System.Drawing.Point(2, 189);
            this.numericUpDownRotationX.Margin = new System.Windows.Forms.Padding(2);
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
            this.numericUpDownRotationX.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownRotationX.TabIndex = 12;
            this.numericUpDownRotationX.ValueChanged += new System.EventHandler(this.numericUpDownRotationX_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(64, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Translation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(64, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rotation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownTranslateX
            // 
            this.numericUpDownTranslateX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownTranslateX.DecimalPlaces = 2;
            this.numericUpDownTranslateX.Enabled = false;
            this.numericUpDownTranslateX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownTranslateX.Location = new System.Drawing.Point(2, 115);
            this.numericUpDownTranslateX.Margin = new System.Windows.Forms.Padding(2);
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
            this.numericUpDownTranslateX.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownTranslateX.TabIndex = 7;
            this.numericUpDownTranslateX.ValueChanged += new System.EventHandler(this.numericUpDownTranslateX_ValueChanged);
            // 
            // numericUpDownTranslateZ
            // 
            this.numericUpDownTranslateZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownTranslateZ.DecimalPlaces = 2;
            this.numericUpDownTranslateZ.Enabled = false;
            this.numericUpDownTranslateZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownTranslateZ.Location = new System.Drawing.Point(127, 115);
            this.numericUpDownTranslateZ.Margin = new System.Windows.Forms.Padding(2);
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
            this.numericUpDownTranslateZ.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownTranslateZ.TabIndex = 9;
            this.numericUpDownTranslateZ.ValueChanged += new System.EventHandler(this.numericUpDownTranslateZ_ValueChanged);
            // 
            // numericUpDownTranslateY
            // 
            this.numericUpDownTranslateY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownTranslateY.DecimalPlaces = 2;
            this.numericUpDownTranslateY.Enabled = false;
            this.numericUpDownTranslateY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownTranslateY.Location = new System.Drawing.Point(64, 115);
            this.numericUpDownTranslateY.Margin = new System.Windows.Forms.Padding(2);
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
            this.numericUpDownTranslateY.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownTranslateY.TabIndex = 8;
            this.numericUpDownTranslateY.ValueChanged += new System.EventHandler(this.numericUpDownTranslateY_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(57, 357);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(188, 75);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multiplication order";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 20);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "SRT";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 20);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "STR";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 48);
            this.button2.TabIndex = 15;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 650);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.Visible = false;
            this.numericUpDownZ.DecimalPlaces = 2;
            this.numericUpDownZ.Enabled = false;
            this.numericUpDownZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownZ.Location = new System.Drawing.Point(186, 582);
            this.numericUpDownZ.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownZ.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownZ.Name = "numericUpDownZ";
            this.numericUpDownZ.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownZ.TabIndex = 4;
            this.numericUpDownZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownZ.ValueChanged += new System.EventHandler(this.numericUpDownZ_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(980, 672);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Graphics Project";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightningX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightningY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightningZ)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTranslateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTranslateZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTranslateY)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownLightningX;
        private System.Windows.Forms.NumericUpDown numericUpDownLightningY;
        private System.Windows.Forms.NumericUpDown numericUpDownLightningZ;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
    }
}

