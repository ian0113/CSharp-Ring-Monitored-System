using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Text;


namespace Serial溝通
{
    public partial class Form2 : Form
    {
        int _lastMouseX, _lastMouseY;
        bool _isMov = false;
        string _serialPortName;
        bool _isGetStartMsg = false;
        int _readPointer = 0;
        SerialPortConnection _serialPortConnection;
        SerialPortPackageFormatcs _serialPortPackageFormat;
        List<ChartForm> _chartForms = new List<ChartForm>();

        public Form2(string serialPortName, SerialPortPackageFormatcs serialPortPackageFormat)
        {
            InitializeComponent();
            _serialPortName = serialPortName;
            _serialPortPackageFormat = serialPortPackageFormat;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _serialPortConnection = new SerialPortConnection(_serialPortName);
            this.Text = lb_comport.Text = _serialPortName;
            if (!_serialPortConnection.Connect()) this.Dispose();
            else t_update_msg.Enabled = true;

            for (int i = 0; i < _serialPortPackageFormat._settingDetails.Count; i++)
            {
                string type = _serialPortPackageFormat._settingDetails[i].type;
                string name = _serialPortPackageFormat._settingDetails[i].name == "" ? (i + 1).ToString() : _serialPortPackageFormat._settingDetails[i].name;
                _chartForms.Add(null);
                Button b = new Button();
                b.Name = (i + 1).ToString();
                b.Text = name;
                b.FlatStyle = FlatStyle.Flat;
                b.Width = 70;
                b.Height = 40;
                b.Click += new System.EventHandler(other_Click);
                fp_other.Controls.Add(b);
            }
        }

        private void other_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int index = int.Parse(b.Name) - 1;
            string type = _serialPortPackageFormat._settingDetails[index].type;
            if (_chartForms[index] == null) _chartForms[index] = new ChartForm(b.Text, type);
            else if (_chartForms[index].IsDisposed) _chartForms[index] = new ChartForm(b.Text, type);
            _chartForms[index].Show();
        }

        private void rt_content_TextChanged(object sender, EventArgs e)
        {
            if (cb_islast.Checked)
            {
                ((RichTextBox)sender).SelectionStart = ((RichTextBox)sender).TextLength - 1;
                ((RichTextBox)sender).ScrollToCaret();
            }
        }

