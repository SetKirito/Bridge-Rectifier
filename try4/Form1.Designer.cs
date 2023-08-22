namespace try4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методическаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.источникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРазработчикеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseBtn = new System.Windows.Forms.Button();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.chartDC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.amplitudeTextBox = new System.Windows.Forms.TextBox();
            this.samplingRateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frequencyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.voltageACLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxACVoltageLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.voltageDCLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.maxDCVoltageLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timeConstantNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.CapacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeConstantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapacityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методическаяИнформацияToolStripMenuItem,
            this.источникиToolStripMenuItem,
            this.оРазработчикеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // методическаяИнформацияToolStripMenuItem
            // 
            this.методическаяИнформацияToolStripMenuItem.Name = "методическаяИнформацияToolStripMenuItem";
            this.методическаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.методическаяИнформацияToolStripMenuItem.Text = "Методическая информация";
            this.методическаяИнформацияToolStripMenuItem.Click += new System.EventHandler(this.методическаяИнформацияToolStripMenuItem_Click);
            // 
            // источникиToolStripMenuItem
            // 
            this.источникиToolStripMenuItem.Name = "источникиToolStripMenuItem";
            this.источникиToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.источникиToolStripMenuItem.Text = "Источники";
            this.источникиToolStripMenuItem.Click += new System.EventHandler(this.источникиToolStripMenuItem_Click);
            // 
            // оРазработчикеToolStripMenuItem
            // 
            this.оРазработчикеToolStripMenuItem.Name = "оРазработчикеToolStripMenuItem";
            this.оРазработчикеToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.оРазработчикеToolStripMenuItem.Text = "О разработчике";
            this.оРазработчикеToolStripMenuItem.Click += new System.EventHandler(this.оРазработчикеToolStripMenuItem_Click);
            // 
            // baseBtn
            // 
            this.baseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.baseBtn.Location = new System.Drawing.Point(278, 691);
            this.baseBtn.Name = "baseBtn";
            this.baseBtn.Size = new System.Drawing.Size(127, 50);
            this.baseBtn.TabIndex = 3;
            this.baseBtn.Text = "По-умолчанию";
            this.baseBtn.UseVisualStyleBackColor = true;
            this.baseBtn.Click += new System.EventHandler(this.baseBtn_Click);
            // 
            // startStopBtn
            // 
            this.startStopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startStopBtn.BackColor = System.Drawing.Color.Lime;
            this.startStopBtn.Location = new System.Drawing.Point(12, 691);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(127, 50);
            this.startStopBtn.TabIndex = 4;
            this.startStopBtn.Text = "Старт";
            this.startStopBtn.UseVisualStyleBackColor = false;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetBtn.Location = new System.Drawing.Point(145, 691);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(127, 50);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Сброс";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // chartDC
            // 
            this.chartDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartDC.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDC.Legends.Add(legend1);
            this.chartDC.Location = new System.Drawing.Point(670, 391);
            this.chartDC.Name = "chartDC";
            this.chartDC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "U DC";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "U DC CAP";
            this.chartDC.Series.Add(series1);
            this.chartDC.Series.Add(series2);
            this.chartDC.Size = new System.Drawing.Size(800, 350);
            this.chartDC.TabIndex = 0;
            this.chartDC.Tag = "1";
            this.chartDC.Text = "chartDC";
            this.chartDC.DoubleClick += new System.EventHandler(this.Chart_DoubleClick);
            // 
            // chartAC
            // 
            this.chartAC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartAC.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAC.Legends.Add(legend2);
            this.chartAC.Location = new System.Drawing.Point(670, 33);
            this.chartAC.Name = "chartAC";
            this.chartAC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "U AC";
            this.chartAC.Series.Add(series3);
            this.chartAC.Size = new System.Drawing.Size(800, 350);
            this.chartAC.TabIndex = 0;
            this.chartAC.Tag = "0";
            this.chartAC.Text = "chartAC";
            this.chartAC.DoubleClick += new System.EventHandler(this.Chart_DoubleClick);
            // 
            // amplitudeTextBox
            // 
            this.amplitudeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.amplitudeTextBox.Location = new System.Drawing.Point(534, 12);
            this.amplitudeTextBox.Name = "amplitudeTextBox";
            this.amplitudeTextBox.Size = new System.Drawing.Size(100, 22);
            this.amplitudeTextBox.TabIndex = 1;
            this.amplitudeTextBox.Tag = "0";
            this.amplitudeTextBox.Text = "20";
            this.amplitudeTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // samplingRateTextBox
            // 
            this.samplingRateTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.samplingRateTextBox.Location = new System.Drawing.Point(534, 40);
            this.samplingRateTextBox.Name = "samplingRateTextBox";
            this.samplingRateTextBox.Size = new System.Drawing.Size(100, 22);
            this.samplingRateTextBox.TabIndex = 2;
            this.samplingRateTextBox.Tag = "1";
            this.samplingRateTextBox.Text = "1000";
            this.samplingRateTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(438, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 3;
            this.label1.Tag = "1";
            this.label1.Text = "Амплитуда";
            this.label1.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            // 
            // frequencyTextBox
            // 
            this.frequencyTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.frequencyTextBox.Location = new System.Drawing.Point(534, 68);
            this.frequencyTextBox.Name = "frequencyTextBox";
            this.frequencyTextBox.Size = new System.Drawing.Size(100, 22);
            this.frequencyTextBox.TabIndex = 4;
            this.frequencyTextBox.Tag = "2";
            this.frequencyTextBox.Text = "50";
            this.frequencyTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(335, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 5;
            this.label2.Tag = "2";
            this.label2.Text = "Частота дискретизации Гц";
            this.label2.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(383, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 6;
            this.label3.Tag = "3";
            this.label3.Text = "Частота сигнала Гц";
            this.label3.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Переменное U :";
            // 
            // voltageACLabel
            // 
            this.voltageACLabel.AutoSize = true;
            this.voltageACLabel.Location = new System.Drawing.Point(121, 74);
            this.voltageACLabel.Name = "voltageACLabel";
            this.voltageACLabel.Size = new System.Drawing.Size(19, 16);
            this.voltageACLabel.TabIndex = 8;
            this.voltageACLabel.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Макс U :";
            // 
            // maxACVoltageLabel
            // 
            this.maxACVoltageLabel.AutoSize = true;
            this.maxACVoltageLabel.Location = new System.Drawing.Point(71, 46);
            this.maxACVoltageLabel.Name = "maxACVoltageLabel";
            this.maxACVoltageLabel.Size = new System.Drawing.Size(19, 16);
            this.maxACVoltageLabel.TabIndex = 10;
            this.maxACVoltageLabel.Text = "---";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.amplitudeTextBox);
            this.groupBox1.Controls.Add(this.samplingRateTextBox);
            this.groupBox1.Controls.Add(this.voltageACLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.maxACVoltageLabel);
            this.groupBox1.Controls.Add(this.frequencyTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 125);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генератор переменного тока";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox2.Controls.Add(this.voltageDCLabel);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.maxDCVoltageLabel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 247);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мостовой преобразователь";
            // 
            // voltageDCLabel
            // 
            this.voltageDCLabel.AutoSize = true;
            this.voltageDCLabel.Location = new System.Drawing.Point(121, 195);
            this.voltageDCLabel.Name = "voltageDCLabel";
            this.voltageDCLabel.Size = new System.Drawing.Size(19, 16);
            this.voltageDCLabel.TabIndex = 12;
            this.voltageDCLabel.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Постоянное U :";
            // 
            // maxDCVoltageLabel
            // 
            this.maxDCVoltageLabel.AutoSize = true;
            this.maxDCVoltageLabel.Location = new System.Drawing.Point(71, 166);
            this.maxDCVoltageLabel.Name = "maxDCVoltageLabel";
            this.maxDCVoltageLabel.Size = new System.Drawing.Size(19, 16);
            this.maxDCVoltageLabel.TabIndex = 10;
            this.maxDCVoltageLabel.Text = "---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Макс U :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::try4.Properties.Resources.Bridge;
            this.pictureBox1.Location = new System.Drawing.Point(403, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(6, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 7;
            this.label9.Tag = "0";
            this.label9.Text = "Диод 4";
            this.label9.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Диод 1N4148",
            "Диод 1N5388B",
            "Диод 1N5819"});
            this.comboBox4.Location = new System.Drawing.Point(83, 125);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 6;
            this.comboBox4.Tag = "3";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedItemChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Диод 1N4148",
            "Диод 1N5388B",
            "Диод 1N5819"});
            this.comboBox3.Location = new System.Drawing.Point(83, 95);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.Tag = "2";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedItemChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Диод 1N4148",
            "Диод 1N5388B",
            "Диод 1N5819"});
            this.comboBox2.Location = new System.Drawing.Point(83, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Tag = "1";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedItemChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Диод 1N4148",
            "Диод 1N5388B",
            "Диод 1N5819"});
            this.comboBox1.Location = new System.Drawing.Point(83, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Tag = "0";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedItemChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 0;
            this.label6.Tag = "0";
            this.label6.Text = "Диод 1";
            this.label6.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(6, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 2;
            this.label8.Tag = "0";
            this.label8.Text = "Диод 3";
            this.label8.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 1;
            this.label7.Tag = "0";
            this.label7.Text = "Диод 2";
            this.label7.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.timeConstantNumericUpDown);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.CapacityNumericUpDown);
            this.groupBox3.Location = new System.Drawing.Point(12, 537);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 85);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Конденсатор";
            // 
            // timeConstantNumericUpDown
            // 
            this.timeConstantNumericUpDown.DecimalPlaces = 2;
            this.timeConstantNumericUpDown.Location = new System.Drawing.Point(134, 47);
            this.timeConstantNumericUpDown.Name = "timeConstantNumericUpDown";
            this.timeConstantNumericUpDown.Size = new System.Drawing.Size(102, 22);
            this.timeConstantNumericUpDown.TabIndex = 14;
            this.timeConstantNumericUpDown.Tag = "1";
            this.timeConstantNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(6, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 16);
            this.label12.TabIndex = 1;
            this.label12.Tag = "4";
            this.label12.Text = "Ёмкость в мкФ";
            this.label12.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            // 
            // CapacityNumericUpDown
            // 
            this.CapacityNumericUpDown.DecimalPlaces = 1;
            this.CapacityNumericUpDown.Location = new System.Drawing.Point(9, 47);
            this.CapacityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CapacityNumericUpDown.Name = "CapacityNumericUpDown";
            this.CapacityNumericUpDown.Size = new System.Drawing.Size(99, 22);
            this.CapacityNumericUpDown.TabIndex = 0;
            this.CapacityNumericUpDown.Tag = "0";
            this.CapacityNumericUpDown.ThousandsSeparator = true;
            this.CapacityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CapacityNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(131, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 16);
            this.label13.TabIndex = 15;
            this.label13.Tag = "5";
            this.label13.Text = "Время зарядки";
            this.label13.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartDC);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.baseBtn);
            this.Controls.Add(this.chartAC);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeConstantNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapacityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методическаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem источникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРазработчикеToolStripMenuItem;
        private System.Windows.Forms.Button baseBtn;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAC;
        private System.Windows.Forms.TextBox amplitudeTextBox;
        private System.Windows.Forms.TextBox samplingRateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox frequencyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label voltageACLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label maxACVoltageLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label maxDCVoltageLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label voltageDCLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown CapacityNumericUpDown;
        private System.Windows.Forms.NumericUpDown timeConstantNumericUpDown;
        private System.Windows.Forms.Label label13;
    }
}

