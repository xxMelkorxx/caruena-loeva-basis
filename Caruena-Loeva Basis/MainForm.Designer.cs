
namespace Caruena_Loeva_Basis
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.GroupBox groupBox_inputParams;
			System.Windows.Forms.Label label_eigenvectorNumber;
			System.Windows.Forms.Label label_correlationOrder;
			System.Windows.Forms.Label label_phase3;
			System.Windows.Forms.Label label_frequency3;
			System.Windows.Forms.Label label_amplitude3;
			System.Windows.Forms.Label label_phase2;
			System.Windows.Forms.Label label_frequency2;
			System.Windows.Forms.Label label_amplitude2;
			System.Windows.Forms.Label label_phase1;
			System.Windows.Forms.Label label_frequency1;
			System.Windows.Forms.Label label_amplitude1;
			System.Windows.Forms.Label label_mathExpectation3;
			System.Windows.Forms.Label label_sko3;
			System.Windows.Forms.Label label_amplitudeGauss3;
			System.Windows.Forms.Label label_mathExpectation2;
			System.Windows.Forms.Label label_sko2;
			System.Windows.Forms.Label label_amplitudeGauss2;
			System.Windows.Forms.Label label_mathExpectation1;
			System.Windows.Forms.Label label_sko1;
			System.Windows.Forms.Label label_amplitudeGauss1;
			System.Windows.Forms.Label label_phaseED3;
			System.Windows.Forms.Label label_frequencyED3;
			System.Windows.Forms.Label label_attenuation3;
			System.Windows.Forms.Label label_phaseED2;
			System.Windows.Forms.Label label_frequencyED2;
			System.Windows.Forms.Label label_attenuation2;
			System.Windows.Forms.Label label_phaseED1;
			System.Windows.Forms.Label labelfrequencyED1;
			System.Windows.Forms.Label label_attenuation1;
			System.Windows.Forms.GroupBox groupBox_graphInitSgnl;
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.GroupBox groupBox_graphSVD;
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.Label labelDiscrepancy;
			System.Windows.Forms.Label label_N;
			System.Windows.Forms.Label label_M;
			System.Windows.Forms.GroupBox groupBox_eigenvector;
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.Label label_max;
			System.Windows.Forms.Label label_min;
			this.numericUpDown_eigenvectorNumber = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_correlationOrder = new System.Windows.Forms.NumericUpDown();
			this.tabControl_sgnlParam = new System.Windows.Forms.TabControl();
			this.tabPage_harmonic = new System.Windows.Forms.TabPage();
			this.trackBar_harmonics = new System.Windows.Forms.TrackBar();
			this.groupBox_harmonica3 = new System.Windows.Forms.GroupBox();
			this.numericUpDown_phase3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_frequency3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_amplitude3 = new System.Windows.Forms.NumericUpDown();
			this.groupBox_harmonica2 = new System.Windows.Forms.GroupBox();
			this.numericUpDown_phase2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_frequency2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_amplitude2 = new System.Windows.Forms.NumericUpDown();
			this.groupBox_harmonica1 = new System.Windows.Forms.GroupBox();
			this.numericUpDown_phase1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_frequency1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_amplitude1 = new System.Windows.Forms.NumericUpDown();
			this.tabPage_gauss = new System.Windows.Forms.TabPage();
			this.trackBar_gauss = new System.Windows.Forms.TrackBar();
			this.groupBox_dome3 = new System.Windows.Forms.GroupBox();
			this.numericUpDown_mathExpectation3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_sko3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_amplitudeGauss3 = new System.Windows.Forms.NumericUpDown();
			this.groupBox_dome2 = new System.Windows.Forms.GroupBox();
			this.numericUpDown_mathExpectation2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_sko2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_amplitudeGauss2 = new System.Windows.Forms.NumericUpDown();
			this.groupBox_dome1 = new System.Windows.Forms.GroupBox();
			this.numericUpDown_mathExpectation1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_sko1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_amplitudeGauss1 = new System.Windows.Forms.NumericUpDown();
			this.tabPage_expDecaying = new System.Windows.Forms.TabPage();
			this.trackBar_expDecaying = new System.Windows.Forms.TrackBar();
			this.groupBox_сomponent3 = new System.Windows.Forms.GroupBox();
			this.numericUpDown_phaseED3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_frequencyED3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_attenuation3 = new System.Windows.Forms.NumericUpDown();
			this.groupBox_сomponent2 = new System.Windows.Forms.GroupBox();
			this.numericUpDown_phaseED2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_frequencyED2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_attenuation2 = new System.Windows.Forms.NumericUpDown();
			this.groupBox_сomponent1 = new System.Windows.Forms.GroupBox();
			this.numericUpDown_phaseED1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_frequencyED1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_attenuation1 = new System.Windows.Forms.NumericUpDown();
			this.buttonGenerateSgnl = new System.Windows.Forms.Button();
			this.chart_initSgnl = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart_graphSVD = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart_eigenvector = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox_sleParams = new System.Windows.Forms.GroupBox();
			this.richTextBoxResultSLE = new System.Windows.Forms.RichTextBox();
			this.textBoxDiscrepancy = new System.Windows.Forms.TextBox();
			this.buttonSolveSLE = new System.Windows.Forms.Button();
			this.groupBox_sizeSLE = new System.Windows.Forms.GroupBox();
			this.numericUpDown_max = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_min = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_N = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_M = new System.Windows.Forms.NumericUpDown();
			groupBox_inputParams = new System.Windows.Forms.GroupBox();
			label_eigenvectorNumber = new System.Windows.Forms.Label();
			label_correlationOrder = new System.Windows.Forms.Label();
			label_phase3 = new System.Windows.Forms.Label();
			label_frequency3 = new System.Windows.Forms.Label();
			label_amplitude3 = new System.Windows.Forms.Label();
			label_phase2 = new System.Windows.Forms.Label();
			label_frequency2 = new System.Windows.Forms.Label();
			label_amplitude2 = new System.Windows.Forms.Label();
			label_phase1 = new System.Windows.Forms.Label();
			label_frequency1 = new System.Windows.Forms.Label();
			label_amplitude1 = new System.Windows.Forms.Label();
			label_mathExpectation3 = new System.Windows.Forms.Label();
			label_sko3 = new System.Windows.Forms.Label();
			label_amplitudeGauss3 = new System.Windows.Forms.Label();
			label_mathExpectation2 = new System.Windows.Forms.Label();
			label_sko2 = new System.Windows.Forms.Label();
			label_amplitudeGauss2 = new System.Windows.Forms.Label();
			label_mathExpectation1 = new System.Windows.Forms.Label();
			label_sko1 = new System.Windows.Forms.Label();
			label_amplitudeGauss1 = new System.Windows.Forms.Label();
			label_phaseED3 = new System.Windows.Forms.Label();
			label_frequencyED3 = new System.Windows.Forms.Label();
			label_attenuation3 = new System.Windows.Forms.Label();
			label_phaseED2 = new System.Windows.Forms.Label();
			label_frequencyED2 = new System.Windows.Forms.Label();
			label_attenuation2 = new System.Windows.Forms.Label();
			label_phaseED1 = new System.Windows.Forms.Label();
			labelfrequencyED1 = new System.Windows.Forms.Label();
			label_attenuation1 = new System.Windows.Forms.Label();
			groupBox_graphInitSgnl = new System.Windows.Forms.GroupBox();
			groupBox_graphSVD = new System.Windows.Forms.GroupBox();
			labelDiscrepancy = new System.Windows.Forms.Label();
			label_N = new System.Windows.Forms.Label();
			label_M = new System.Windows.Forms.Label();
			groupBox_eigenvector = new System.Windows.Forms.GroupBox();
			label_max = new System.Windows.Forms.Label();
			label_min = new System.Windows.Forms.Label();
			groupBox_inputParams.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_eigenvectorNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_correlationOrder)).BeginInit();
			this.tabControl_sgnlParam.SuspendLayout();
			this.tabPage_harmonic.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_harmonics)).BeginInit();
			this.groupBox_harmonica3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phase3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequency3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude3)).BeginInit();
			this.groupBox_harmonica2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phase2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequency2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude2)).BeginInit();
			this.groupBox_harmonica1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phase1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequency1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude1)).BeginInit();
			this.tabPage_gauss.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_gauss)).BeginInit();
			this.groupBox_dome3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mathExpectation3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sko3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitudeGauss3)).BeginInit();
			this.groupBox_dome2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mathExpectation2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sko2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitudeGauss2)).BeginInit();
			this.groupBox_dome1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mathExpectation1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sko1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitudeGauss1)).BeginInit();
			this.tabPage_expDecaying.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_expDecaying)).BeginInit();
			this.groupBox_сomponent3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phaseED3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequencyED3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_attenuation3)).BeginInit();
			this.groupBox_сomponent2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phaseED2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequencyED2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_attenuation2)).BeginInit();
			this.groupBox_сomponent1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phaseED1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequencyED1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_attenuation1)).BeginInit();
			groupBox_graphInitSgnl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart_initSgnl)).BeginInit();
			groupBox_graphSVD.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart_graphSVD)).BeginInit();
			groupBox_eigenvector.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart_eigenvector)).BeginInit();
			this.groupBox_sleParams.SuspendLayout();
			this.groupBox_sizeSLE.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_N)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_M)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox_inputParams
			// 
			groupBox_inputParams.Controls.Add(label_eigenvectorNumber);
			groupBox_inputParams.Controls.Add(this.numericUpDown_eigenvectorNumber);
			groupBox_inputParams.Controls.Add(label_correlationOrder);
			groupBox_inputParams.Controls.Add(this.numericUpDown_correlationOrder);
			groupBox_inputParams.Controls.Add(this.tabControl_sgnlParam);
			groupBox_inputParams.Controls.Add(this.buttonGenerateSgnl);
			groupBox_inputParams.Location = new System.Drawing.Point(12, 12);
			groupBox_inputParams.Name = "groupBox_inputParams";
			groupBox_inputParams.Size = new System.Drawing.Size(287, 343);
			groupBox_inputParams.TabIndex = 0;
			groupBox_inputParams.TabStop = false;
			groupBox_inputParams.Text = "Параметры сигнала:";
			// 
			// label_eigenvectorNumber
			// 
			label_eigenvectorNumber.AutoSize = true;
			label_eigenvectorNumber.Location = new System.Drawing.Point(7, 272);
			label_eigenvectorNumber.Name = "label_eigenvectorNumber";
			label_eigenvectorNumber.Size = new System.Drawing.Size(161, 13);
			label_eigenvectorNumber.TabIndex = 12;
			label_eigenvectorNumber.Text = "Номер собственного вектора:";
			// 
			// numericUpDown_eigenvectorNumber
			// 
			this.numericUpDown_eigenvectorNumber.Location = new System.Drawing.Point(221, 270);
			this.numericUpDown_eigenvectorNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown_eigenvectorNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_eigenvectorNumber.Name = "numericUpDown_eigenvectorNumber";
			this.numericUpDown_eigenvectorNumber.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_eigenvectorNumber.TabIndex = 13;
			this.numericUpDown_eigenvectorNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_eigenvectorNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label_correlationOrder
			// 
			label_correlationOrder.AutoSize = true;
			label_correlationOrder.Location = new System.Drawing.Point(6, 246);
			label_correlationOrder.Name = "label_correlationOrder";
			label_correlationOrder.Size = new System.Drawing.Size(140, 13);
			label_correlationOrder.TabIndex = 10;
			label_correlationOrder.Text = "Порядок автокорреляции:";
			// 
			// numericUpDown_correlationOrder
			// 
			this.numericUpDown_correlationOrder.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_correlationOrder.Location = new System.Drawing.Point(221, 244);
			this.numericUpDown_correlationOrder.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown_correlationOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_correlationOrder.Name = "numericUpDown_correlationOrder";
			this.numericUpDown_correlationOrder.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_correlationOrder.TabIndex = 11;
			this.numericUpDown_correlationOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_correlationOrder.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// tabControl_sgnlParam
			// 
			this.tabControl_sgnlParam.Controls.Add(this.tabPage_harmonic);
			this.tabControl_sgnlParam.Controls.Add(this.tabPage_gauss);
			this.tabControl_sgnlParam.Controls.Add(this.tabPage_expDecaying);
			this.tabControl_sgnlParam.Location = new System.Drawing.Point(6, 19);
			this.tabControl_sgnlParam.Name = "tabControl_sgnlParam";
			this.tabControl_sgnlParam.SelectedIndex = 0;
			this.tabControl_sgnlParam.Size = new System.Drawing.Size(275, 219);
			this.tabControl_sgnlParam.TabIndex = 9;
			// 
			// tabPage_harmonic
			// 
			this.tabPage_harmonic.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage_harmonic.Controls.Add(this.trackBar_harmonics);
			this.tabPage_harmonic.Controls.Add(this.groupBox_harmonica3);
			this.tabPage_harmonic.Controls.Add(this.groupBox_harmonica2);
			this.tabPage_harmonic.Controls.Add(this.groupBox_harmonica1);
			this.tabPage_harmonic.Location = new System.Drawing.Point(4, 22);
			this.tabPage_harmonic.Name = "tabPage_harmonic";
			this.tabPage_harmonic.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_harmonic.Size = new System.Drawing.Size(267, 193);
			this.tabPage_harmonic.TabIndex = 0;
			this.tabPage_harmonic.Text = "Гармонический";
			// 
			// trackBar_harmonics
			// 
			this.trackBar_harmonics.LargeChange = 3;
			this.trackBar_harmonics.Location = new System.Drawing.Point(213, 22);
			this.trackBar_harmonics.Maximum = 3;
			this.trackBar_harmonics.Minimum = 1;
			this.trackBar_harmonics.Name = "trackBar_harmonics";
			this.trackBar_harmonics.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar_harmonics.Size = new System.Drawing.Size(45, 151);
			this.trackBar_harmonics.TabIndex = 12;
			this.trackBar_harmonics.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.trackBar_harmonics.Value = 1;
			this.trackBar_harmonics.Scroll += new System.EventHandler(this.OnScrollTrackBarHarmonics);
			// 
			// groupBox_harmonica3
			// 
			this.groupBox_harmonica3.Controls.Add(this.numericUpDown_phase3);
			this.groupBox_harmonica3.Controls.Add(label_phase3);
			this.groupBox_harmonica3.Controls.Add(this.numericUpDown_frequency3);
			this.groupBox_harmonica3.Controls.Add(label_frequency3);
			this.groupBox_harmonica3.Controls.Add(this.numericUpDown_amplitude3);
			this.groupBox_harmonica3.Controls.Add(label_amplitude3);
			this.groupBox_harmonica3.Enabled = false;
			this.groupBox_harmonica3.Location = new System.Drawing.Point(6, 6);
			this.groupBox_harmonica3.Name = "groupBox_harmonica3";
			this.groupBox_harmonica3.Size = new System.Drawing.Size(201, 57);
			this.groupBox_harmonica3.TabIndex = 11;
			this.groupBox_harmonica3.TabStop = false;
			this.groupBox_harmonica3.Text = "Гармоника 3";
			// 
			// numericUpDown_phase3
			// 
			this.numericUpDown_phase3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_phase3.Location = new System.Drawing.Point(135, 32);
			this.numericUpDown_phase3.Name = "numericUpDown_phase3";
			this.numericUpDown_phase3.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_phase3.TabIndex = 2;
			this.numericUpDown_phase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label_phase3
			// 
			label_phase3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_phase3.AutoSize = true;
			label_phase3.Location = new System.Drawing.Point(135, 16);
			label_phase3.Name = "label_phase3";
			label_phase3.Size = new System.Drawing.Size(18, 13);
			label_phase3.TabIndex = 4;
			label_phase3.Text = "φ:";
			label_phase3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_frequency3
			// 
			this.numericUpDown_frequency3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_frequency3.DecimalPlaces = 3;
			this.numericUpDown_frequency3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_frequency3.Location = new System.Drawing.Point(70, 32);
			this.numericUpDown_frequency3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown_frequency3.Name = "numericUpDown_frequency3";
			this.numericUpDown_frequency3.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_frequency3.TabIndex = 2;
			this.numericUpDown_frequency3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_frequency3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label_frequency3
			// 
			label_frequency3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_frequency3.AutoSize = true;
			label_frequency3.Location = new System.Drawing.Point(71, 16);
			label_frequency3.Name = "label_frequency3";
			label_frequency3.Size = new System.Drawing.Size(13, 13);
			label_frequency3.TabIndex = 4;
			label_frequency3.Text = "f:";
			label_frequency3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_amplitude3
			// 
			this.numericUpDown_amplitude3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_amplitude3.Location = new System.Drawing.Point(5, 32);
			this.numericUpDown_amplitude3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.numericUpDown_amplitude3.Name = "numericUpDown_amplitude3";
			this.numericUpDown_amplitude3.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_amplitude3.TabIndex = 2;
			this.numericUpDown_amplitude3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_amplitude3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label_amplitude3
			// 
			label_amplitude3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_amplitude3.AutoSize = true;
			label_amplitude3.Location = new System.Drawing.Point(5, 16);
			label_amplitude3.Name = "label_amplitude3";
			label_amplitude3.Size = new System.Drawing.Size(17, 13);
			label_amplitude3.TabIndex = 3;
			label_amplitude3.Text = "A:";
			label_amplitude3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox_harmonica2
			// 
			this.groupBox_harmonica2.Controls.Add(this.numericUpDown_phase2);
			this.groupBox_harmonica2.Controls.Add(label_phase2);
			this.groupBox_harmonica2.Controls.Add(this.numericUpDown_frequency2);
			this.groupBox_harmonica2.Controls.Add(label_frequency2);
			this.groupBox_harmonica2.Controls.Add(this.numericUpDown_amplitude2);
			this.groupBox_harmonica2.Controls.Add(label_amplitude2);
			this.groupBox_harmonica2.Enabled = false;
			this.groupBox_harmonica2.Location = new System.Drawing.Point(6, 69);
			this.groupBox_harmonica2.Name = "groupBox_harmonica2";
			this.groupBox_harmonica2.Size = new System.Drawing.Size(201, 57);
			this.groupBox_harmonica2.TabIndex = 10;
			this.groupBox_harmonica2.TabStop = false;
			this.groupBox_harmonica2.Text = "Гармоника 2";
			// 
			// numericUpDown_phase2
			// 
			this.numericUpDown_phase2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_phase2.Location = new System.Drawing.Point(135, 32);
			this.numericUpDown_phase2.Name = "numericUpDown_phase2";
			this.numericUpDown_phase2.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_phase2.TabIndex = 2;
			this.numericUpDown_phase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label_phase2
			// 
			label_phase2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_phase2.AutoSize = true;
			label_phase2.Location = new System.Drawing.Point(135, 16);
			label_phase2.Name = "label_phase2";
			label_phase2.Size = new System.Drawing.Size(18, 13);
			label_phase2.TabIndex = 4;
			label_phase2.Text = "φ:";
			label_phase2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_frequency2
			// 
			this.numericUpDown_frequency2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_frequency2.DecimalPlaces = 3;
			this.numericUpDown_frequency2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_frequency2.Location = new System.Drawing.Point(70, 32);
			this.numericUpDown_frequency2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown_frequency2.Name = "numericUpDown_frequency2";
			this.numericUpDown_frequency2.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_frequency2.TabIndex = 2;
			this.numericUpDown_frequency2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_frequency2.Value = new decimal(new int[] {
            250,
            0,
            0,
            196608});
			// 
			// label_frequency2
			// 
			label_frequency2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_frequency2.AutoSize = true;
			label_frequency2.Location = new System.Drawing.Point(69, 16);
			label_frequency2.Name = "label_frequency2";
			label_frequency2.Size = new System.Drawing.Size(13, 13);
			label_frequency2.TabIndex = 4;
			label_frequency2.Text = "f:";
			label_frequency2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_amplitude2
			// 
			this.numericUpDown_amplitude2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_amplitude2.Location = new System.Drawing.Point(5, 32);
			this.numericUpDown_amplitude2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.numericUpDown_amplitude2.Name = "numericUpDown_amplitude2";
			this.numericUpDown_amplitude2.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_amplitude2.TabIndex = 2;
			this.numericUpDown_amplitude2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_amplitude2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// label_amplitude2
			// 
			label_amplitude2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_amplitude2.AutoSize = true;
			label_amplitude2.Location = new System.Drawing.Point(5, 16);
			label_amplitude2.Name = "label_amplitude2";
			label_amplitude2.Size = new System.Drawing.Size(17, 13);
			label_amplitude2.TabIndex = 3;
			label_amplitude2.Text = "A:";
			label_amplitude2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox_harmonica1
			// 
			this.groupBox_harmonica1.Controls.Add(this.numericUpDown_phase1);
			this.groupBox_harmonica1.Controls.Add(label_phase1);
			this.groupBox_harmonica1.Controls.Add(this.numericUpDown_frequency1);
			this.groupBox_harmonica1.Controls.Add(label_frequency1);
			this.groupBox_harmonica1.Controls.Add(this.numericUpDown_amplitude1);
			this.groupBox_harmonica1.Controls.Add(label_amplitude1);
			this.groupBox_harmonica1.Location = new System.Drawing.Point(6, 132);
			this.groupBox_harmonica1.Name = "groupBox_harmonica1";
			this.groupBox_harmonica1.Size = new System.Drawing.Size(201, 57);
			this.groupBox_harmonica1.TabIndex = 9;
			this.groupBox_harmonica1.TabStop = false;
			this.groupBox_harmonica1.Text = "Гармоника 1";
			// 
			// numericUpDown_phase1
			// 
			this.numericUpDown_phase1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_phase1.Location = new System.Drawing.Point(135, 32);
			this.numericUpDown_phase1.Name = "numericUpDown_phase1";
			this.numericUpDown_phase1.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_phase1.TabIndex = 2;
			this.numericUpDown_phase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label_phase1
			// 
			label_phase1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_phase1.AutoSize = true;
			label_phase1.Location = new System.Drawing.Point(135, 16);
			label_phase1.Name = "label_phase1";
			label_phase1.Size = new System.Drawing.Size(18, 13);
			label_phase1.TabIndex = 4;
			label_phase1.Text = "φ:";
			label_phase1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_frequency1
			// 
			this.numericUpDown_frequency1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_frequency1.DecimalPlaces = 3;
			this.numericUpDown_frequency1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_frequency1.Location = new System.Drawing.Point(70, 32);
			this.numericUpDown_frequency1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown_frequency1.Name = "numericUpDown_frequency1";
			this.numericUpDown_frequency1.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_frequency1.TabIndex = 2;
			this.numericUpDown_frequency1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_frequency1.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			// 
			// label_frequency1
			// 
			label_frequency1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_frequency1.AutoSize = true;
			label_frequency1.Location = new System.Drawing.Point(69, 16);
			label_frequency1.Name = "label_frequency1";
			label_frequency1.Size = new System.Drawing.Size(13, 13);
			label_frequency1.TabIndex = 4;
			label_frequency1.Text = "f:";
			label_frequency1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_amplitude1
			// 
			this.numericUpDown_amplitude1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_amplitude1.Location = new System.Drawing.Point(5, 32);
			this.numericUpDown_amplitude1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.numericUpDown_amplitude1.Name = "numericUpDown_amplitude1";
			this.numericUpDown_amplitude1.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_amplitude1.TabIndex = 2;
			this.numericUpDown_amplitude1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_amplitude1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label_amplitude1
			// 
			label_amplitude1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_amplitude1.AutoSize = true;
			label_amplitude1.Location = new System.Drawing.Point(5, 16);
			label_amplitude1.Name = "label_amplitude1";
			label_amplitude1.Size = new System.Drawing.Size(17, 13);
			label_amplitude1.TabIndex = 3;
			label_amplitude1.Text = "A:";
			label_amplitude1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPage_gauss
			// 
			this.tabPage_gauss.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage_gauss.Controls.Add(this.trackBar_gauss);
			this.tabPage_gauss.Controls.Add(this.groupBox_dome3);
			this.tabPage_gauss.Controls.Add(this.groupBox_dome2);
			this.tabPage_gauss.Controls.Add(this.groupBox_dome1);
			this.tabPage_gauss.Location = new System.Drawing.Point(4, 22);
			this.tabPage_gauss.Name = "tabPage_gauss";
			this.tabPage_gauss.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_gauss.Size = new System.Drawing.Size(267, 193);
			this.tabPage_gauss.TabIndex = 1;
			this.tabPage_gauss.Text = "Гауссов";
			// 
			// trackBar_gauss
			// 
			this.trackBar_gauss.LargeChange = 3;
			this.trackBar_gauss.Location = new System.Drawing.Point(213, 22);
			this.trackBar_gauss.Maximum = 3;
			this.trackBar_gauss.Minimum = 1;
			this.trackBar_gauss.Name = "trackBar_gauss";
			this.trackBar_gauss.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar_gauss.Size = new System.Drawing.Size(45, 151);
			this.trackBar_gauss.TabIndex = 16;
			this.trackBar_gauss.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.trackBar_gauss.Value = 1;
			this.trackBar_gauss.Scroll += new System.EventHandler(this.OnScrollTrackBarrackBarGauss);
			// 
			// groupBox_dome3
			// 
			this.groupBox_dome3.Controls.Add(this.numericUpDown_mathExpectation3);
			this.groupBox_dome3.Controls.Add(label_mathExpectation3);
			this.groupBox_dome3.Controls.Add(this.numericUpDown_sko3);
			this.groupBox_dome3.Controls.Add(label_sko3);
			this.groupBox_dome3.Controls.Add(this.numericUpDown_amplitudeGauss3);
			this.groupBox_dome3.Controls.Add(label_amplitudeGauss3);
			this.groupBox_dome3.Enabled = false;
			this.groupBox_dome3.Location = new System.Drawing.Point(6, 6);
			this.groupBox_dome3.Name = "groupBox_dome3";
			this.groupBox_dome3.Size = new System.Drawing.Size(201, 57);
			this.groupBox_dome3.TabIndex = 15;
			this.groupBox_dome3.TabStop = false;
			this.groupBox_dome3.Text = "Купол 3";
			// 
			// numericUpDown_mathExpectation3
			// 
			this.numericUpDown_mathExpectation3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_mathExpectation3.DecimalPlaces = 1;
			this.numericUpDown_mathExpectation3.Location = new System.Drawing.Point(135, 32);
			this.numericUpDown_mathExpectation3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown_mathExpectation3.Name = "numericUpDown_mathExpectation3";
			this.numericUpDown_mathExpectation3.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_mathExpectation3.TabIndex = 2;
			this.numericUpDown_mathExpectation3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_mathExpectation3.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
			// 
			// label_mathExpectation3
			// 
			label_mathExpectation3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_mathExpectation3.AutoSize = true;
			label_mathExpectation3.Location = new System.Drawing.Point(135, 16);
			label_mathExpectation3.Name = "label_mathExpectation3";
			label_mathExpectation3.Size = new System.Drawing.Size(16, 13);
			label_mathExpectation3.TabIndex = 4;
			label_mathExpectation3.Text = "μ:";
			label_mathExpectation3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_sko3
			// 
			this.numericUpDown_sko3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_sko3.DecimalPlaces = 3;
			this.numericUpDown_sko3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown_sko3.Location = new System.Drawing.Point(70, 32);
			this.numericUpDown_sko3.Name = "numericUpDown_sko3";
			this.numericUpDown_sko3.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_sko3.TabIndex = 2;
			this.numericUpDown_sko3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_sko3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// label_sko3
			// 
			label_sko3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_sko3.AutoSize = true;
			label_sko3.Location = new System.Drawing.Point(71, 16);
			label_sko3.Name = "label_sko3";
			label_sko3.Size = new System.Drawing.Size(17, 13);
			label_sko3.TabIndex = 4;
			label_sko3.Text = "σ:";
			label_sko3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_amplitudeGauss3
			// 
			this.numericUpDown_amplitudeGauss3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_amplitudeGauss3.Location = new System.Drawing.Point(5, 32);
			this.numericUpDown_amplitudeGauss3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.numericUpDown_amplitudeGauss3.Name = "numericUpDown_amplitudeGauss3";
			this.numericUpDown_amplitudeGauss3.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_amplitudeGauss3.TabIndex = 2;
			this.numericUpDown_amplitudeGauss3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_amplitudeGauss3.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label_amplitudeGauss3
			// 
			label_amplitudeGauss3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_amplitudeGauss3.AutoSize = true;
			label_amplitudeGauss3.Location = new System.Drawing.Point(5, 16);
			label_amplitudeGauss3.Name = "label_amplitudeGauss3";
			label_amplitudeGauss3.Size = new System.Drawing.Size(17, 13);
			label_amplitudeGauss3.TabIndex = 3;
			label_amplitudeGauss3.Text = "A:";
			label_amplitudeGauss3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox_dome2
			// 
			this.groupBox_dome2.Controls.Add(this.numericUpDown_mathExpectation2);
			this.groupBox_dome2.Controls.Add(label_mathExpectation2);
			this.groupBox_dome2.Controls.Add(this.numericUpDown_sko2);
			this.groupBox_dome2.Controls.Add(label_sko2);
			this.groupBox_dome2.Controls.Add(this.numericUpDown_amplitudeGauss2);
			this.groupBox_dome2.Controls.Add(label_amplitudeGauss2);
			this.groupBox_dome2.Enabled = false;
			this.groupBox_dome2.Location = new System.Drawing.Point(6, 69);
			this.groupBox_dome2.Name = "groupBox_dome2";
			this.groupBox_dome2.Size = new System.Drawing.Size(201, 57);
			this.groupBox_dome2.TabIndex = 14;
			this.groupBox_dome2.TabStop = false;
			this.groupBox_dome2.Text = "Купол 2";
			// 
			// numericUpDown_mathExpectation2
			// 
			this.numericUpDown_mathExpectation2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_mathExpectation2.DecimalPlaces = 1;
			this.numericUpDown_mathExpectation2.Location = new System.Drawing.Point(135, 32);
			this.numericUpDown_mathExpectation2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown_mathExpectation2.Name = "numericUpDown_mathExpectation2";
			this.numericUpDown_mathExpectation2.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_mathExpectation2.TabIndex = 2;
			this.numericUpDown_mathExpectation2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_mathExpectation2.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
			// 
			// label_mathExpectation2
			// 
			label_mathExpectation2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_mathExpectation2.AutoSize = true;
			label_mathExpectation2.Location = new System.Drawing.Point(135, 16);
			label_mathExpectation2.Name = "label_mathExpectation2";
			label_mathExpectation2.Size = new System.Drawing.Size(16, 13);
			label_mathExpectation2.TabIndex = 4;
			label_mathExpectation2.Text = "μ:";
			label_mathExpectation2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_sko2
			// 
			this.numericUpDown_sko2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_sko2.DecimalPlaces = 3;
			this.numericUpDown_sko2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown_sko2.Location = new System.Drawing.Point(70, 32);
			this.numericUpDown_sko2.Name = "numericUpDown_sko2";
			this.numericUpDown_sko2.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_sko2.TabIndex = 2;
			this.numericUpDown_sko2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_sko2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// label_sko2
			// 
			label_sko2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_sko2.AutoSize = true;
			label_sko2.Location = new System.Drawing.Point(69, 16);
			label_sko2.Name = "label_sko2";
			label_sko2.Size = new System.Drawing.Size(17, 13);
			label_sko2.TabIndex = 4;
			label_sko2.Text = "σ:";
			label_sko2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_amplitudeGauss2
			// 
			this.numericUpDown_amplitudeGauss2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_amplitudeGauss2.Location = new System.Drawing.Point(5, 32);
			this.numericUpDown_amplitudeGauss2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.numericUpDown_amplitudeGauss2.Name = "numericUpDown_amplitudeGauss2";
			this.numericUpDown_amplitudeGauss2.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_amplitudeGauss2.TabIndex = 2;
			this.numericUpDown_amplitudeGauss2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_amplitudeGauss2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// label_amplitudeGauss2
			// 
			label_amplitudeGauss2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_amplitudeGauss2.AutoSize = true;
			label_amplitudeGauss2.Location = new System.Drawing.Point(5, 16);
			label_amplitudeGauss2.Name = "label_amplitudeGauss2";
			label_amplitudeGauss2.Size = new System.Drawing.Size(17, 13);
			label_amplitudeGauss2.TabIndex = 3;
			label_amplitudeGauss2.Text = "A:";
			label_amplitudeGauss2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox_dome1
			// 
			this.groupBox_dome1.Controls.Add(this.numericUpDown_mathExpectation1);
			this.groupBox_dome1.Controls.Add(label_mathExpectation1);
			this.groupBox_dome1.Controls.Add(this.numericUpDown_sko1);
			this.groupBox_dome1.Controls.Add(label_sko1);
			this.groupBox_dome1.Controls.Add(this.numericUpDown_amplitudeGauss1);
			this.groupBox_dome1.Controls.Add(label_amplitudeGauss1);
			this.groupBox_dome1.Location = new System.Drawing.Point(6, 132);
			this.groupBox_dome1.Name = "groupBox_dome1";
			this.groupBox_dome1.Size = new System.Drawing.Size(201, 57);
			this.groupBox_dome1.TabIndex = 13;
			this.groupBox_dome1.TabStop = false;
			this.groupBox_dome1.Text = "Купол 1";
			// 
			// numericUpDown_mathExpectation1
			// 
			this.numericUpDown_mathExpectation1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_mathExpectation1.DecimalPlaces = 1;
			this.numericUpDown_mathExpectation1.Location = new System.Drawing.Point(135, 32);
			this.numericUpDown_mathExpectation1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown_mathExpectation1.Name = "numericUpDown_mathExpectation1";
			this.numericUpDown_mathExpectation1.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_mathExpectation1.TabIndex = 2;
			this.numericUpDown_mathExpectation1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_mathExpectation1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// label_mathExpectation1
			// 
			label_mathExpectation1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_mathExpectation1.AutoSize = true;
			label_mathExpectation1.Location = new System.Drawing.Point(135, 16);
			label_mathExpectation1.Name = "label_mathExpectation1";
			label_mathExpectation1.Size = new System.Drawing.Size(16, 13);
			label_mathExpectation1.TabIndex = 4;
			label_mathExpectation1.Text = "μ:";
			label_mathExpectation1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_sko1
			// 
			this.numericUpDown_sko1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_sko1.DecimalPlaces = 3;
			this.numericUpDown_sko1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown_sko1.Location = new System.Drawing.Point(70, 32);
			this.numericUpDown_sko1.Name = "numericUpDown_sko1";
			this.numericUpDown_sko1.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_sko1.TabIndex = 2;
			this.numericUpDown_sko1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_sko1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label_sko1
			// 
			label_sko1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_sko1.AutoSize = true;
			label_sko1.Location = new System.Drawing.Point(69, 16);
			label_sko1.Name = "label_sko1";
			label_sko1.Size = new System.Drawing.Size(17, 13);
			label_sko1.TabIndex = 4;
			label_sko1.Text = "σ:";
			label_sko1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_amplitudeGauss1
			// 
			this.numericUpDown_amplitudeGauss1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_amplitudeGauss1.Location = new System.Drawing.Point(5, 32);
			this.numericUpDown_amplitudeGauss1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.numericUpDown_amplitudeGauss1.Name = "numericUpDown_amplitudeGauss1";
			this.numericUpDown_amplitudeGauss1.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_amplitudeGauss1.TabIndex = 2;
			this.numericUpDown_amplitudeGauss1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_amplitudeGauss1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label_amplitudeGauss1
			// 
			label_amplitudeGauss1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_amplitudeGauss1.AutoSize = true;
			label_amplitudeGauss1.Location = new System.Drawing.Point(5, 16);
			label_amplitudeGauss1.Name = "label_amplitudeGauss1";
			label_amplitudeGauss1.Size = new System.Drawing.Size(17, 13);
			label_amplitudeGauss1.TabIndex = 3;
			label_amplitudeGauss1.Text = "A:";
			label_amplitudeGauss1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPage_expDecaying
			// 
			this.tabPage_expDecaying.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage_expDecaying.Controls.Add(this.trackBar_expDecaying);
			this.tabPage_expDecaying.Controls.Add(this.groupBox_сomponent3);
			this.tabPage_expDecaying.Controls.Add(this.groupBox_сomponent2);
			this.tabPage_expDecaying.Controls.Add(this.groupBox_сomponent1);
			this.tabPage_expDecaying.Location = new System.Drawing.Point(4, 22);
			this.tabPage_expDecaying.Name = "tabPage_expDecaying";
			this.tabPage_expDecaying.Size = new System.Drawing.Size(267, 193);
			this.tabPage_expDecaying.TabIndex = 2;
			this.tabPage_expDecaying.Text = "Экспоненциально-затухающий";
			// 
			// trackBar_expDecaying
			// 
			this.trackBar_expDecaying.LargeChange = 3;
			this.trackBar_expDecaying.Location = new System.Drawing.Point(213, 22);
			this.trackBar_expDecaying.Maximum = 3;
			this.trackBar_expDecaying.Minimum = 1;
			this.trackBar_expDecaying.Name = "trackBar_expDecaying";
			this.trackBar_expDecaying.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar_expDecaying.Size = new System.Drawing.Size(45, 151);
			this.trackBar_expDecaying.TabIndex = 16;
			this.trackBar_expDecaying.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.trackBar_expDecaying.Value = 1;
			this.trackBar_expDecaying.Scroll += new System.EventHandler(this.OnScrollTrackBarrackBarExpDecaying);
			// 
			// groupBox_сomponent3
			// 
			this.groupBox_сomponent3.Controls.Add(this.numericUpDown_phaseED3);
			this.groupBox_сomponent3.Controls.Add(label_phaseED3);
			this.groupBox_сomponent3.Controls.Add(this.numericUpDown_frequencyED3);
			this.groupBox_сomponent3.Controls.Add(label_frequencyED3);
			this.groupBox_сomponent3.Controls.Add(this.numericUpDown_attenuation3);
			this.groupBox_сomponent3.Controls.Add(label_attenuation3);
			this.groupBox_сomponent3.Enabled = false;
			this.groupBox_сomponent3.Location = new System.Drawing.Point(6, 6);
			this.groupBox_сomponent3.Name = "groupBox_сomponent3";
			this.groupBox_сomponent3.Size = new System.Drawing.Size(201, 57);
			this.groupBox_сomponent3.TabIndex = 15;
			this.groupBox_сomponent3.TabStop = false;
			this.groupBox_сomponent3.Text = "Составляющая 3";
			// 
			// numericUpDown_phaseED3
			// 
			this.numericUpDown_phaseED3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_phaseED3.Location = new System.Drawing.Point(135, 32);
			this.numericUpDown_phaseED3.Name = "numericUpDown_phaseED3";
			this.numericUpDown_phaseED3.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_phaseED3.TabIndex = 2;
			this.numericUpDown_phaseED3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label_phaseED3
			// 
			label_phaseED3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_phaseED3.AutoSize = true;
			label_phaseED3.Location = new System.Drawing.Point(135, 16);
			label_phaseED3.Name = "label_phaseED3";
			label_phaseED3.Size = new System.Drawing.Size(18, 13);
			label_phaseED3.TabIndex = 4;
			label_phaseED3.Text = "φ:";
			label_phaseED3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_frequencyED3
			// 
			this.numericUpDown_frequencyED3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_frequencyED3.DecimalPlaces = 3;
			this.numericUpDown_frequencyED3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown_frequencyED3.Location = new System.Drawing.Point(70, 32);
			this.numericUpDown_frequencyED3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown_frequencyED3.Name = "numericUpDown_frequencyED3";
			this.numericUpDown_frequencyED3.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_frequencyED3.TabIndex = 2;
			this.numericUpDown_frequencyED3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_frequencyED3.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
			// 
			// label_frequencyED3
			// 
			label_frequencyED3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_frequencyED3.AutoSize = true;
			label_frequencyED3.Location = new System.Drawing.Point(71, 16);
			label_frequencyED3.Name = "label_frequencyED3";
			label_frequencyED3.Size = new System.Drawing.Size(13, 13);
			label_frequencyED3.TabIndex = 4;
			label_frequencyED3.Text = "f:";
			label_frequencyED3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_attenuation3
			// 
			this.numericUpDown_attenuation3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_attenuation3.DecimalPlaces = 2;
			this.numericUpDown_attenuation3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_attenuation3.Location = new System.Drawing.Point(5, 32);
			this.numericUpDown_attenuation3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_attenuation3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown_attenuation3.Name = "numericUpDown_attenuation3";
			this.numericUpDown_attenuation3.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_attenuation3.TabIndex = 2;
			this.numericUpDown_attenuation3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_attenuation3.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			// 
			// label_attenuation3
			// 
			label_attenuation3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_attenuation3.AutoSize = true;
			label_attenuation3.Location = new System.Drawing.Point(5, 16);
			label_attenuation3.Name = "label_attenuation3";
			label_attenuation3.Size = new System.Drawing.Size(17, 13);
			label_attenuation3.TabIndex = 3;
			label_attenuation3.Text = "α:";
			label_attenuation3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox_сomponent2
			// 
			this.groupBox_сomponent2.Controls.Add(this.numericUpDown_phaseED2);
			this.groupBox_сomponent2.Controls.Add(label_phaseED2);
			this.groupBox_сomponent2.Controls.Add(this.numericUpDown_frequencyED2);
			this.groupBox_сomponent2.Controls.Add(label_frequencyED2);
			this.groupBox_сomponent2.Controls.Add(this.numericUpDown_attenuation2);
			this.groupBox_сomponent2.Controls.Add(label_attenuation2);
			this.groupBox_сomponent2.Enabled = false;
			this.groupBox_сomponent2.Location = new System.Drawing.Point(6, 69);
			this.groupBox_сomponent2.Name = "groupBox_сomponent2";
			this.groupBox_сomponent2.Size = new System.Drawing.Size(201, 57);
			this.groupBox_сomponent2.TabIndex = 14;
			this.groupBox_сomponent2.TabStop = false;
			this.groupBox_сomponent2.Text = "Составляющая 2";
			// 
			// numericUpDown_phaseED2
			// 
			this.numericUpDown_phaseED2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_phaseED2.Location = new System.Drawing.Point(135, 32);
			this.numericUpDown_phaseED2.Name = "numericUpDown_phaseED2";
			this.numericUpDown_phaseED2.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_phaseED2.TabIndex = 2;
			this.numericUpDown_phaseED2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label_phaseED2
			// 
			label_phaseED2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_phaseED2.AutoSize = true;
			label_phaseED2.Location = new System.Drawing.Point(135, 16);
			label_phaseED2.Name = "label_phaseED2";
			label_phaseED2.Size = new System.Drawing.Size(18, 13);
			label_phaseED2.TabIndex = 4;
			label_phaseED2.Text = "φ:";
			label_phaseED2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_frequencyED2
			// 
			this.numericUpDown_frequencyED2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_frequencyED2.DecimalPlaces = 3;
			this.numericUpDown_frequencyED2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown_frequencyED2.Location = new System.Drawing.Point(70, 32);
			this.numericUpDown_frequencyED2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown_frequencyED2.Name = "numericUpDown_frequencyED2";
			this.numericUpDown_frequencyED2.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_frequencyED2.TabIndex = 2;
			this.numericUpDown_frequencyED2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_frequencyED2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label_frequencyED2
			// 
			label_frequencyED2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_frequencyED2.AutoSize = true;
			label_frequencyED2.Location = new System.Drawing.Point(69, 16);
			label_frequencyED2.Name = "label_frequencyED2";
			label_frequencyED2.Size = new System.Drawing.Size(13, 13);
			label_frequencyED2.TabIndex = 4;
			label_frequencyED2.Text = "f:";
			label_frequencyED2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_attenuation2
			// 
			this.numericUpDown_attenuation2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_attenuation2.DecimalPlaces = 2;
			this.numericUpDown_attenuation2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_attenuation2.Location = new System.Drawing.Point(5, 32);
			this.numericUpDown_attenuation2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_attenuation2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown_attenuation2.Name = "numericUpDown_attenuation2";
			this.numericUpDown_attenuation2.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_attenuation2.TabIndex = 2;
			this.numericUpDown_attenuation2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_attenuation2.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
			// 
			// label_attenuation2
			// 
			label_attenuation2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_attenuation2.AutoSize = true;
			label_attenuation2.Location = new System.Drawing.Point(5, 16);
			label_attenuation2.Name = "label_attenuation2";
			label_attenuation2.Size = new System.Drawing.Size(17, 13);
			label_attenuation2.TabIndex = 3;
			label_attenuation2.Text = "α:";
			label_attenuation2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox_сomponent1
			// 
			this.groupBox_сomponent1.Controls.Add(this.numericUpDown_phaseED1);
			this.groupBox_сomponent1.Controls.Add(label_phaseED1);
			this.groupBox_сomponent1.Controls.Add(this.numericUpDown_frequencyED1);
			this.groupBox_сomponent1.Controls.Add(labelfrequencyED1);
			this.groupBox_сomponent1.Controls.Add(this.numericUpDown_attenuation1);
			this.groupBox_сomponent1.Controls.Add(label_attenuation1);
			this.groupBox_сomponent1.Location = new System.Drawing.Point(6, 132);
			this.groupBox_сomponent1.Name = "groupBox_сomponent1";
			this.groupBox_сomponent1.Size = new System.Drawing.Size(201, 57);
			this.groupBox_сomponent1.TabIndex = 13;
			this.groupBox_сomponent1.TabStop = false;
			this.groupBox_сomponent1.Text = "Составляющая 1";
			// 
			// numericUpDown_phaseED1
			// 
			this.numericUpDown_phaseED1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_phaseED1.Location = new System.Drawing.Point(135, 32);
			this.numericUpDown_phaseED1.Name = "numericUpDown_phaseED1";
			this.numericUpDown_phaseED1.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_phaseED1.TabIndex = 2;
			this.numericUpDown_phaseED1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label_phaseED1
			// 
			label_phaseED1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_phaseED1.AutoSize = true;
			label_phaseED1.Location = new System.Drawing.Point(135, 16);
			label_phaseED1.Name = "label_phaseED1";
			label_phaseED1.Size = new System.Drawing.Size(18, 13);
			label_phaseED1.TabIndex = 4;
			label_phaseED1.Text = "φ:";
			label_phaseED1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_frequencyED1
			// 
			this.numericUpDown_frequencyED1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_frequencyED1.DecimalPlaces = 3;
			this.numericUpDown_frequencyED1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown_frequencyED1.Location = new System.Drawing.Point(70, 32);
			this.numericUpDown_frequencyED1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown_frequencyED1.Name = "numericUpDown_frequencyED1";
			this.numericUpDown_frequencyED1.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_frequencyED1.TabIndex = 2;
			this.numericUpDown_frequencyED1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_frequencyED1.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			// 
			// labelfrequencyED1
			// 
			labelfrequencyED1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			labelfrequencyED1.AutoSize = true;
			labelfrequencyED1.Location = new System.Drawing.Point(69, 16);
			labelfrequencyED1.Name = "labelfrequencyED1";
			labelfrequencyED1.Size = new System.Drawing.Size(13, 13);
			labelfrequencyED1.TabIndex = 4;
			labelfrequencyED1.Text = "f:";
			labelfrequencyED1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_attenuation1
			// 
			this.numericUpDown_attenuation1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDown_attenuation1.DecimalPlaces = 2;
			this.numericUpDown_attenuation1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_attenuation1.Location = new System.Drawing.Point(5, 32);
			this.numericUpDown_attenuation1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_attenuation1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown_attenuation1.Name = "numericUpDown_attenuation1";
			this.numericUpDown_attenuation1.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_attenuation1.TabIndex = 2;
			this.numericUpDown_attenuation1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_attenuation1.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			// 
			// label_attenuation1
			// 
			label_attenuation1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			label_attenuation1.AutoSize = true;
			label_attenuation1.Location = new System.Drawing.Point(5, 16);
			label_attenuation1.Name = "label_attenuation1";
			label_attenuation1.Size = new System.Drawing.Size(17, 13);
			label_attenuation1.TabIndex = 3;
			label_attenuation1.Text = "α:";
			label_attenuation1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// buttonGenerateSgnl
			// 
			this.buttonGenerateSgnl.Location = new System.Drawing.Point(6, 312);
			this.buttonGenerateSgnl.Name = "buttonGenerateSgnl";
			this.buttonGenerateSgnl.Size = new System.Drawing.Size(275, 25);
			this.buttonGenerateSgnl.TabIndex = 1;
			this.buttonGenerateSgnl.Text = "Сгенерировать сигнал";
			this.buttonGenerateSgnl.UseVisualStyleBackColor = true;
			this.buttonGenerateSgnl.Click += new System.EventHandler(this.OnClickButtonGenerateSgnl);
			// 
			// groupBox_graphInitSgnl
			// 
			groupBox_graphInitSgnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			groupBox_graphInitSgnl.Controls.Add(this.chart_initSgnl);
			groupBox_graphInitSgnl.Location = new System.Drawing.Point(305, 12);
			groupBox_graphInitSgnl.Name = "groupBox_graphInitSgnl";
			groupBox_graphInitSgnl.Size = new System.Drawing.Size(764, 238);
			groupBox_graphInitSgnl.TabIndex = 8;
			groupBox_graphInitSgnl.TabStop = false;
			groupBox_graphInitSgnl.Text = "График исходного сигнала";
			// 
			// chart_initSgnl
			// 
			this.chart_initSgnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
			chartArea1.AxisX.Interval = 10D;
			chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea1.AxisX.MajorTickMark.Enabled = false;
			chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
			chartArea1.AxisX.Minimum = 0D;
			chartArea1.AxisX.MinorGrid.Enabled = true;
			chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea1.AxisY.MajorTickMark.Enabled = false;
			chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
			chartArea1.Name = "ChartArea1";
			this.chart_initSgnl.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
			legend1.DockedToChartArea = "ChartArea1";
			legend1.IsTextAutoFit = false;
			legend1.Name = "Legend1";
			legend1.TitleBackColor = System.Drawing.Color.White;
			this.chart_initSgnl.Legends.Add(legend1);
			this.chart_initSgnl.Location = new System.Drawing.Point(10, 19);
			this.chart_initSgnl.Name = "chart_initSgnl";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Color = System.Drawing.Color.Blue;
			series1.Legend = "Legend1";
			series1.Name = "Исходный сигнал";
			this.chart_initSgnl.Series.Add(series1);
			this.chart_initSgnl.Size = new System.Drawing.Size(748, 213);
			this.chart_initSgnl.TabIndex = 2;
			this.chart_initSgnl.Text = "chart_initSgnl";
			// 
			// groupBox_graphSVD
			// 
			groupBox_graphSVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			groupBox_graphSVD.Controls.Add(this.chart_graphSVD);
			groupBox_graphSVD.Location = new System.Drawing.Point(305, 256);
			groupBox_graphSVD.Name = "groupBox_graphSVD";
			groupBox_graphSVD.Size = new System.Drawing.Size(764, 238);
			groupBox_graphSVD.TabIndex = 10;
			groupBox_graphSVD.TabStop = false;
			groupBox_graphSVD.Text = "График сингулярного разложения АКМ сигнала";
			// 
			// chart_graphSVD
			// 
			this.chart_graphSVD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea2.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
			chartArea2.AxisX.Interval = 10D;
			chartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea2.AxisX.MajorTickMark.Enabled = false;
			chartArea2.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
			chartArea2.AxisX.Minimum = 0D;
			chartArea2.AxisX.MinorGrid.Enabled = true;
			chartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea2.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea2.AxisY.MajorTickMark.Enabled = false;
			chartArea2.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
			chartArea2.Name = "ChartArea1";
			this.chart_graphSVD.ChartAreas.Add(chartArea2);
			legend2.BackColor = System.Drawing.Color.Transparent;
			legend2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
			legend2.DockedToChartArea = "ChartArea1";
			legend2.IsTextAutoFit = false;
			legend2.Name = "Legend1";
			legend2.TitleBackColor = System.Drawing.Color.White;
			this.chart_graphSVD.Legends.Add(legend2);
			this.chart_graphSVD.Location = new System.Drawing.Point(10, 19);
			this.chart_graphSVD.Name = "chart_graphSVD";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Color = System.Drawing.Color.SeaGreen;
			series2.Legend = "Legend1";
			series2.Name = "SVD разложение АКМ сигнала";
			this.chart_graphSVD.Series.Add(series2);
			this.chart_graphSVD.Size = new System.Drawing.Size(748, 213);
			this.chart_graphSVD.TabIndex = 2;
			this.chart_graphSVD.Text = "chart1";
			// 
			// labelDiscrepancy
			// 
			labelDiscrepancy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			labelDiscrepancy.AutoSize = true;
			labelDiscrepancy.Location = new System.Drawing.Point(48, 323);
			labelDiscrepancy.Name = "labelDiscrepancy";
			labelDiscrepancy.Size = new System.Drawing.Size(102, 13);
			labelDiscrepancy.TabIndex = 11;
			labelDiscrepancy.Text = "Невязка системы:";
			// 
			// label_N
			// 
			label_N.AutoSize = true;
			label_N.Location = new System.Drawing.Point(115, 21);
			label_N.Name = "label_N";
			label_N.Size = new System.Drawing.Size(18, 13);
			label_N.TabIndex = 0;
			label_N.Text = "N:";
			// 
			// label_M
			// 
			label_M.AutoSize = true;
			label_M.Location = new System.Drawing.Point(13, 21);
			label_M.Name = "label_M";
			label_M.Size = new System.Drawing.Size(19, 13);
			label_M.TabIndex = 2;
			label_M.Text = "M:";
			// 
			// groupBox_eigenvector
			// 
			groupBox_eigenvector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			groupBox_eigenvector.Controls.Add(this.chart_eigenvector);
			groupBox_eigenvector.Location = new System.Drawing.Point(305, 500);
			groupBox_eigenvector.Name = "groupBox_eigenvector";
			groupBox_eigenvector.Size = new System.Drawing.Size(764, 238);
			groupBox_eigenvector.TabIndex = 11;
			groupBox_eigenvector.TabStop = false;
			groupBox_eigenvector.Text = "График левого и правого собственного вектора";
			// 
			// chart_eigenvector
			// 
			this.chart_eigenvector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea3.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
			chartArea3.AxisX.Interval = 10D;
			chartArea3.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea3.AxisX.MajorTickMark.Enabled = false;
			chartArea3.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
			chartArea3.AxisX.Minimum = 0D;
			chartArea3.AxisX.MinorGrid.Enabled = true;
			chartArea3.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea3.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea3.AxisY.MajorTickMark.Enabled = false;
			chartArea3.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
			chartArea3.Name = "ChartArea1";
			this.chart_eigenvector.ChartAreas.Add(chartArea3);
			legend3.BackColor = System.Drawing.Color.Transparent;
			legend3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
			legend3.DockedToChartArea = "ChartArea1";
			legend3.IsTextAutoFit = false;
			legend3.Name = "Legend1";
			legend3.TitleBackColor = System.Drawing.Color.White;
			this.chart_eigenvector.Legends.Add(legend3);
			this.chart_eigenvector.Location = new System.Drawing.Point(10, 19);
			this.chart_eigenvector.Name = "chart_eigenvector";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series3.Color = System.Drawing.Color.Red;
			series3.Legend = "Legend1";
			series3.Name = "Левый собственный вектор";
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series4.Color = System.Drawing.Color.Blue;
			series4.Legend = "Legend1";
			series4.Name = "Правый собственный вектор";
			this.chart_eigenvector.Series.Add(series3);
			this.chart_eigenvector.Series.Add(series4);
			this.chart_eigenvector.Size = new System.Drawing.Size(748, 213);
			this.chart_eigenvector.TabIndex = 2;
			this.chart_eigenvector.Text = "chart1";
			// 
			// label_max
			// 
			label_max.AutoSize = true;
			label_max.Location = new System.Drawing.Point(104, 47);
			label_max.Name = "label_max";
			label_max.Size = new System.Drawing.Size(29, 13);
			label_max.TabIndex = 4;
			label_max.Text = "max:";
			// 
			// label_min
			// 
			label_min.AutoSize = true;
			label_min.Location = new System.Drawing.Point(6, 47);
			label_min.Name = "label_min";
			label_min.Size = new System.Drawing.Size(26, 13);
			label_min.TabIndex = 6;
			label_min.Text = "min:";
			// 
			// groupBox_sleParams
			// 
			this.groupBox_sleParams.Controls.Add(this.richTextBoxResultSLE);
			this.groupBox_sleParams.Controls.Add(this.textBoxDiscrepancy);
			this.groupBox_sleParams.Controls.Add(labelDiscrepancy);
			this.groupBox_sleParams.Controls.Add(this.buttonSolveSLE);
			this.groupBox_sleParams.Controls.Add(this.groupBox_sizeSLE);
			this.groupBox_sleParams.Location = new System.Drawing.Point(12, 361);
			this.groupBox_sleParams.Name = "groupBox_sleParams";
			this.groupBox_sleParams.Size = new System.Drawing.Size(287, 377);
			this.groupBox_sleParams.TabIndex = 9;
			this.groupBox_sleParams.TabStop = false;
			this.groupBox_sleParams.Text = "Решение СЛУ с помощью матрицы Мура-Пенроуза:";
			// 
			// richTextBoxResultSLE
			// 
			this.richTextBoxResultSLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxResultSLE.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBoxResultSLE.Location = new System.Drawing.Point(6, 108);
			this.richTextBoxResultSLE.Name = "richTextBoxResultSLE";
			this.richTextBoxResultSLE.ReadOnly = true;
			this.richTextBoxResultSLE.Size = new System.Drawing.Size(275, 206);
			this.richTextBoxResultSLE.TabIndex = 12;
			this.richTextBoxResultSLE.Text = "";
			this.richTextBoxResultSLE.WordWrap = false;
			// 
			// textBoxDiscrepancy
			// 
			this.textBoxDiscrepancy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDiscrepancy.Location = new System.Drawing.Point(156, 320);
			this.textBoxDiscrepancy.Name = "textBoxDiscrepancy";
			this.textBoxDiscrepancy.ReadOnly = true;
			this.textBoxDiscrepancy.Size = new System.Drawing.Size(125, 20);
			this.textBoxDiscrepancy.TabIndex = 11;
			// 
			// buttonSolveSLE
			// 
			this.buttonSolveSLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSolveSLE.Location = new System.Drawing.Point(6, 346);
			this.buttonSolveSLE.Name = "buttonSolveSLE";
			this.buttonSolveSLE.Size = new System.Drawing.Size(275, 25);
			this.buttonSolveSLE.TabIndex = 5;
			this.buttonSolveSLE.Text = "Решить СЛУ";
			this.buttonSolveSLE.UseVisualStyleBackColor = true;
			this.buttonSolveSLE.Click += new System.EventHandler(this.OnClickButtonSolveSLE);
			// 
			// groupBox_sizeSLE
			// 
			this.groupBox_sizeSLE.Controls.Add(label_max);
			this.groupBox_sizeSLE.Controls.Add(this.numericUpDown_max);
			this.groupBox_sizeSLE.Controls.Add(label_min);
			this.groupBox_sizeSLE.Controls.Add(this.numericUpDown_min);
			this.groupBox_sizeSLE.Controls.Add(label_N);
			this.groupBox_sizeSLE.Controls.Add(this.numericUpDown_N);
			this.groupBox_sizeSLE.Controls.Add(label_M);
			this.groupBox_sizeSLE.Controls.Add(this.numericUpDown_M);
			this.groupBox_sizeSLE.Location = new System.Drawing.Point(6, 19);
			this.groupBox_sizeSLE.Name = "groupBox_sizeSLE";
			this.groupBox_sizeSLE.Size = new System.Drawing.Size(275, 83);
			this.groupBox_sizeSLE.TabIndex = 4;
			this.groupBox_sizeSLE.TabStop = false;
			this.groupBox_sizeSLE.Text = "Размеры СЛУ M×N:";
			// 
			// numericUpDown_max
			// 
			this.numericUpDown_max.DecimalPlaces = 1;
			this.numericUpDown_max.Location = new System.Drawing.Point(139, 45);
			this.numericUpDown_max.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_max.Name = "numericUpDown_max";
			this.numericUpDown_max.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_max.TabIndex = 5;
			this.numericUpDown_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_max.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDown_min
			// 
			this.numericUpDown_min.DecimalPlaces = 1;
			this.numericUpDown_min.Location = new System.Drawing.Point(38, 45);
			this.numericUpDown_min.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.numericUpDown_min.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
			this.numericUpDown_min.Name = "numericUpDown_min";
			this.numericUpDown_min.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_min.TabIndex = 7;
			this.numericUpDown_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_min.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			// 
			// numericUpDown_N
			// 
			this.numericUpDown_N.Location = new System.Drawing.Point(139, 19);
			this.numericUpDown_N.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDown_N.Name = "numericUpDown_N";
			this.numericUpDown_N.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_N.TabIndex = 1;
			this.numericUpDown_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_N.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// numericUpDown_M
			// 
			this.numericUpDown_M.Location = new System.Drawing.Point(38, 19);
			this.numericUpDown_M.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDown_M.Name = "numericUpDown_M";
			this.numericUpDown_M.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown_M.TabIndex = 3;
			this.numericUpDown_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_M.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1081, 744);
			this.Controls.Add(groupBox_eigenvector);
			this.Controls.Add(groupBox_graphSVD);
			this.Controls.Add(this.groupBox_sleParams);
			this.Controls.Add(groupBox_graphInitSgnl);
			this.Controls.Add(groupBox_inputParams);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "ННГУ ИТФИ | Построение и визуализация базиса Коруена-Лоэва";
			this.Load += new System.EventHandler(this.OnLoadMainForm);
			groupBox_inputParams.ResumeLayout(false);
			groupBox_inputParams.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_eigenvectorNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_correlationOrder)).EndInit();
			this.tabControl_sgnlParam.ResumeLayout(false);
			this.tabPage_harmonic.ResumeLayout(false);
			this.tabPage_harmonic.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_harmonics)).EndInit();
			this.groupBox_harmonica3.ResumeLayout(false);
			this.groupBox_harmonica3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phase3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequency3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude3)).EndInit();
			this.groupBox_harmonica2.ResumeLayout(false);
			this.groupBox_harmonica2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phase2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequency2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude2)).EndInit();
			this.groupBox_harmonica1.ResumeLayout(false);
			this.groupBox_harmonica1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phase1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequency1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitude1)).EndInit();
			this.tabPage_gauss.ResumeLayout(false);
			this.tabPage_gauss.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_gauss)).EndInit();
			this.groupBox_dome3.ResumeLayout(false);
			this.groupBox_dome3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mathExpectation3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sko3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitudeGauss3)).EndInit();
			this.groupBox_dome2.ResumeLayout(false);
			this.groupBox_dome2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mathExpectation2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sko2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitudeGauss2)).EndInit();
			this.groupBox_dome1.ResumeLayout(false);
			this.groupBox_dome1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mathExpectation1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sko1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amplitudeGauss1)).EndInit();
			this.tabPage_expDecaying.ResumeLayout(false);
			this.tabPage_expDecaying.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_expDecaying)).EndInit();
			this.groupBox_сomponent3.ResumeLayout(false);
			this.groupBox_сomponent3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phaseED3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequencyED3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_attenuation3)).EndInit();
			this.groupBox_сomponent2.ResumeLayout(false);
			this.groupBox_сomponent2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phaseED2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequencyED2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_attenuation2)).EndInit();
			this.groupBox_сomponent1.ResumeLayout(false);
			this.groupBox_сomponent1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phaseED1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequencyED1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_attenuation1)).EndInit();
			groupBox_graphInitSgnl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart_initSgnl)).EndInit();
			groupBox_graphSVD.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart_graphSVD)).EndInit();
			groupBox_eigenvector.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart_eigenvector)).EndInit();
			this.groupBox_sleParams.ResumeLayout(false);
			this.groupBox_sleParams.PerformLayout();
			this.groupBox_sizeSLE.ResumeLayout(false);
			this.groupBox_sizeSLE.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_N)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_M)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonGenerateSgnl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_initSgnl;
        private System.Windows.Forms.TrackBar trackBar_harmonics;
        private System.Windows.Forms.GroupBox groupBox_harmonica1;
        private System.Windows.Forms.NumericUpDown numericUpDown_phase1;
        private System.Windows.Forms.NumericUpDown numericUpDown_frequency1;
        private System.Windows.Forms.NumericUpDown numericUpDown_amplitude1;
        private System.Windows.Forms.GroupBox groupBox_harmonica2;
        private System.Windows.Forms.NumericUpDown numericUpDown_phase2;
        private System.Windows.Forms.NumericUpDown numericUpDown_frequency2;
        private System.Windows.Forms.NumericUpDown numericUpDown_amplitude2;
        private System.Windows.Forms.GroupBox groupBox_harmonica3;
        private System.Windows.Forms.NumericUpDown numericUpDown_phase3;
        private System.Windows.Forms.NumericUpDown numericUpDown_frequency3;
        private System.Windows.Forms.NumericUpDown numericUpDown_amplitude3;
        private System.Windows.Forms.TabControl tabControl_sgnlParam;
        private System.Windows.Forms.TabPage tabPage_harmonic;
        private System.Windows.Forms.TabPage tabPage_gauss;
        private System.Windows.Forms.TabPage tabPage_expDecaying;
        private System.Windows.Forms.TrackBar trackBar_gauss;
        private System.Windows.Forms.GroupBox groupBox_dome3;
        private System.Windows.Forms.NumericUpDown numericUpDown_mathExpectation3;
        private System.Windows.Forms.NumericUpDown numericUpDown_sko3;
        private System.Windows.Forms.NumericUpDown numericUpDown_amplitudeGauss3;
        private System.Windows.Forms.GroupBox groupBox_dome2;
        private System.Windows.Forms.NumericUpDown numericUpDown_mathExpectation2;
        private System.Windows.Forms.NumericUpDown numericUpDown_sko2;
        private System.Windows.Forms.NumericUpDown numericUpDown_amplitudeGauss2;
        private System.Windows.Forms.GroupBox groupBox_dome1;
        private System.Windows.Forms.NumericUpDown numericUpDown_mathExpectation1;
        private System.Windows.Forms.NumericUpDown numericUpDown_sko1;
        private System.Windows.Forms.NumericUpDown numericUpDown_amplitudeGauss1;
        private System.Windows.Forms.TrackBar trackBar_expDecaying;
        private System.Windows.Forms.GroupBox groupBox_сomponent3;
        private System.Windows.Forms.NumericUpDown numericUpDown_phaseED3;
        private System.Windows.Forms.NumericUpDown numericUpDown_frequencyED3;
        private System.Windows.Forms.NumericUpDown numericUpDown_attenuation3;
        private System.Windows.Forms.GroupBox groupBox_сomponent2;
        private System.Windows.Forms.NumericUpDown numericUpDown_phaseED2;
        private System.Windows.Forms.NumericUpDown numericUpDown_frequencyED2;
        private System.Windows.Forms.NumericUpDown numericUpDown_attenuation2;
        private System.Windows.Forms.GroupBox groupBox_сomponent1;
        private System.Windows.Forms.NumericUpDown numericUpDown_phaseED1;
        private System.Windows.Forms.NumericUpDown numericUpDown_frequencyED1;
        private System.Windows.Forms.NumericUpDown numericUpDown_attenuation1;
        private System.Windows.Forms.GroupBox groupBox_sleParams;
        private System.Windows.Forms.GroupBox groupBox_sizeSLE;
        private System.Windows.Forms.NumericUpDown numericUpDown_M;
        private System.Windows.Forms.NumericUpDown numericUpDown_N;
        private System.Windows.Forms.Button buttonSolveSLE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_graphSVD;
        private System.Windows.Forms.TextBox textBoxDiscrepancy;
        private System.Windows.Forms.NumericUpDown numericUpDown_correlationOrder;
        private System.Windows.Forms.NumericUpDown numericUpDown_eigenvectorNumber;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_eigenvector;
        private System.Windows.Forms.NumericUpDown numericUpDown_max;
        private System.Windows.Forms.NumericUpDown numericUpDown_min;
        private System.Windows.Forms.RichTextBox richTextBoxResultSLE;
    }
}