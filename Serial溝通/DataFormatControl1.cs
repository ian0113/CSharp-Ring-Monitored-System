using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Serial溝通
{
    public partial class DataFormatControl1 : UserControl
    {
        public SettingDetail _settingDetail;

        string type;

        int _num;

        public DataFormatControl1(SettingDetail settingDetail)
        {
            InitializeComponent();
            _settingDetail = settingDetail;
            _num = _settingDetail._num;
        }

        public DataFormatControl1(int num, SettingDetail settingDetail)
        {
            InitializeComponent();
            _settingDetail = settingDetail;
            _num = num;
        }

        private void DataFormatControl1_Load(object sender, EventArgs e)
        {
            if (_settingDetail._num != 0)
            {
                tb_dataName.Text = _settingDetail.name;
                type = _settingDetail.type;

                rb_string.Checked = _settingDetail.type == "string";
                rb_int.Checked = _settingDetail.type == "int";
                rb_float.Checked = _settingDetail.type == "float";

                cb_bigger.Checked = _settingDetail.isMustBigger;
                tb_bigger.Text = _settingDetail.mustBigger;
                cb_bigger_del.Checked = _settingDetail.isMustBiggerAndDelete;

                cb_smaller.Checked = _settingDetail.isMustSmaller;
                tb_smaller.Text = _settingDetail.mustSmaller;
                cb_smaller_del.Checked = _settingDetail.isMustSmallerAndDelete;

                cb_whenBigger.Checked = _settingDetail.isWhenBigger;
                tb_whenBigger.Text = _settingDetail.whenBigger;
                tb_whenBiggerThen.Text = _settingDetail.whenBiggerThenSend;

                cb_whenSmaller.Checked = _settingDetail.isWhenSmaller;
                tb_whenSmaller.Text = _settingDetail.whenSmaller;
                tb_whenSmallerThen.Text = _settingDetail.whenSmallerThenSend;

                cb_whenEqual.Checked = _settingDetail.isWhenEqual;
                tb_whenEqual.Text = _settingDetail.whenEqual;
                tb_whenEqualThen.Text = _settingDetail.whenEqualThenSend;
            }
            else
            {
                _settingDetail._num = _num;
                rb_float.Checked = true;
                _settingDetail.mustBigger = tb_bigger.Text = "-1";
                cb_bigger.Checked = true;
            }
            lb_packageCount.Text = "訊息" + _num.ToString();
        }

        private void aCheckedChanged(object sender, EventArgs e)
        {
            if (rb_string.Checked)
            {
                p_detail.Enabled = false;
                _settingDetail.type=type = rb_string.Text;
            }
            else if (rb_int.Checked)
            {
                p_detail.Enabled = true;
                _settingDetail.type=type = rb_int.Text;
            }
            else if (rb_float.Checked)
            {
                p_detail.Enabled = true;
                _settingDetail.type=type = rb_float.Text;
            }
        }

        private void cb_bigger_CheckedChanged(object sender, EventArgs e)
        {
            _settingDetail.isMustBigger = cb_bigger_del.Enabled = cb_bigger.Checked;
            if (!cb_bigger.Checked)
            {
                cb_bigger_del.Checked = false;
                _settingDetail.mustBigger = tb_bigger.Text = "";
            }
        }

        private void cb_smaller_CheckedChanged(object sender, EventArgs e)
        {
            _settingDetail.isMustSmaller = cb_smaller_del.Enabled = cb_smaller.Checked;
            if (!cb_smaller.Checked)
            {
                cb_smaller_del.Checked = false;
                _settingDetail.mustSmaller=tb_smaller.Text = "";
            }
        }

        private void cb_whenBigger_CheckedChanged(object sender, EventArgs e)
        {
            _settingDetail.isWhenBigger = tb_whenBiggerThen.Enabled = cb_whenBigger.Checked;
            if (!cb_whenBigger.Checked)
            {
                _settingDetail.whenBigger = tb_whenBiggerThen.Text = tb_whenBigger.Text = "";
            }
        }

        private void cb_whenSmaller_CheckedChanged(object sender, EventArgs e)
        {
            _settingDetail.isWhenSmaller = tb_whenSmallerThen.Enabled = cb_whenSmaller.Checked;
            if (!cb_whenSmaller.Checked)
            {
                _settingDetail.whenSmaller = tb_whenSmallerThen.Text = tb_whenSmaller.Text = "";
            }
        }

        private void cb_equal_CheckedChanged(object sender, EventArgs e)
        {
            _settingDetail.isWhenEqual = tb_whenEqualThen.Enabled = cb_whenEqual.Checked;
            if (!cb_whenEqual.Checked)
            {
                _settingDetail.whenEqual = tb_whenEqualThen.Text = tb_whenEqual.Text = "";
            }
        }

        private void cb_bigger_del_CheckedChanged(object sender, EventArgs e)
        {
            _settingDetail.isMustBiggerAndDelete = cb_bigger_del.Checked;
        }

        private void cb_smaller_del_CheckedChanged(object sender, EventArgs e)
        {
            _settingDetail.isMustSmallerAndDelete = cb_smaller_del.Checked;
        }

        private void tb_whenBiggerThen_TextChanged(object sender, EventArgs e)
        {
            _settingDetail.whenBiggerThenSend = tb_whenBiggerThen.Text;
        }

        private void tb_whenSmallerThen_TextChanged(object sender, EventArgs e)
        {
            _settingDetail.whenSmallerThenSend = tb_whenSmallerThen.Text;
        }

        private void tb_whenEqualThen_TextChanged(object sender, EventArgs e)
        {
            _settingDetail.whenEqualThenSend = tb_whenEqualThen.Text;
        }

        private void cb_bigger_Click(object sender, EventArgs e)
        {
            if (cb_bigger.Checked)
            {
                using (SetValueForm svf = new SetValueForm(rb_int.Checked ? 1 : 2))
                {
                    var result = svf.ShowDialog();
                    if (result == DialogResult.OK)
                        _settingDetail.mustBigger = tb_bigger.Text = rb_int.Checked ? ((int)(svf.obj)).ToString() : ((float)(svf.obj)).ToString();
                    else
                        cb_bigger.Checked = false;
                }
            }
        }

        private void cb_smaller_Click(object sender, EventArgs e)
        {
            if (cb_smaller.Checked)
            {
                using (SetValueForm svf = new SetValueForm(rb_int.Checked ? 1 : 2))
                {
                    var result = svf.ShowDialog();
                    if (result == DialogResult.OK)
                        _settingDetail.mustSmaller = tb_smaller.Text = rb_int.Checked ? ((int)(svf.obj)).ToString() : ((float)(svf.obj)).ToString();
                    else
                        cb_smaller.Checked = false;
                }
            }
        }

        private void cb_whenBigger_Click(object sender, EventArgs e)
        {
            if (cb_whenBigger.Checked)
            {
                using (SetValueForm svf = new SetValueForm(rb_int.Checked ? 1 : 2))
                {
                    var result = svf.ShowDialog();
                    if (result == DialogResult.OK)
                        _settingDetail.whenBigger = tb_whenBigger.Text = rb_int.Checked ? ((int)(svf.obj)).ToString() : ((float)(svf.obj)).ToString();
                    else
                        cb_whenBigger.Checked = false;
                }
            }
        }

        private void cb_whenSmaller_Click(object sender, EventArgs e)
        {
            if (cb_whenSmaller.Checked)
            {
                using (SetValueForm svf = new SetValueForm(rb_int.Checked ? 1 : 2))
                {
                    var result = svf.ShowDialog();
                    if (result == DialogResult.OK)
                        _settingDetail.whenSmaller = tb_whenSmaller.Text = rb_int.Checked ? ((int)(svf.obj)).ToString() : ((float)(svf.obj)).ToString();
                    else
                        cb_whenSmaller.Checked = false;
                }
            }
        }

        private void cb_whenEqual_Click(object sender, EventArgs e)
        {
            if (cb_whenEqual.Checked)
            {
                using (SetValueForm svf = new SetValueForm(rb_int.Checked ? 1 : 2))
                {
                    var result = svf.ShowDialog();
                    if (result == DialogResult.OK)
                        _settingDetail.whenEqual = tb_whenEqual.Text = rb_int.Checked ? ((int)(svf.obj)).ToString() : ((float)(svf.obj)).ToString();
                    else
                        cb_whenEqual.Checked = false;
                }
            }
        }

        private void aClick(object sender, EventArgs e)
        {
            _settingDetail.mustBigger = _settingDetail.mustSmaller = _settingDetail.whenBigger = _settingDetail.whenBiggerThenSend = _settingDetail.whenSmaller = _settingDetail.whenSmallerThenSend =
                _settingDetail.whenEqual = _settingDetail.whenEqualThenSend = tb_whenEqual.Text = tb_whenSmaller.Text = tb_whenBigger.Text = tb_smaller.Text = tb_bigger.Text = tb_whenBiggerThen.Text = tb_whenSmallerThen.Text = tb_whenEqualThen.Text = "";

            cb_whenEqual.Checked = cb_smaller_del.Checked = cb_bigger_del.Checked = cb_whenSmaller.Checked = cb_whenBigger.Checked = cb_smaller.Checked = cb_bigger.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _settingDetail.name = tb_dataName.Text;
        }
    }
}
