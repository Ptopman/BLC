namespace BatteryLifeCalculator
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
            this.BTNSubmit = new System.Windows.Forms.Button();
            this.LBLYears = new System.Windows.Forms.Label();
            this.LBLMonths = new System.Windows.Forms.Label();
            this.LBLDays = new System.Windows.Forms.Label();
            this.LBLHours = new System.Windows.Forms.Label();
            this.LBLMinutes = new System.Windows.Forms.Label();
            this.LBLSeconds = new System.Windows.Forms.Label();
            this.NUDBatteryCap = new System.Windows.Forms.NumericUpDown();
            this.NUDCurrent = new System.Windows.Forms.NumericUpDown();
            this.GBInputSide = new System.Windows.Forms.GroupBox();
            this.LBLUserCheckCurrent = new System.Windows.Forms.Label();
            this.LBLUserCheckCap = new System.Windows.Forms.Label();
            this.CBCUnit = new System.Windows.Forms.ComboBox();
            this.CBBCUnit = new System.Windows.Forms.ComboBox();
            this.GBOutputSide = new System.Windows.Forms.GroupBox();
            this.GBOhmsLaw = new System.Windows.Forms.GroupBox();
            this.BTNOLSubmit = new System.Windows.Forms.Button();
            this.NUDValueThree = new System.Windows.Forms.Label();
            this.LBLValueOne = new System.Windows.Forms.Label();
            this.LBLValueTwo = new System.Windows.Forms.Label();
            this.NUDValueOne = new System.Windows.Forms.NumericUpDown();
            this.LBLValueThree = new System.Windows.Forms.Label();
            this.NUDValueTwo = new System.Windows.Forms.NumericUpDown();
            this.LBLOLMathSign = new System.Windows.Forms.Label();
            this.CBChangeLaw = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GBLEDRC = new System.Windows.Forms.GroupBox();
            this.BTNRSubmit = new System.Windows.Forms.Button();
            this.LBLROutput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDRFC = new System.Windows.Forms.NumericUpDown();
            this.NUDRFV = new System.Windows.Forms.NumericUpDown();
            this.NUDRSV = new System.Windows.Forms.NumericUpDown();
            this.GBBLC = new System.Windows.Forms.GroupBox();
            this.GB = new System.Windows.Forms.GroupBox();
            this.BTNCCSubmit = new System.Windows.Forms.Button();
            this.LBLCCWattage = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LBLCCSourceCurrent = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NUDCCOutputVoltage = new System.Windows.Forms.NumericUpDown();
            this.NUDCCOutputCurrent = new System.Windows.Forms.NumericUpDown();
            this.NUDCCSourceVoltage = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBatteryCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCurrent)).BeginInit();
            this.GBInputSide.SuspendLayout();
            this.GBOutputSide.SuspendLayout();
            this.GBOhmsLaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDValueOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDValueTwo)).BeginInit();
            this.GBLEDRC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRFC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRFV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRSV)).BeginInit();
            this.GBBLC.SuspendLayout();
            this.GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCCOutputVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCCOutputCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCCSourceVoltage)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNSubmit
            // 
            this.BTNSubmit.Location = new System.Drawing.Point(198, 222);
            this.BTNSubmit.Name = "BTNSubmit";
            this.BTNSubmit.Size = new System.Drawing.Size(75, 23);
            this.BTNSubmit.TabIndex = 0;
            this.BTNSubmit.Text = "Submit";
            this.BTNSubmit.UseVisualStyleBackColor = true;
            this.BTNSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBLYears
            // 
            this.LBLYears.Location = new System.Drawing.Point(6, 22);
            this.LBLYears.Name = "LBLYears";
            this.LBLYears.Size = new System.Drawing.Size(180, 23);
            this.LBLYears.TabIndex = 1;
            this.LBLYears.Text = "label1";
            this.LBLYears.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLMonths
            // 
            this.LBLMonths.Location = new System.Drawing.Point(6, 45);
            this.LBLMonths.Name = "LBLMonths";
            this.LBLMonths.Size = new System.Drawing.Size(180, 23);
            this.LBLMonths.TabIndex = 2;
            this.LBLMonths.Text = "label2";
            this.LBLMonths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLDays
            // 
            this.LBLDays.Location = new System.Drawing.Point(6, 68);
            this.LBLDays.Name = "LBLDays";
            this.LBLDays.Size = new System.Drawing.Size(180, 23);
            this.LBLDays.TabIndex = 3;
            this.LBLDays.Text = "label3";
            this.LBLDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLHours
            // 
            this.LBLHours.Location = new System.Drawing.Point(6, 91);
            this.LBLHours.Name = "LBLHours";
            this.LBLHours.Size = new System.Drawing.Size(180, 23);
            this.LBLHours.TabIndex = 4;
            this.LBLHours.Text = "label4";
            this.LBLHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLMinutes
            // 
            this.LBLMinutes.Location = new System.Drawing.Point(6, 114);
            this.LBLMinutes.Name = "LBLMinutes";
            this.LBLMinutes.Size = new System.Drawing.Size(180, 23);
            this.LBLMinutes.TabIndex = 5;
            this.LBLMinutes.Text = "label5";
            this.LBLMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLSeconds
            // 
            this.LBLSeconds.Location = new System.Drawing.Point(6, 137);
            this.LBLSeconds.Name = "LBLSeconds";
            this.LBLSeconds.Size = new System.Drawing.Size(180, 23);
            this.LBLSeconds.TabIndex = 6;
            this.LBLSeconds.Text = "label6";
            this.LBLSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NUDBatteryCap
            // 
            this.NUDBatteryCap.DecimalPlaces = 3;
            this.NUDBatteryCap.Location = new System.Drawing.Point(9, 22);
            this.NUDBatteryCap.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDBatteryCap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDBatteryCap.Name = "NUDBatteryCap";
            this.NUDBatteryCap.Size = new System.Drawing.Size(124, 20);
            this.NUDBatteryCap.TabIndex = 7;
            this.NUDBatteryCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUDBatteryCap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDCurrent
            // 
            this.NUDCurrent.DecimalPlaces = 3;
            this.NUDCurrent.Location = new System.Drawing.Point(9, 62);
            this.NUDCurrent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDCurrent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDCurrent.Name = "NUDCurrent";
            this.NUDCurrent.Size = new System.Drawing.Size(124, 20);
            this.NUDCurrent.TabIndex = 8;
            this.NUDCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUDCurrent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GBInputSide
            // 
            this.GBInputSide.Controls.Add(this.LBLUserCheckCurrent);
            this.GBInputSide.Controls.Add(this.LBLUserCheckCap);
            this.GBInputSide.Controls.Add(this.CBCUnit);
            this.GBInputSide.Controls.Add(this.CBBCUnit);
            this.GBInputSide.Controls.Add(this.NUDBatteryCap);
            this.GBInputSide.Controls.Add(this.NUDCurrent);
            this.GBInputSide.Location = new System.Drawing.Point(6, 32);
            this.GBInputSide.Name = "GBInputSide";
            this.GBInputSide.Size = new System.Drawing.Size(265, 184);
            this.GBInputSide.TabIndex = 9;
            this.GBInputSide.TabStop = false;
            this.GBInputSide.Text = "Input";
            // 
            // LBLUserCheckCurrent
            // 
            this.LBLUserCheckCurrent.Location = new System.Drawing.Point(6, 141);
            this.LBLUserCheckCurrent.Name = "LBLUserCheckCurrent";
            this.LBLUserCheckCurrent.Size = new System.Drawing.Size(253, 23);
            this.LBLUserCheckCurrent.TabIndex = 12;
            this.LBLUserCheckCurrent.Text = "label8";
            this.LBLUserCheckCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLUserCheckCap
            // 
            this.LBLUserCheckCap.Location = new System.Drawing.Point(6, 109);
            this.LBLUserCheckCap.Name = "LBLUserCheckCap";
            this.LBLUserCheckCap.Size = new System.Drawing.Size(253, 23);
            this.LBLUserCheckCap.TabIndex = 11;
            this.LBLUserCheckCap.Text = "label7";
            this.LBLUserCheckCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBCUnit
            // 
            this.CBCUnit.FormattingEnabled = true;
            this.CBCUnit.Items.AddRange(new object[] {
            "Amps",
            "Milliamps",
            "Microamps"});
            this.CBCUnit.Location = new System.Drawing.Point(139, 61);
            this.CBCUnit.Name = "CBCUnit";
            this.CBCUnit.Size = new System.Drawing.Size(120, 21);
            this.CBCUnit.TabIndex = 10;
            // 
            // CBBCUnit
            // 
            this.CBBCUnit.FormattingEnabled = true;
            this.CBBCUnit.Items.AddRange(new object[] {
            "Ampere hour",
            "Milliampere hour",
            "Microampere hour"});
            this.CBBCUnit.Location = new System.Drawing.Point(139, 21);
            this.CBBCUnit.Name = "CBBCUnit";
            this.CBBCUnit.Size = new System.Drawing.Size(120, 21);
            this.CBBCUnit.TabIndex = 9;
            // 
            // GBOutputSide
            // 
            this.GBOutputSide.Controls.Add(this.LBLYears);
            this.GBOutputSide.Controls.Add(this.LBLMonths);
            this.GBOutputSide.Controls.Add(this.LBLSeconds);
            this.GBOutputSide.Controls.Add(this.LBLDays);
            this.GBOutputSide.Controls.Add(this.LBLMinutes);
            this.GBOutputSide.Controls.Add(this.LBLHours);
            this.GBOutputSide.Location = new System.Drawing.Point(277, 32);
            this.GBOutputSide.Name = "GBOutputSide";
            this.GBOutputSide.Size = new System.Drawing.Size(192, 184);
            this.GBOutputSide.TabIndex = 10;
            this.GBOutputSide.TabStop = false;
            this.GBOutputSide.Text = "Output";
            // 
            // GBOhmsLaw
            // 
            this.GBOhmsLaw.Controls.Add(this.BTNOLSubmit);
            this.GBOhmsLaw.Controls.Add(this.NUDValueThree);
            this.GBOhmsLaw.Controls.Add(this.LBLValueOne);
            this.GBOhmsLaw.Controls.Add(this.LBLValueTwo);
            this.GBOhmsLaw.Controls.Add(this.NUDValueOne);
            this.GBOhmsLaw.Controls.Add(this.LBLValueThree);
            this.GBOhmsLaw.Controls.Add(this.NUDValueTwo);
            this.GBOhmsLaw.Controls.Add(this.LBLOLMathSign);
            this.GBOhmsLaw.Controls.Add(this.CBChangeLaw);
            this.GBOhmsLaw.Controls.Add(this.label2);
            this.GBOhmsLaw.Location = new System.Drawing.Point(66, 270);
            this.GBOhmsLaw.Name = "GBOhmsLaw";
            this.GBOhmsLaw.Size = new System.Drawing.Size(369, 147);
            this.GBOhmsLaw.TabIndex = 11;
            this.GBOhmsLaw.TabStop = false;
            this.GBOhmsLaw.Text = "Ohms Law";
            // 
            // BTNOLSubmit
            // 
            this.BTNOLSubmit.Location = new System.Drawing.Point(145, 118);
            this.BTNOLSubmit.Name = "BTNOLSubmit";
            this.BTNOLSubmit.Size = new System.Drawing.Size(75, 23);
            this.BTNOLSubmit.TabIndex = 20;
            this.BTNOLSubmit.Text = "Submit";
            this.BTNOLSubmit.UseVisualStyleBackColor = true;
            this.BTNOLSubmit.Click += new System.EventHandler(this.BTNOLSubmit_Click);
            // 
            // NUDValueThree
            // 
            this.NUDValueThree.Location = new System.Drawing.Point(253, 73);
            this.NUDValueThree.Name = "NUDValueThree";
            this.NUDValueThree.Size = new System.Drawing.Size(101, 21);
            this.NUDValueThree.TabIndex = 18;
            this.NUDValueThree.Text = "NA";
            this.NUDValueThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLValueOne
            // 
            this.LBLValueOne.Location = new System.Drawing.Point(6, 51);
            this.LBLValueOne.Name = "LBLValueOne";
            this.LBLValueOne.Size = new System.Drawing.Size(91, 21);
            this.LBLValueOne.TabIndex = 19;
            this.LBLValueOne.Text = "Current ( I )";
            this.LBLValueOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLValueTwo
            // 
            this.LBLValueTwo.Location = new System.Drawing.Point(126, 51);
            this.LBLValueTwo.Name = "LBLValueTwo";
            this.LBLValueTwo.Size = new System.Drawing.Size(94, 21);
            this.LBLValueTwo.TabIndex = 17;
            this.LBLValueTwo.Text = "Resistance ( R )";
            this.LBLValueTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NUDValueOne
            // 
            this.NUDValueOne.DecimalPlaces = 2;
            this.NUDValueOne.Location = new System.Drawing.Point(6, 75);
            this.NUDValueOne.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDValueOne.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDValueOne.Name = "NUDValueOne";
            this.NUDValueOne.Size = new System.Drawing.Size(91, 20);
            this.NUDValueOne.TabIndex = 16;
            this.NUDValueOne.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LBLValueThree
            // 
            this.LBLValueThree.Location = new System.Drawing.Point(253, 51);
            this.LBLValueThree.Name = "LBLValueThree";
            this.LBLValueThree.Size = new System.Drawing.Size(101, 21);
            this.LBLValueThree.TabIndex = 14;
            this.LBLValueThree.Text = "Voltage ( V )";
            this.LBLValueThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NUDValueTwo
            // 
            this.NUDValueTwo.DecimalPlaces = 2;
            this.NUDValueTwo.Location = new System.Drawing.Point(129, 75);
            this.NUDValueTwo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDValueTwo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDValueTwo.Name = "NUDValueTwo";
            this.NUDValueTwo.Size = new System.Drawing.Size(91, 20);
            this.NUDValueTwo.TabIndex = 15;
            this.NUDValueTwo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LBLOLMathSign
            // 
            this.LBLOLMathSign.Location = new System.Drawing.Point(103, 75);
            this.LBLOLMathSign.Name = "LBLOLMathSign";
            this.LBLOLMathSign.Size = new System.Drawing.Size(20, 21);
            this.LBLOLMathSign.TabIndex = 12;
            this.LBLOLMathSign.Text = "*";
            this.LBLOLMathSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBChangeLaw
            // 
            this.CBChangeLaw.FormattingEnabled = true;
            this.CBChangeLaw.Items.AddRange(new object[] {
            "I * R = V",
            "V / R = I",
            "V / I = R"});
            this.CBChangeLaw.Location = new System.Drawing.Point(6, 19);
            this.CBChangeLaw.Name = "CBChangeLaw";
            this.CBChangeLaw.Size = new System.Drawing.Size(127, 21);
            this.CBChangeLaw.TabIndex = 11;
            this.CBChangeLaw.SelectedIndexChanged += new System.EventHandler(this.CBChangeLaw_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(226, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GBLEDRC
            // 
            this.GBLEDRC.Controls.Add(this.BTNRSubmit);
            this.GBLEDRC.Controls.Add(this.LBLROutput);
            this.GBLEDRC.Controls.Add(this.label5);
            this.GBLEDRC.Controls.Add(this.label4);
            this.GBLEDRC.Controls.Add(this.label3);
            this.GBLEDRC.Controls.Add(this.NUDRFC);
            this.GBLEDRC.Controls.Add(this.NUDRFV);
            this.GBLEDRC.Controls.Add(this.NUDRSV);
            this.GBLEDRC.Location = new System.Drawing.Point(66, 423);
            this.GBLEDRC.Name = "GBLEDRC";
            this.GBLEDRC.Size = new System.Drawing.Size(369, 167);
            this.GBLEDRC.TabIndex = 12;
            this.GBLEDRC.TabStop = false;
            this.GBLEDRC.Text = "LED Resistor Calculator";
            // 
            // BTNRSubmit
            // 
            this.BTNRSubmit.Location = new System.Drawing.Point(145, 138);
            this.BTNRSubmit.Name = "BTNRSubmit";
            this.BTNRSubmit.Size = new System.Drawing.Size(75, 23);
            this.BTNRSubmit.TabIndex = 7;
            this.BTNRSubmit.Text = "Submit";
            this.BTNRSubmit.UseVisualStyleBackColor = true;
            this.BTNRSubmit.Click += new System.EventHandler(this.BTNRSubmit_Click);
            // 
            // LBLROutput
            // 
            this.LBLROutput.Location = new System.Drawing.Point(13, 107);
            this.LBLROutput.Name = "LBLROutput";
            this.LBLROutput.Size = new System.Drawing.Size(341, 23);
            this.LBLROutput.TabIndex = 6;
            this.LBLROutput.Text = "NA";
            this.LBLROutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(263, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Forword Current";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(136, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Forward Voltage";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supply Voltage";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NUDRFC
            // 
            this.NUDRFC.DecimalPlaces = 2;
            this.NUDRFC.Location = new System.Drawing.Point(263, 66);
            this.NUDRFC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDRFC.Name = "NUDRFC";
            this.NUDRFC.Size = new System.Drawing.Size(91, 20);
            this.NUDRFC.TabIndex = 2;
            this.NUDRFC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDRFV
            // 
            this.NUDRFV.DecimalPlaces = 2;
            this.NUDRFV.Location = new System.Drawing.Point(136, 66);
            this.NUDRFV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDRFV.Name = "NUDRFV";
            this.NUDRFV.Size = new System.Drawing.Size(91, 20);
            this.NUDRFV.TabIndex = 1;
            this.NUDRFV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDRSV
            // 
            this.NUDRSV.DecimalPlaces = 2;
            this.NUDRSV.Location = new System.Drawing.Point(13, 66);
            this.NUDRSV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDRSV.Name = "NUDRSV";
            this.NUDRSV.Size = new System.Drawing.Size(91, 20);
            this.NUDRSV.TabIndex = 0;
            this.NUDRSV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GBBLC
            // 
            this.GBBLC.Controls.Add(this.GBInputSide);
            this.GBBLC.Controls.Add(this.GBOutputSide);
            this.GBBLC.Controls.Add(this.BTNSubmit);
            this.GBBLC.Location = new System.Drawing.Point(12, 12);
            this.GBBLC.Name = "GBBLC";
            this.GBBLC.Size = new System.Drawing.Size(477, 252);
            this.GBBLC.TabIndex = 13;
            this.GBBLC.TabStop = false;
            this.GBBLC.Text = "Battery Life Calculator";
            // 
            // GB
            // 
            this.GB.Controls.Add(this.BTNCCSubmit);
            this.GB.Controls.Add(this.LBLCCWattage);
            this.GB.Controls.Add(this.label12);
            this.GB.Controls.Add(this.label11);
            this.GB.Controls.Add(this.LBLCCSourceCurrent);
            this.GB.Controls.Add(this.label9);
            this.GB.Controls.Add(this.label8);
            this.GB.Controls.Add(this.label7);
            this.GB.Controls.Add(this.label6);
            this.GB.Controls.Add(this.NUDCCOutputVoltage);
            this.GB.Controls.Add(this.NUDCCOutputCurrent);
            this.GB.Controls.Add(this.NUDCCSourceVoltage);
            this.GB.Location = new System.Drawing.Point(66, 596);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(369, 172);
            this.GB.TabIndex = 14;
            this.GB.TabStop = false;
            this.GB.Text = "CurrentConverter";
            // 
            // BTNCCSubmit
            // 
            this.BTNCCSubmit.Location = new System.Drawing.Point(145, 143);
            this.BTNCCSubmit.Name = "BTNCCSubmit";
            this.BTNCCSubmit.Size = new System.Drawing.Size(75, 23);
            this.BTNCCSubmit.TabIndex = 12;
            this.BTNCCSubmit.Text = "Submit";
            this.BTNCCSubmit.UseVisualStyleBackColor = true;
            this.BTNCCSubmit.Click += new System.EventHandler(this.BTNCCSubmit_Click);
            // 
            // LBLCCWattage
            // 
            this.LBLCCWattage.Location = new System.Drawing.Point(136, 86);
            this.LBLCCWattage.Name = "LBLCCWattage";
            this.LBLCCWattage.Size = new System.Drawing.Size(97, 13);
            this.LBLCCWattage.TabIndex = 11;
            this.LBLCCWattage.Text = "NA";
            this.LBLCCWattage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(233, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Output:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(36, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Source:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLCCSourceCurrent
            // 
            this.LBLCCSourceCurrent.Location = new System.Drawing.Point(36, 108);
            this.LBLCCSourceCurrent.Name = "LBLCCSourceCurrent";
            this.LBLCCSourceCurrent.Size = new System.Drawing.Size(97, 13);
            this.LBLCCSourceCurrent.TabIndex = 8;
            this.LBLCCSourceCurrent.Text = "NA";
            this.LBLCCSourceCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(230, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Current (mA):";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(36, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Current (mA):";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(233, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Voltage:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(36, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Voltage:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NUDCCOutputVoltage
            // 
            this.NUDCCOutputVoltage.DecimalPlaces = 2;
            this.NUDCCOutputVoltage.Location = new System.Drawing.Point(233, 52);
            this.NUDCCOutputVoltage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDCCOutputVoltage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDCCOutputVoltage.Name = "NUDCCOutputVoltage";
            this.NUDCCOutputVoltage.Size = new System.Drawing.Size(97, 20);
            this.NUDCCOutputVoltage.TabIndex = 2;
            this.NUDCCOutputVoltage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDCCOutputCurrent
            // 
            this.NUDCCOutputCurrent.DecimalPlaces = 2;
            this.NUDCCOutputCurrent.Location = new System.Drawing.Point(233, 106);
            this.NUDCCOutputCurrent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDCCOutputCurrent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDCCOutputCurrent.Name = "NUDCCOutputCurrent";
            this.NUDCCOutputCurrent.Size = new System.Drawing.Size(97, 20);
            this.NUDCCOutputCurrent.TabIndex = 1;
            this.NUDCCOutputCurrent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDCCSourceVoltage
            // 
            this.NUDCCSourceVoltage.DecimalPlaces = 2;
            this.NUDCCSourceVoltage.Location = new System.Drawing.Point(36, 52);
            this.NUDCCSourceVoltage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDCCSourceVoltage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDCCSourceVoltage.Name = "NUDCCSourceVoltage";
            this.NUDCCSourceVoltage.Size = new System.Drawing.Size(97, 20);
            this.NUDCCSourceVoltage.TabIndex = 0;
            this.NUDCCSourceVoltage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 783);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.GBBLC);
            this.Controls.Add(this.GBLEDRC);
            this.Controls.Add(this.GBOhmsLaw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Battery Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDBatteryCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCurrent)).EndInit();
            this.GBInputSide.ResumeLayout(false);
            this.GBOutputSide.ResumeLayout(false);
            this.GBOhmsLaw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUDValueOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDValueTwo)).EndInit();
            this.GBLEDRC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUDRFC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRFV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRSV)).EndInit();
            this.GBBLC.ResumeLayout(false);
            this.GB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUDCCOutputVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCCOutputCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCCSourceVoltage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNSubmit;
        private System.Windows.Forms.Label LBLYears;
        private System.Windows.Forms.Label LBLMonths;
        private System.Windows.Forms.Label LBLDays;
        private System.Windows.Forms.Label LBLHours;
        private System.Windows.Forms.Label LBLMinutes;
        private System.Windows.Forms.Label LBLSeconds;
        private System.Windows.Forms.NumericUpDown NUDBatteryCap;
        private System.Windows.Forms.NumericUpDown NUDCurrent;
        private System.Windows.Forms.GroupBox GBInputSide;
        private System.Windows.Forms.ComboBox CBBCUnit;
        private System.Windows.Forms.GroupBox GBOutputSide;
        private System.Windows.Forms.ComboBox CBCUnit;
        private System.Windows.Forms.Label LBLUserCheckCurrent;
        private System.Windows.Forms.Label LBLUserCheckCap;
        private System.Windows.Forms.GroupBox GBOhmsLaw;
        private System.Windows.Forms.ComboBox CBChangeLaw;
        private System.Windows.Forms.Label LBLOLMathSign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNOLSubmit;
        private System.Windows.Forms.Label NUDValueThree;
        private System.Windows.Forms.Label LBLValueOne;
        private System.Windows.Forms.Label LBLValueTwo;
        private System.Windows.Forms.NumericUpDown NUDValueOne;
        private System.Windows.Forms.Label LBLValueThree;
        private System.Windows.Forms.NumericUpDown NUDValueTwo;
        private System.Windows.Forms.GroupBox GBLEDRC;
        private System.Windows.Forms.GroupBox GBBLC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUDRFC;
        private System.Windows.Forms.NumericUpDown NUDRFV;
        private System.Windows.Forms.NumericUpDown NUDRSV;
        private System.Windows.Forms.Label LBLROutput;
        private System.Windows.Forms.Button BTNRSubmit;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.Label LBLCCWattage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LBLCCSourceCurrent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NUDCCOutputVoltage;
        private System.Windows.Forms.NumericUpDown NUDCCOutputCurrent;
        private System.Windows.Forms.NumericUpDown NUDCCSourceVoltage;
        private System.Windows.Forms.Button BTNCCSubmit;
    }
}

