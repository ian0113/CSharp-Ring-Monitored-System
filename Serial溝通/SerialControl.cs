using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Serial溝通
{
    public partial class SerialControl : UserControl
    {

        public string SerailPortName
        {
            get
            {
                return _serialPortName;
            }
        }
        string _serialPortName;
        Form2 _connectWindow = null;
        SettingForm _settingForm = null;
        SerialPortPackageFormatcs _serialPortPackageFormat = new SerialPortPackageFormatcs();


        public SerialControl(string serialPortName)
        {
            InitializeComponent();
            _serialPortName = serialPortName;
        }

        private void SerialControl_Load(object sender, EventArgs e)
        {
            lb_serialPort.Text = _serialPortName;
        }

        private void SerialControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(this.BackColor.R + 10, this.BackColor.G + 10, this.BackColor.B + 10);
        }
        private void SerialControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(this.BackColor.R - 10, this.BackColor.G - 10, this.BackColor.B - 10);
        }
        private void SerialControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_settingForm != null)
                if (_settingForm.Created)
                    _settingForm.Close();
            if (_connectWindow == null) _connectWindow = new Form2(_serialPortName, _serialPortPackageFormat);
            else if (_connectWindow.IsDisposed) _connectWindow = new Form2(_serialPortName, _serialPortPackageFormat);

            _connectWindow.Show();
        }
        private void btn_setting_Click(object sender, EventArgs e)
        {
            if (_connectWindow != null)
                if (_connectWindow.Created)
                    _connectWindow.Close();
            if (_settingForm == null) _settingForm = new SettingForm(_serialPortPackageFormat);
            else if (_settingForm.IsDisposed) _settingForm = new SettingForm(_serialPortPackageFormat);
            _settingForm.Show();
        }
    }
}
