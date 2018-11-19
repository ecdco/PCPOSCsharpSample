using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ECDPCPos;

namespace ComPortTest
{
    public partial class Form1 : Form
    {
        ECDPCPos.Serial s = new Serial();

        public Form1()
        {
            InitializeComponent();
        }

        private void s_Onreveive()
        {
            string bm = "Status= " + s.Status.ToString() + "\r\n";
            bm += "Stan= " + s.Stan + "\r\n";
            bm += "RRN= " + s.RRN + "\r\n";
            bm += "DateTime= " + s.Datetime + "\r\n";
            bm += "Amount= " + s.Amount + "\r\n";
            bm += "Balance= " + s.Balance + "\r\n";
            bm += "CardNo= " + s.CardNumber + "\r\n";

            MessageBox.Show(bm);
        }
        private void butSale_Click(object sender, EventArgs e)
        {
            
            s.DeviceSerialNo = txtSerial.Text.Trim();
            s.MerchantNo = txtMerchant.Text.Trim();
            s.TerminalNo = txtTerminal.Text.Trim();
            s.Type = Serial.PaymentType.Sale;
            s.Amount = txtAmount.Text.Trim();

            bool Res = s.Payment();

        
        }

        private void butConn_Click(object sender, EventArgs e)
        {
            s.BaudRate = 115200;
            s.DataBits = 8;
            s.Parity = System.IO.Ports.Parity.None;
            s.PortName = "COM4";
            s.SerialOnReceive += new Serial.ECDDataReceivedEventHandler(s_Onreveive);

            if (s.InitComminication())
            {
                txt.Text += "Port " + s.PortName + " Opened" + "\r\n";
                butConn.Enabled = false;
                butDis.Enabled = true;

                butSale.Enabled = true;
                butBalance.Enabled = true;
            }
            else
                txt.Text += "Port " + s.PortName + " not opening" + "\r\n";
        }

        private void butDis_Click(object sender, EventArgs e)
        {
            s.SerialOnReceive -= new Serial.ECDDataReceivedEventHandler(s_Onreveive);
            if (s.CloseComminication())
            {
                txt.Text += "Port " + s.PortName + " Closed" + "\r\n";
                butConn.Enabled = true;
                butDis.Enabled = false;

                butSale.Enabled = false;
                butBalance.Enabled = false;
               
            }
            else
                txt.Text += "Port " + s.PortName + " not Closing" + "\r\n";
        }

        private void butBalance_Click(object sender, EventArgs e)
        {
            s.DeviceSerialNo = txtSerial.Text.Trim();
            s.MerchantNo = txtMerchant.Text.Trim();
            s.TerminalNo = txtTerminal.Text.Trim();
            s.Type = Serial.PaymentType.Balance;

            bool Res = s.Payment();
            if (Res == true)
                txt.Text += "Send request: " + s.Type.ToString().Trim() + "\r\n";
            else
                txt.Text += "can not sending- Error= " + s.Error + "\r\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            butConn.Enabled = true;
            butDis.Enabled = false;

            butSale.Enabled = false;
            butBalance.Enabled = false;

        }
    }
}
