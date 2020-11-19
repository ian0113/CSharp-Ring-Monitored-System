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
    public partial class SetValueForm : Form
    {
        int _lastMouseX, _lastMouseY;
        bool _isMov = false;
        int _type;
        public object obj
        {
            get => _obj;
        }
        object _obj;
        public SetValueForm(int type)
        {
            InitializeComponent();
            _type = type;
        }
        private void SetValueForm_Load(object sender, EventArgs e)
        {
            if (_type == 1)
            {
                tb_value.MaxLength = 3;
                _obj = new int();
            }
            else if (_type == 2)
            {
                tb_value.MaxLength = 6;
                _obj = new float();
            }
            else
            {
                this.Close();
            }
            tb_value.Focus();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (tb_value.Text != "")
            {
                if (_type == 1)
                {
                    if (int.TryParse(tb_value.Text, out int result))
                    {
                        _obj = result;
                    }
                }
                else if (_type == 2)
                {
                    if (float.TryParse(tb_value.Text, out float result))
                    {
                        _obj = result;
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }
        private void tb_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && tb_value.Text != "")
            {
                if (_type == 1)
                {
                    if (int.TryParse(tb_value.Text, out int result))
                    {
                        _obj = result;
                    }
                }
                else if (_type == 2)
                {
                    if (float.TryParse(tb_value.Text, out float result))
                    {
                        _obj = result;
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void tb_value_TextChanged(object sender, EventArgs e)
        {
            if (tb_value.Text != "")
            {
                if (_type == 1)
                {
                    if (!int.TryParse(tb_value.Text, out int result))
                    {
                        tb_value.Text = "";
                    }
                }
                else if (_type == 2)
                {
                    if (!float.TryParse(tb_value.Text, out float result))
                    {
                        tb_value.Text = "";
                    }
                }
            }
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
        private void b_header_cloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
