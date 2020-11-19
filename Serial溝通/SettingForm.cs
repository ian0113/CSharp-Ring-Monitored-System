using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Serial溝通
{
    public partial class SettingForm : Form
    {
        int _lastMouseX, _lastMouseY;
        bool _isMov = false;
        SerialPortPackageFormatcs _serialPortPackageFormat;


        public SettingForm(SerialPortPackageFormatcs serialPortPackageFormat)
        {
            InitializeComponent();
            _serialPortPackageFormat = serialPortPackageFormat;
        }
        private void SettingForm_Load(object sender, EventArgs e)
        {
            tb_totalPackage.Text = _serialPortPackageFormat._package.ToString();
            tb_startMsg.Text = _serialPortPackageFormat._startMsg;
            tb_endMsg.Text = _serialPortPackageFormat._endMsg;
            cb_startMsg.Checked = _serialPortPackageFormat._isSetStartMsg;
            cb_endMsg.Checked = _serialPortPackageFormat._isSetEndMsg;
            if (_serialPortPackageFormat._settingDetails.Count == (_serialPortPackageFormat._package - ((_serialPortPackageFormat._isSetStartMsg ? 1 : 0) + (_serialPortPackageFormat._isSetEndMsg ? 1 : 0))) & _serialPortPackageFormat._settingDetails.Count != 0)
            {
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Update();
                foreach (var item in _serialPortPackageFormat._settingDetails)
                {
                    DataFormatControl1 dfc = new DataFormatControl1(item);
                    flowLayoutPanel1.Controls.Add(dfc);
                    flowLayoutPanel1.Update();
                }
            }
        }

        private void b_header_cloase_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //Environment.Exit(Environment.ExitCode);
            //Application.Exit();
        }
        private void p_top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isMov = true;
                _lastMouseX = e.X;
                _lastMouseY = e.Y;
            }
        }
        private void p_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMov)
                this.Location = new Point(this.Left + e.X - this._lastMouseX, this.Top + e.Y - this._lastMouseY);
        }
        private void p_top_MouseUp(object sender, MouseEventArgs e)
        {
            _isMov = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _serialPortPackageFormat._settingDetails = new List<SettingDetail>();
            foreach (var item in flowLayoutPanel1.Controls)
            {
                _serialPortPackageFormat._settingDetails.Add(((DataFormatControl1)item)._settingDetail);
            }
            this.Dispose();
        }

        private void tb_startMsg_TextChanged(object sender, EventArgs e)
        {
            _serialPortPackageFormat._startMsg = tb_startMsg.Text;
        }

        private void tb_endMsg_TextChanged(object sender, EventArgs e)
        {
            _serialPortPackageFormat._endMsg = tb_endMsg.Text;
        }

        private void cb_startMsg_CheckedChanged(object sender, EventArgs e)
        {
            _serialPortPackageFormat._isSetStartMsg = tb_startMsg.Enabled = cb_startMsg.Checked;
            if (cb_startMsg.Checked)
                _serialPortPackageFormat._startMsg = tb_startMsg.Text;
            else
                tb_startMsg.Text = _serialPortPackageFormat._startMsg = "";
            aTextChanged(sender, e);
        }

        private void cb_endMsg_CheckedChanged(object sender, EventArgs e)
        {
            _serialPortPackageFormat._isSetEndMsg = tb_endMsg.Enabled = cb_endMsg.Checked;
            if (cb_endMsg.Checked)
                _serialPortPackageFormat._endMsg = tb_endMsg.Text;
            else
                tb_endMsg.Text = _serialPortPackageFormat._endMsg = "";
            aTextChanged(sender, e);
        }

        private void aTextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tb_totalPackage.Text, out int result))
            {
                _serialPortPackageFormat._package = result;
                if (cb_startMsg.Checked)
                    result -= 1;
                if (cb_endMsg.Checked)
                    result -= 1;
                if (_serialPortPackageFormat._settingDetails.Count != (_serialPortPackageFormat._package - ((_serialPortPackageFormat._isSetStartMsg ? 1 : 0) + (_serialPortPackageFormat._isSetEndMsg ? 1 : 0))))
                {
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Update();
                    _serialPortPackageFormat._settingDetails = new List<SettingDetail>();
                    for (int i = 1; i <= result; i++)
                    {
                        DataFormatControl1 dfc = new DataFormatControl1(i,new SettingDetail());
                        flowLayoutPanel1.Controls.Add(dfc);
                        flowLayoutPanel1.Update();
                    }
                }
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Update();
                    foreach (var item in _serialPortPackageFormat._settingDetails)
                    {
                        DataFormatControl1 dfc = new DataFormatControl1(item);
                        flowLayoutPanel1.Controls.Add(dfc);
                        flowLayoutPanel1.Update();
                    }
                }
            }
            else tb_totalPackage.Text = "";
        }

    }
}
