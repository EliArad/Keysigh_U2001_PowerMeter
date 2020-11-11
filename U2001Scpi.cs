using SCPILIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2021XALib
{
    public class U2001Scpi : IPowerMeter
    {
        SCPI m_scpi;
        public U2001Scpi(string visaAddress) : base(visaAddress)
        {
            m_scpi = new SCPI(visaAddress);
        }

        public override double Measure(out bool ok)
        {
            m_scpi.SendScpi("init");
            string power = m_scpi.QueryScpi("fetch?");
            ok = true;
            return double.Parse(power);
        }
        public override void Close()
        {

        }
        public override void SetFrequency(double freqInHz)
        {
            m_scpi.SendScpi(":sense:freq:cw " + freqInHz);
        }        

    }
}
