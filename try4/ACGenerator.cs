using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try4
{
    [AttributeUsage(AttributeTargets.Property)]
    public class IniSaveAttribute : Attribute
    {
    }
    class ACGenerator
    {


        private const double BaseAmplitude = 20.0;
        private const double BaseFrequency = 50.0;
        private const double BasePhase = Math.PI * 2;
        private const double BaseSamplingRate = 1000.0;

        private double amplitude; // Амплитуда сигнала
        private double frequency; // Частота сигнала
        private double phase; // Фаза сигнала
        private double samplingRate; // Частота дискретизации
        private Random rnd = new Random();

        private double startAmplitude; // Начальная амплитуда сигнала при запуске
        private double startRampDuration; // Длительность увеличения амплитуды при запуске
        private int rampSteps; // Количество шагов для увеличения амплитуды

        private int currentRampStep = 0; // Текущий шаг увеличения амплитуды

        public ACGenerator()
        {
            ByDefault();
            //time = 0.0;

        }

        public ACGenerator(double amplitude, double frequency, double phase, double samplingRate)
        {
            this.amplitude = amplitude;
            this.frequency = frequency;
            this.phase = phase;
            this.samplingRate = samplingRate;
            //time = 0.0;

            startAmplitude = BaseAmplitude; // Начальная амплитуда сигнала при запуске (можете настроить)
            startRampDuration = 20; // Длительность увеличения амплитуды при запуске (в миллисекундах, можете настроить)
            rampSteps = (int)(startRampDuration / (1000 / samplingRate));
        }

        public double GenerateSample(int time)
        {
            if (currentRampStep < rampSteps)
            {
                double rampAmplitude = startAmplitude * (currentRampStep / (double)rampSteps);
                amplitude = rampAmplitude;
                currentRampStep++;
            }

            double smplTime = time / samplingRate;
            double sample = amplitude * Math.Sin(2 * Math.PI * frequency * smplTime + phase);

            double noiseAmplitude = amplitude / 10; // You can adjust the noise amplitude as needed
            double noise = noiseAmplitude * (2 * rnd.NextDouble() - 1); // Generate random noise between -1 and 1
            sample += noise;

            return sample;
        }
        public void ByDefault()
        {
            amplitude = BaseAmplitude;
            frequency = BaseFrequency;
            phase = BasePhase;
            samplingRate = BaseSamplingRate;
            currentRampStep = 0; // Сброс текущего шага увеличения амплитуды при запуске
        }
        public double GetBaseAmplitude
        {
            get { return BaseAmplitude; }
        }
        [IniSave]
        public double ChangeAmplitude
        {
            get { return amplitude; }
            set { amplitude = value; }
        }
        public double GetBaseFrequency
        {
            get { return BaseFrequency; }
        }
        [IniSave]
        public double ChangeFrequency
        {
            get { return frequency; }
            set { frequency = value; }
        }
        public double GetBaseSamplingRate
        {
            get { return BaseSamplingRate; }
        }
        [IniSave]
        public double ChangeSamplingRate
        {
            get { return samplingRate; }
            set { samplingRate = value; }
        }
        public int CurrentRampStep
        {
            set { currentRampStep = value; }
        }
    }
}
