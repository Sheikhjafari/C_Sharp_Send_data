using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace basic_send_data
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;

        public Form1()
        {
            InitializeComponent();
            getAvailableComPorts();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }
        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToSerialport();
            }
            else
            {
                disconnectFromSerialport();
            }
        }

        private void connectToSerialport()
        {

            try
            {
                string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
                port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                port.Open();
                isConnected = true;
                btn_connect.Text = "Disconnect";
                enableControls();
            }
            catch
            {

            }
        }

        private void disconnectFromSerialport()
        {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
            btn_connect.Text = "Connect";
            disableControls();
        }

        private void enableControls()
        {
           
            btn_write.Enabled = true;
            textBox1.Enabled = true;
            groupBox3.Enabled = true;

        }

        private void disableControls()
        {
          

            btn_write.Enabled = false;
            textBox1.Enabled = false;
           
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {

                port.Write("(CLEAR,)\n");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("(LINE1," + textBox1.Text + ")\n");
                port.Write("(LINE2," + textBox2.Text + ")\n");
            }
        }
    }//End of Class
}//End of name space
