using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace try4
{
    public partial class Form1 : Form
    {
        private ACGenerator ac = new ACGenerator(20, 50, Math.PI * 2, 1000);
        private BridgeRectifier br = new BridgeRectifier();
        private Capacitor c = new Capacitor();
        private IniFileManager fileManager = new IniFileManager();

        private int time = 0;
        private bool isStartStop = true;
        private double maxACVoltage = 0;
        private double maxDCVoltage = 0;

        private const double DiodeVoltageDrop = 0.6;
        private const double MaxDiodeReverseVoltage = 500;

        private Dictionary<string, Diode> diodeDictionary = new Dictionary<string, Diode>
    {
        { "Диод 1N4148", new Diode(DiodeVoltageDrop, 75) },
        { "Диод 1N5388B", new Diode(DiodeVoltageDrop, MaxDiodeReverseVoltage) },
        { "Диод 1N5819", new Diode(0.3, 40) }
    };

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }
        private void InitializeUI()
        {
            InitializeTimer();
            InitializeChart();
            InitializeComboBox();
            InitializeNumericUpDown();

            chartAC.Series[0].Points.Add(0, 0);
            chartDC.Series[0].Points.Add(0, 0);
        }
        private void InitializeTimer()
        {
            timer.Interval = 100;
        }
        private void InitializeChart()
        {
            chartAC.ChartAreas[0].AxisX.Minimum = 0;
            chartAC.ChartAreas[0].AxisY.Maximum = ac.ChangeAmplitude + 5;
            chartAC.ChartAreas[0].AxisY.Minimum = -ac.ChangeAmplitude - 5;

            chartDC.ChartAreas[0].AxisX.Minimum = 0;
            chartDC.ChartAreas[0].AxisY.Maximum = ac.ChangeAmplitude + 5;
            chartDC.ChartAreas[0].AxisY.Minimum = 0;
        }
        private void InitializeNumericUpDown()
        {
            CapacityNumericUpDown.Minimum = 0.1M;
            CapacityNumericUpDown.Value = 0.1M;
            CapacityNumericUpDown.Increment = 0.1M; // Замените 0.1 на желаемое значение шага

            timeConstantNumericUpDown.Minimum = 0.01M;
            timeConstantNumericUpDown.Value = 0.05M;
            timeConstantNumericUpDown.Increment = 0.01M; // Замените 0.1 на желаемое значение шага
        }
        private void InitializeComboBox()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }
        private void RefreshUI()
        {
            amplitudeTextBox.Text = ac.ChangeAmplitude.ToString();
            samplingRateTextBox.Text = ac.ChangeSamplingRate.ToString();
            frequencyTextBox.Text = ac.ChangeFrequency.ToString();

            CapacityNumericUpDown.Value = Convert.ToDecimal(c.Capacity / 1e-6);
        }
        private void UpdateChartAndLabels(double ACvoltage, double CapDCvoltage, double DCvoltage)
        {
            chartAC.Series[0].Points.AddXY(time, ACvoltage);
            chartDC.Series[0].Points.AddXY(time, DCvoltage);
            chartDC.Series[1].Points.AddXY(time, CapDCvoltage);

            CalculateVoltageLabel(ACvoltage, CapDCvoltage);
        }
        private void UpdateCapacitorParameters(NumericUpDown numericUpDown)
        {
            double value;
            try
            {
                value = (double)numericUpDown.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при установке параметров конденсатора: " + ex.Message,
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            switch (numericUpDown.Tag)
            {
                case "0":
                    c.Capacity = value * 1e-6;
                    break;
                case "1":
                    c.TimeConstant = value;
                    break;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            double ACvoltage = ac.GenerateSample(time);
            double DCvoltage = br.ReleaseVoltage(ACvoltage);
            double CapDCvoltage = c.Charge(DCvoltage);

            if (DCvoltage == -MaxDiodeReverseVoltage)
            {
                HandleDiodeBurnout();
                resetBtn_Click(sender, e);
            }

            time++;
            UpdateChartAndLabels(ACvoltage, CapDCvoltage, DCvoltage);
        }
        private void CalculateVoltageLabel(double ACvoltage, double DCvoltage)
        {
            voltageACLabel.Text = Math.Round(ACvoltage, 2).ToString() + " В";
            voltageDCLabel.Text = Math.Round(DCvoltage, 2).ToString() + " В";

            FindACMaxVoltage(ACvoltage, maxACVoltageLabel);
            FindDCMaxVoltage(DCvoltage, maxDCVoltageLabel);
        }

        private void FindACMaxVoltage(double voltage, Label label)
        {
            if(voltage > maxACVoltage)
            {
                maxACVoltage = voltage;
                label.Text = Math.Round(maxACVoltage, 2).ToString() + " B";
            }
        }
        private void FindDCMaxVoltage(double voltage, Label label)
        {
            if (voltage > maxDCVoltage)
            {
                maxDCVoltage = voltage;
                if (maxDCVoltage > maxACVoltage)
                    maxDCVoltage = maxDCVoltage - ((maxDCVoltage - maxACVoltage) + 0.6);
                label.Text = Math.Round(maxDCVoltage, 2).ToString() + " B";
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePropertiesToIni();
        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPropertiesFromIni();
            RefreshUI();
        }
        private void методическаяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMethodInformationPdf();
        }
        private void источникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSources();
        }
        private void оРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDeveloperInfo();
        }
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void baseBtn_Click(object sender, EventArgs e)
        {
            ac.ByDefault();
            amplitudeTextBox.Text = ac.GetBaseAmplitude.ToString();
            frequencyTextBox.Text = ac.GetBaseFrequency.ToString();
            samplingRateTextBox.Text = ac.GetBaseSamplingRate.ToString();
            InitializeComboBox();
            InitializeChart();

            CapacityNumericUpDown.Value = 0.1M;
            timeConstantNumericUpDown.Value = 0.05M;

            c.Capacity = 0.1;
            c.TimeConstant = 0.05;
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            maxACVoltage = 0;
            maxDCVoltage = 0;
            maxACVoltageLabel.Text = "---";
            maxDCVoltageLabel.Text = "---";
            time = 0;
            SetStopBth();
            chartAC.Series[0].Points.Clear();
            chartDC.Series[0].Points.Clear();
            chartDC.Series[1].Points.Clear();

            chartAC.Series[0].Points.Add(0, 0);
            chartDC.Series[0].Points.Add(0, 0);
            chartDC.Series[1].Points.Add(0, 0);

            ac.CurrentRampStep = 0;

            c.Discharge();
        }
        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (isStartStop)
            {
                SetStartBth();
            }
            else
            {
                SetStopBth();
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateCapacitorParameters(sender as NumericUpDown);
        }
        private void ComboBox_SelectedItemChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedDiod = comboBox.SelectedItem.ToString();

            if (diodeDictionary.TryGetValue(selectedDiod, out Diode diode))
            {
                int index = int.Parse(comboBox.Tag.ToString());
                br.ChangeDiode(index, diode);
            }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == "0" || textBox.Text == "00" || textBox.Text == "000")
            {
                SetStopBth();
                return;
            }

            double value;

            try
            {
                value = Convert.ToDouble(textBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при установке параметров конденсатора: " + ex.Message,
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            switch (textBox.Tag)
            {
                case "0":
                    ac.ChangeAmplitude = value;
                    break;
                case "1":
                    ac.ChangeSamplingRate = value;
                    break;
                case "2":
                    ac.ChangeFrequency = value;
                    break;
            }

            InitializeChart();
        }
        private void Label_DoubleClick(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            switch (label.Tag)
            {
                case "0":
                    MessageBox.Show("Диод 1N4148 - это популярный полупроводниковый диод общего назначения, номинальное напряжение падения на переходе порядка 0.6 вольта и максимальное обратное напряжение в пределах 75 вольт"
                        + Environment.NewLine
                        + Environment.NewLine
                        + "Диод 1N5388B - это силовой ценовой диод, напряжение падения на переходе 0.6 вольта и высокое максимальное обратное напряжение в пределах 500 вольт"
                        + Environment.NewLine
                        + Environment.NewLine
                        + "Диод 1N5819 - это силовой диод Шоттки, напряжение падения на переходе 0.3 вольта и максимальное обратное напряжение составляет 40 Вольт"
                        , "Список диодов"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    break;
                case "1":
                    MessageBox.Show("Амплитуда - это максимальное значение сигнала, оно определяет \"высоту\" сигнала на графике."
                        + Environment.NewLine
                        + Environment.NewLine
                        + "Когда амплитуда равна 1, сигнал будет колебаться между -1 и 1, и это называется сигналом с амплитудой 1. Если амплитуда равна 2, то сигнал будет колебаться между -2 и 2, и так далее."
                        , "Параметр генератора переменного тока"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    break;
                case "2":
                    MessageBox.Show("Частота дискретизации определяет, сколько раз в секунду происходит измерение (дискретизация) значения сигнала. Она измеряется в герцах (Гц)."
                        + Environment.NewLine
                        + Environment.NewLine
                        + "Если вы моделируете электрические сигналы с частотой до 1 кГц (например, электрические сигналы в бытовых устройствах), часто используется частота дискретизации от 1 кГц до 10 кГц."
                        , "Параметр генератора переменного тока"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    break;
                case "3":
                    MessageBox.Show("Частота сигнала в генераторе переменного тока (AC) представляет собой количество циклов (периодов) сигнала, которые происходят за одну секунду. Единицей измерения частоты является герц (Гц)."
                        + Environment.NewLine
                        + Environment.NewLine
                        + "В домашних бытовых устройствах, таких как сети переменного тока для электропитания, стандартная частота составляет 50 или 60 герц, в зависимости от региона мира. Например, в большинстве стран Европы и Азии используется 50 Гц, а в Северной Америке и некоторых других странах - 60 Гц."
                        , "Параметр генератора переменного тока"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    break;
                case "4":
                    MessageBox.Show("Емкость конденсатора - это физическая величина, которая определяет способность конденсатора накапливать электрический заряд при заданной разности потенциалов (напряжении). Единицей измерения емкости в системе СИ является фарад (Ф), который определен как 1 фарад равен 1 кулону заряда при напряжении 1 вольт."
                        , "Параметр конденсатора"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    break;
                case "5":
                    MessageBox.Show("Время зарядки конденсатора - это интервал времени, который требуется для того, чтобы напряжение на конденсаторе увеличилось или уменьшилось на определенный процент от своего начального значения в результате подачи или удаления заряда."
                        , "Параметр конденсатора"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    break;

            }
        }
        private void Chart_DoubleClick(object sender, EventArgs e)
        {
            Chart chart = (Chart)sender;

            switch(chart.Tag)
            {
                case "0":
                    MessageBox.Show("График изменения напряжения со временем:\r\nНа графике по горизонтальной оси откладывается время, а по вертикальной оси - напряжение. Таким образом, каждая точка на графике представляет собой пару значений: время и соответствующее напряжение в это время.\r\n\r\nИнтерпретация графика:\r\n\r\nПериодические колебания: График может показывать периодические колебания напряжения. Это характерно для переменного тока, который меняется с определенной частотой. На графике вы будете видеть повторяющиеся волны, которые соответствуют положительным и отрицательным значениям напряжения.\r\n\r\nАмплитуда: Высота волны на графике называется амплитудой. Амплитуда представляет максимальное значение напряжения, достигаемое во время каждого положительного или отрицательного полупериода.\r\n\r\nЧастота: Частота сигнала отображается количеством полупериодов, происходящих за единицу времени. Это определяет, сколько раз сигнал полностью меняется от одного положительного пика до следующего за определенное время.\r\n\r\nФаза: Фаза на графике показывает, насколько сдвинута волна по времени относительно начального момента. Фаза может влиять на то, как сигналы с разными фазами взаимодействуют друг с другом."
                        , "Информация"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    break;
                case "1":
                    MessageBox.Show("График изменения выпрямленного напряжения:\r\nНа графике по горизонтальной оси откладывается время, а по вертикальной оси - значение напряжения. Этот график отображает изменения напряжения после выпрямления (преобразования переменного тока в постоянный) в электрической схеме.\r\n\r\nГрафик изменения напряжения конденсатора:\r\nНа этом графике также по горизонтальной оси откладывается время, а по вертикальной оси - значение напряжения. График показывает, как напряжение на конденсаторе меняется со временем, когда он заряжается и разряжается.\r\n\r\nИнтерпретация графиков:\r\n\r\nВыпрямленное напряжение: На графике выпрямленного напряжения вы увидите пики, которые представляют максимальные значения выпрямленного напряжения.\r\n\r\nНапряжение конденсатора: График напряжения на конденсаторе будет начинаться с нулевого значения напряжения, поскольку конденсатор изначально разряжен. Со временем, по мере его зарядки, напряжение на конденсаторе будет постепенно расти. Когда конденсатор разряжается, напряжение начнет снижаться."
                        , "Информация"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    break;
            }
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Мостовой выпрямитель – это устройство, используемое для преобразования переменного напряжения (AC) в постоянное напряжение (DC). Он состоит из четырех диодов, организованных в специальной конфигурации, которая позволяет выпрямлять переменный ток."
                        + Environment.NewLine
                        + Environment.NewLine
                        + "Мостовой выпрямитель широко используется в электронике, электротехнике и электроэнергетике для преобразования переменного напряжения в постоянное. Его преимущества включают высокую эффективность преобразования и возможность работы с высокими токами и напряжениями.\r\n\r\nИногда мостовой выпрямитель дополняют фильтром ёмкости, который уменьшает пульсации на выходе, делая постоянное напряжение более стабильным."
                        , "Информация"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
        }

        private void SavePropertiesToIni()
        {
            fileManager.SavePropertiesToIni(ac, br, c);
        }
        private void LoadPropertiesFromIni()
        {
            fileManager.LoadPropertiesFromIni(ac, br, c);
        }
        private void OpenMethodInformationPdf()
        {
            string pdfFilePath = Path.Combine(Application.StartupPath, "method_info.pdf");

            if (File.Exists(pdfFilePath))
            {
                Process.Start(pdfFilePath);
            }
            else
            {
                MessageBox.Show("PDF file not found.");
            }
        }
        private void ShowSources()
        {
            string message = "Источники: https://www.fxyz.ru/формулы_по_физике/электричество/электрические_машины/генераторы/генераторы_переменного_тока/" +
                            Environment.NewLine +
                            "https://studfile.net/preview/3865307/page:6/";

            MessageBox.Show(message, "Ссылки на источники", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ShowDeveloperInfo()
        {
            MessageBox.Show("Разработчик: Климов Д. студент АНООВО МИКТ группы ИВТо-211", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ExitApplication()
        {
            DialogResult result1 = MessageBox.Show("Вы действительно хотите выйти из программы?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result1 == DialogResult.Yes)
            {
                DialogResult result2 = MessageBox.Show("Вы хотите сохранить настройки?", "Подтверждение сохранения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result2 == DialogResult.Yes)
                    SavePropertiesToIni();

                Application.Exit();
            }
        }
        private void HandleDiodeBurnout()
        {
            SetStopBth();
            MessageBox.Show("Диод сгорел! Слишком высокое обратное напряжение! Симуляция будет перезапущена.",
                "Внимание!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        private void SetStartBth()
        {
            isStartStop = false;
            timer.Start();
            startStopBtn.Text = "Стоп";
            startStopBtn.BackColor = Color.Red;
        }
        private void SetStopBth()
        {
            voltageACLabel.Text = "---";
            voltageDCLabel.Text = "---";
            isStartStop = true;
            timer.Stop();
            startStopBtn.Text = "Старт";
            startStopBtn.BackColor = Color.Lime;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }


    }
}
