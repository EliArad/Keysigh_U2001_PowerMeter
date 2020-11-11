using Ivi.Driver.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2021XALib
{
    public class IPowerMeter
    {

        protected string m_resourceDesc;

        public IPowerMeter(string visaAddress)  
        {
            m_resourceDesc = visaAddress;
        }

        public virtual bool Initialize(out string outMessage, out IIviDriverIdentity identity)
        {
            identity = null;
            outMessage = "not imlemented";
            return true;
        }

        public virtual double Measure(out bool ok)
        {
            ok = false;
            return 0;
        }

        public virtual void Close()
        {

        
        }

        public virtual void SetFrequency(double freqInHz)
        {           
 
        }
    }
}
