using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U2021XALib;
using Ivi.Driver.Interop;
using System.Threading;

namespace KeysightU2001App
{
    public partial class PowerMeterControl : UserControl
    {
        IPowerMeter m_pm = null;
        string m_visaName;
        public PowerMeterControl()
        {
            InitializeComponent();
        }
        public void Setup(string visaName)
        {
            m_visaName = visaName;
            textBox1.Text = visaName;
        }
        Task process = null;
        void LoadControl(string visaName, Action<bool, string> cb)
        {
            Task.Run(() =>
            {
                //m_pm = new U2021XAIVI(visaName);
                m_pm = new U2001Scpi(visaName);
                bool b = m_pm.Initialize(out string outMessage, out IIviDriverIdentity identity);
                cb(b, outMessage);
            });           
        }

        public void InvokeControlText(Control control, string e)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Text = e;
                });
            }
            else
            {
                control.Text = e;
            }
        }
        public void Close()
        {
            m_running = false;
            if (process != null)
                process.Wait();

            if (m_pm != null)
            {
                Task t = Task.Run(() =>
                {
                    m_pm.Close();
                });                 
            }
        }
        bool m_running = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            LoadControl(m_visaName, (status, msg) =>
            {
                if (status == false)
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    m_running = true;
                    process = Task.Run(() =>
                    {
                        while (m_running)
                        {
                            double power = m_pm.Measure(out bool ok);
                            if (ok == true)
                            {
                                InvokeControlText(lblPower, power.ToString("0.0000"));
                            }
                            Thread.Sleep(10);                            
                        }
                    });
                }
            });            
        }
    }
}
