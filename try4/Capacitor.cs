using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try4
{
    class Capacitor
    {
        private const double DefaultCapacity = 0.000001; // 1 Фарад (Ф)
        private const double DefaultTimeConstant = 0.05;

        private double currentVoltage;
        private double capacity;
        private double timeConstant;
        private Random rnd = new Random();

        public Capacitor()
        {
            capacity = DefaultCapacity;
            timeConstant = DefaultTimeConstant;
        }

        public Capacitor(double initialCapacity, double initialTimeConstant)
        {
            capacity = initialCapacity;
            timeConstant = initialTimeConstant;
        }

        public double Charge(double appliedVoltage)
        {
            // Зарядка конденсатора
            double charge = (appliedVoltage - currentVoltage) * (1 - Math.Exp(-timeConstant));
            currentVoltage += charge;

            return currentVoltage - rnd.NextDouble() / 5;
        }

        public void Discharge()
        {
            currentVoltage = 0;
        }

        // Свойства

        [IniSave]
        public double Capacity
        {
            get { return capacity; }
            set { capacity = Math.Max(0, value); }
        }

        [IniSave]
        public double TimeConstant
        {
            get { return timeConstant; }
            set { timeConstant = value; }
        }
    }

}
