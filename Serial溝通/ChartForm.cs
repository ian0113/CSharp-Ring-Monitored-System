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
    public partial class ChartForm : Form
    {
        int _lastMouseX, _lastMouseY;
        bool _isMov = false;
        bool _isMax = false;
        string _name;
        string _type;
        int _count=20;
        public Queue<string> _queue;
        private List<double> data;

        public ChartForm(string name,string type)
        {
            InitializeComponent();
            _name = name;
            _type = type;
        }
        private void b_header_cloase_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_queue.Count>0)
            {
                double value = 999999.999999;

                string s = null;
                s = _queue.Dequeue();
                if (_type == "int" | _type == "float")
                    value = double.Parse(s);
                if (value != 999999.999999)
                    updateData(value);
                chart1.Series[0].Points.ResumeUpdates();
                chart1.Series[0].Points.Clear();
                for (int i = 0; i < data.Count; i++)
                {
                    chart1.Series[0].Points.AddXY((double)i, data[i]);
                }
                chart1.Series[0].Points.ResumeUpdates();
            }
        }
        private void ChartForm_Load(object sender, EventArgs e)
        {
            _queue = new Queue<string>();
            data = new List<double>();
            timer1.Enabled = true;
            chart1.Series[0].Name = _name + "(" + _type + ")";
            chart1.Series[0].Points.Clear();
        }

        private void p_top_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_isMax)
            {
                this.WindowState = FormWindowState.Normal;
                _isMax = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                _isMax = true;
            }
        }

        private void updateData(double value)
        {
            if (data.Count == _count)
                data.RemoveAt(0);
            data.Add(value);
        }
    }
}
