using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeysightU2001App
{
    public partial class Form1 : Form
    {

        string[] pmKeysigthList = { "USB0::0x2A8D::0x7F18::MY57030006::0::INSTR",
                                    "USB0::0x0957::0x7F18::SG54120002::0::INSTR",
                                    "USB0::0x2A8D::0x2B18::MY48100808::0::INSTR",
                                    "USB0::0x0957::0x2B18::MY52010037::0::INSTR",
                                    "USB0::0x0957::0x2E18::MY51080009::0::INSTR" };

        public Form1()
        {
            InitializeComponent();

            powerMeterControl1.Setup(pmKeysigthList[0], rbIVI.Checked == true ? PowerMeterControl.CONTYPE.IVI : PowerMeterControl.CONTYPE.SCPI);
            powerMeterControl2.Setup(pmKeysigthList[1], rbIVI.Checked == true ? PowerMeterControl.CONTYPE.IVI : PowerMeterControl.CONTYPE.SCPI);
            powerMeterControl3.Setup(pmKeysigthList[2], rbIVI.Checked == true ? PowerMeterControl.CONTYPE.IVI : PowerMeterControl.CONTYPE.SCPI);
            powerMeterControl4.Setup(pmKeysigthList[3], rbIVI.Checked == true ? PowerMeterControl.CONTYPE.IVI : PowerMeterControl.CONTYPE.SCPI);
            powerMeterControl5.Setup(pmKeysigthList[4], rbIVI.Checked == true ? PowerMeterControl.CONTYPE.IVI : PowerMeterControl.CONTYPE.SCPI);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            powerMeterControl1.Close();
            powerMeterControl2.Close();
            powerMeterControl3.Close();
            powerMeterControl4.Close();
            powerMeterControl5.Close();
            Thread.Sleep(500);
        }
    }
}
