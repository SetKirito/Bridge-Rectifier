using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try4
{
    class BridgeRectifier
    {
        private List<Diode> diodes;

        public BridgeRectifier()
        {
            diodes = new List<Diode>
        {
            new Diode(),
            new Diode(),
            new Diode(),
            new Diode()
        };
        }

        public void ChangeDiode(int num, Diode diode)
        {
            diodes[num] = diode;
        }

        public double ReleaseVoltage(double voltage)
        {
            double voltage1 = diodes[0].CalculateVoltageDrop(voltage);
            double voltage2 = diodes[1].CalculateVoltageDrop(voltage);
            double voltage3 = diodes[2].CalculateVoltageDrop(-voltage);
            double voltage4 = diodes[3].CalculateVoltageDrop(-voltage);

            const double errorValue = -500;

            if (voltage1 == errorValue || voltage2 == errorValue || voltage3 == errorValue || voltage4 == errorValue)
            {
                return errorValue;
            }

            double totalVoltage = voltage1 + voltage2 + voltage3 + voltage4;
            return totalVoltage / 2;
        }
    }

}
