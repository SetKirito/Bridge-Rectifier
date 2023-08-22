using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try4
{
    class Diode
    {
        private const double DefaultMaxReverseVoltage = 50.0;
        private const double DefaultTransientVoltage = 0.6;

        private double maxReverseVoltage;
        private double transientVoltage;

        public Diode()
        {
            maxReverseVoltage = DefaultMaxReverseVoltage;
            transientVoltage = DefaultTransientVoltage;
        }

        public Diode(double transientVoltage, double maxReverseVoltage)
        {
            this.maxReverseVoltage = maxReverseVoltage;
            this.transientVoltage = transientVoltage;
        }

        public double CalculateVoltageDrop(double voltage)
        {
            if (voltage > transientVoltage)
                return voltage - transientVoltage;
            else if (voltage < transientVoltage && voltage > -maxReverseVoltage)
                return 0;
            else if (voltage < transientVoltage && voltage < -maxReverseVoltage)
                return -500;

            // Вернуть значение, указывающее на ошибку
            throw new ArgumentException("Недопустимое напряжение");
        }

        public double MaxReverseVoltage
        {
            get { return maxReverseVoltage; }
            set
            {
                if (value > 0)
                    maxReverseVoltage = value;
                else
                    throw new ArgumentException("Недопустимое значение максимального обратного напряжения");
            }
        }

        public double TransientVoltage
        {
            get { return transientVoltage; }
            set
            {
                if (value >= 0)
                    transientVoltage = value;
                else
                    throw new ArgumentException("Недопустимое значение переходного напряжения");
            }
        }
    }

}