        private void tb_inp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && tb_inp.Text != "")
            {
                rt_content.AppendText("    User:" + tb_inp.Text + "\n");
                _serialPortConnection.Write(tb_inp.Text);
                tb_inp.Text = "";
            }
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            if (tb_inp.Text != "")
            {
                rt_content.AppendText("    User:" + tb_inp.Text + "\n");
                _serialPortConnection.Write(tb_inp.Text);
                tb_inp.Text = "";
            }
        }

        private void t_update_msg_Tick(object sender, EventArgs e)
        {
            string msg = _serialPortConnection.Read();
            if (msg != "")
            {
                if (_serialPortPackageFormat._isSetEndMsg)
                {
                    if (msg == _serialPortPackageFormat._endMsg)
                    {
                        rt_content.AppendText("Arduino->" + msg + "-----EndMsg");
                        _readPointer = 0;
                        _isGetStartMsg = false;
                    }
                }
                if (_isGetStartMsg)
                {
                    if (_readPointer < _serialPortPackageFormat._settingDetails.Count)
                    {
                        var item = _serialPortPackageFormat._settingDetails[_readPointer];
                        string type = item.type;
                        string name = item.name;
                        rt_content.AppendText("Arduino->" + msg + "-----" + name + "(" + type + ")");
                        if (type == "int")
                        {
                            if (int.TryParse(msg, out int result))
                            {
                                if (item.isMustBigger)
                                {
                                    bool isWrite = true;
                                    if (item.isMustBiggerAndDelete)
                                    {
                                        // 不寫入
                                        isWrite = false;
                                    }
                                    if (isWrite & result > int.Parse(item.mustBigger))
                                    {
                                        try
                                        {
                                            if (_chartForms[_readPointer].Created)
                                            {
                                                _chartForms[_readPointer]._queue.Enqueue(msg);
                                            }
                                        }
                                        catch (System.NullReferenceException)
                                        {
                                        }
                                    }
                                }
                                if (item.isMustSmaller)
                                {
                                    bool isWrite = true;
                                    if (item.isMustSmallerAndDelete)
                                    {
                                        // 不寫入
                                        isWrite = false;
                                    }
                                    if (isWrite & result < int.Parse(item.mustSmaller))
                                    {
                                        // 寫入
                                        try
                                        {
                                            if (_chartForms[_readPointer].Created)
                                            {
                                                _chartForms[_readPointer]._queue.Enqueue(msg);
                                            }
                                        }
                                        catch (System.NullReferenceException)
                                        {
                                        }
                                    }
                                }
                                if (item.isWhenBigger)
                                {
                                    if (result > int.Parse(item.whenBigger))
                                    {
                                        _serialPortConnection.Write(item.whenBiggerThenSend);
                                    }
                                }
                                if (item.isWhenSmaller)
                                {
                                    if (result < int.Parse(item.whenSmaller))
                                    {
                                        _serialPortConnection.Write(item.whenSmallerThenSend);
                                    }
                                }
                                if (item.isWhenEqual)
                                {
                                    if (result == int.Parse(item.whenEqual))
                                    {
                                        _serialPortConnection.Write(item.whenEqualThenSend);
                                    }
                                }
                            }
                        }
                        else if (type == "float")
                        {
                            if (float.TryParse(msg, out float result))
                            {
                                if (item.isMustBigger)
                                {
                                    bool isWrite = true;
                                    if (item.isMustBiggerAndDelete)
                                    {
                                        // 不寫入
                                        isWrite = false;
                                    }
                                    if (isWrite & result > float.Parse(item.mustBigger))
                                    {
                                        // 寫入
                                        try
                                        {
                                            if (_chartForms[_readPointer].Created)
                                            {
                                                _chartForms[_readPointer]._queue.Enqueue(msg);
                                            }
                                        }
                                        catch (System.NullReferenceException)
                                        {
                                        }
                                    }
                                }
                                if (item.isMustSmaller)
                                {
                                    bool isWrite = true;
                                    if (item.isMustSmallerAndDelete)
                                    {
                                        // 不寫入
                                        isWrite = false;
                                    }
                                    if (isWrite & result < float.Parse(item.mustSmaller))
                                    {
                                        // 寫入
                                        try
                                        {
                                            if (_chartForms[_readPointer].Created)
                                            {
                                                _chartForms[_readPointer]._queue.Enqueue(msg);
                                            }
                                        }
                                        catch (System.NullReferenceException)
                                        {
                                        }
                                    }
                                }
                                if (item.isWhenBigger)
                                {
                                    if (result > float.Parse(item.whenBigger))
                                    {
                                        _serialPortConnection.Write(item.whenBiggerThenSend);
                                    }
                                }
                                if (item.isWhenSmaller)
                                {
                                    if (result < float.Parse(item.whenSmaller))
                                    {
                                        _serialPortConnection.Write(item.whenSmallerThenSend);
                                    }
                                }
                                if (item.isWhenEqual)
                                {
                                    if (result == float.Parse(item.whenEqual))
                                    {
                                        _serialPortConnection.Write(item.whenEqualThenSend);
                                    }
                                }
                            }
                        }
                        else
                        {

                        }
                    }
                    if (_serialPortPackageFormat._settingDetails.Count != 0)
                    {
                        _readPointer = (_readPointer + 1) % _serialPortPackageFormat._settingDetails.Count;
                    }
                    if (_readPointer == 0)
                        _isGetStartMsg = false;
                }
                if (_serialPortPackageFormat._isSetStartMsg)
                {
                    if (msg == _serialPortPackageFormat._startMsg)
                    {
                        rt_content.AppendText("Arduino->" + msg + "-----StartMsg");
                        _readPointer = 0;
                        _isGetStartMsg = true;
                    }
                }
                else
                {
                    rt_content.AppendText("Arduino->" + msg);
                }
                rt_content.AppendText("\n");
            }
        }

        private void b_header_cloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _serialPortConnection.DisConnect();
                foreach (var item in _chartForms)
                {
                    if (item != null)
                    {
                        if (!item.IsDisposed)
                        {
                            item.Dispose();
                        }
                    }
                }
            }
            catch (System.IO.IOException)
            {

            }
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

    }
}
