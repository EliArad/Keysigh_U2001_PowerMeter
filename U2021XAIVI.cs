using Ivi.Driver.Interop;
using Keysight.KtRFPowerMeter.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2021XALib
{
    public class U2021XAIVI
    {
        string m_resourceDesc;
        KtRFPowerMeter driver = null;
        KtRFPowerMeterChannel ChannelA = null;
        KtRFPowerMeterChannel ChannelB = null;
        KtRFPowerMeterMeasurement Measurement = null;
        bool m_continues = false;

        public U2021XAIVI(string visaAddress)
        {
            m_resourceDesc = visaAddress;
        }

        public bool Initialize(out string outMessage, out IIviDriverIdentity identity)
        {

            identity = null;
            try
            {
                outMessage = string.Empty;
                driver = new KtRFPowerMeter();
                string initOptions = "QueryInstrStatus=true, Simulate=false, DriverSetup= Model=, Trace=false, TraceName=c:\\temp\\traceOut";

                bool idquery = true;
                bool reset = true;
                identity = driver.Identity;
                // Initialize the driver.  See driver help topic "Initializing the IVI-COM Driver" for additional information
                driver.Initialize(m_resourceDesc, idquery, reset, initOptions);

                driver.System.Preset();
                // Wait for the preset to complete and wiat for 10 seconds
                driver.System.IOTimeout = 20000;
                // Select Channel A and set INIT:CONT OFF


               

                ChannelA = (KtRFPowerMeterChannel)driver.Channels.get_Item("A");
                ChannelB = (KtRFPowerMeterChannel)driver.Channels.get_Item("B");
                Measurement = driver.Measurements2.get_Item2("1");

                ChannelA.Trigger.ContinuousEnabled = true;
                m_continues = ChannelA.Trigger.ContinuousEnabled;
                return true;

            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                return false;
            }
        }

        public enum CHANNEL
        {
            CHANNELA,
            CHANNELB
        }

        public void Preset()
        {
            driver.System.Preset();            
        }
        public void IOTimeout(int timeOut = 2000)
        {
            // Wait for the preset to complete and wiat for 10 seconds
            driver.System.IOTimeout = timeOut;
        }
        public void ContinuousEnabled(CHANNEL channel, bool e)
        {
            
            var ChannelA = (KtRFPowerMeterChannel)driver.Channels.get_Item("A");
            var ChannelB = (KtRFPowerMeterChannel)driver.Channels.get_Item("B");
            var Measurement = driver.Measurements2.get_Item2("1");

            if (channel == CHANNEL.CHANNELA)
            {
                // Select Channel A and set INIT:CONT OFF
                ChannelA.Trigger.ContinuousEnabled = e;
            }
            if (channel == CHANNEL.CHANNELB)
            {
                // Select Channel A and set INIT:CONT OFF
                ChannelB.Trigger.ContinuousEnabled = e;
            }

            m_continues = e;
        }

        public void Initiate()
        {
            driver.Measurements.Initiate();
            driver.System.WaitForOperationComplete(1000);
        }
        public double Read()
        { 

            //Initiate();
            double data = Measurement.Read(1000);
            return data;
        }

        public double Measure()
        { 

            if (m_continues == false)
                Initiate();
            double data = Measurement.Fetch(1000);
            return data;
        }

        public double Fetch()
        {
             
            //Initiate();
            double data = Measurement.Fetch(1000);
            return data;
        }

        public void Close()
        {
            if (driver != null && driver.Initialized)
            {
                // Close the driver
                driver.Close();
                driver = null;
            }
        }

    }
}
