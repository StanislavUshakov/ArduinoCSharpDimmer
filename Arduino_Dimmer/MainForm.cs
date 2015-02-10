using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Dimmer
{
    public partial class MainForm : Form
    {
        private enum ArduinoStatus
        {
            Connected,
            Connecting,
            Disconnected
        }

        private SerialPort _arduinoPort;
        private ArduinoStatus _status;

        public MainForm()
        {
            InitializeComponent();
            cbAvailablePorts.Items.AddRange(SerialPort.GetPortNames());
            cbAvailablePorts.SelectedIndex = 0;
            _status = ArduinoStatus.Disconnected;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            _status = ArduinoStatus.Connecting;
            UpdateFormByStatus();
            _arduinoPort = new SerialPort(cbAvailablePorts.SelectedItem.ToString());
            try
            {
                _arduinoPort.Open();
                _status = ArduinoStatus.Connected;
                UpdateFormByStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lbStatus.Text = "Status: Error";
            }
        }

        private void tbBrightness_ValueChanged(object sender, EventArgs e)
        {
            if (_status == ArduinoStatus.Connected)
            {
                byte[] buffer = new byte[1];
                buffer[0] = (byte)tbBrightness.Value;
                _arduinoPort.Write(buffer, 0, 1);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _arduinoPort.Close();
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                _arduinoPort.Close();
                _status = ArduinoStatus.Disconnected;
                UpdateFormByStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lbStatus.Text = "Status: Error";
            }
        }

        private void UpdateFormByStatus()
        {
            switch (_status)
            {
                case ArduinoStatus.Connected:
                    lbStatus.Text = "Status: Successfully connected";
                    btConnect.Enabled = false;
                    btDisconnect.Enabled = true;
                    tbBrightness.Enabled = true;
                    break;

                case ArduinoStatus.Connecting:
                    lbStatus.Text = "Status: Connecting";
                    break;

                case ArduinoStatus.Disconnected:
                    lbStatus.Text = "Status: Disconnected";
                    btConnect.Enabled = true;
                    btDisconnect.Enabled = false;
                    tbBrightness.Enabled = false;
                    break;
            }
        }
    }
}
