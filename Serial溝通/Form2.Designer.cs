namespace Serial溝通
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.p_top = new System.Windows.Forms.Panel();
            this.lb_header_title = new System.Windows.Forms.Label();
            this.b_header_cloase = new System.Windows.Forms.Button();
            this.lb_comport = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.fp_other = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_islast = new System.Windows.Forms.CheckBox();
            this.rt_content = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_inp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_update_msg = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.p_top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_top
            // 
            this.p_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_top.Controls.Add(this.lb_header_title);
            this.p_top.Controls.Add(this.b_header_cloase);
            this.p_top.Controls.Add(this.lb_comport);
            this.p_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top.Location = new System.Drawing.Point(0, 0);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(600, 28);
            this.p_top.TabIndex = 4;
            this.p_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseDown);
            this.p_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseMove);
            this.p_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseUp);
            // 
            // lb_header_title
            // 
            this.lb_header_title.AutoSize = true;
            this.lb_header_title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_header_title.Location = new System.Drawing.Point(3, 2);
            this.lb_header_title.Name = "lb_header_title";
            this.lb_header_title.Size = new System.Drawing.Size(138, 22);
            this.lb_header_title.TabIndex = 0;
            this.lb_header_title.Text = "串列埠與硬體溝通";
            this.lb_header_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseDown);
            this.lb_header_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseMove);
            this.lb_header_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseUp);
            // 
            // b_header_cloase
            // 
            this.b_header_cloase.FlatAppearance.BorderSize = 0;
            this.b_header_cloase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_header_cloase.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.b_header_cloase.Location = new System.Drawing.Point(572, -2);
            this.b_header_cloase.Name = "b_header_cloase";
            this.b_header_cloase.Size = new System.Drawing.Size(30, 30);
            this.b_header_cloase.TabIndex = 2;
            this.b_header_cloase.Text = "x";
            this.b_header_cloase.UseVisualStyleBackColor = true;
            this.b_header_cloase.Click += new System.EventHandler(this.b_header_cloase_Click);
            // 
            // lb_comport
            // 
            this.lb_comport.AutoSize = true;
            this.lb_comport.Location = new System.Drawing.Point(147, 3);
            this.lb_comport.Name = "lb_comport";
            this.lb_comport.Size = new System.Drawing.Size(55, 21);
            this.lb_comport.TabIndex = 10;
            this.lb_comport.Text = "label1";
            this.lb_comport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseDown);
            this.lb_comport.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseMove);
            this.lb_comport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseUp);
            // 
            // btn_send
            // 
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_send.Location = new System.Drawing.Point(514, 42);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(74, 33);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "傳送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // fp_other
            // 
            this.fp_other.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fp_other.Location = new System.Drawing.Point(12, 393);
            this.fp_other.Name = "fp_other";
            this.fp_other.Padding = new System.Windows.Forms.Padding(5);
            this.fp_other.Size = new System.Drawing.Size(576, 119);
            this.fp_other.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_islast);
            this.panel1.Controls.Add(this.rt_content);
            this.panel1.Location = new System.Drawing.Point(12, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 235);
            this.panel1.TabIndex = 11;
            // 
            // cb_islast
            // 
            this.cb_islast.AutoSize = true;
            this.cb_islast.Checked = true;
            this.cb_islast.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_islast.Location = new System.Drawing.Point(481, 3);
            this.cb_islast.Name = "cb_islast";
            this.cb_islast.Size = new System.Drawing.Size(93, 25);
            this.cb_islast.TabIndex = 1;
            this.cb_islast.Text = "是否捲動";
            this.cb_islast.UseVisualStyleBackColor = true;
            // 
            // rt_content
            // 
            this.rt_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.rt_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rt_content.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rt_content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rt_content.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rt_content.ForeColor = System.Drawing.Color.White;
            this.rt_content.Location = new System.Drawing.Point(0, 34);
            this.rt_content.Name = "rt_content";
            this.rt_content.ReadOnly = true;
            this.rt_content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rt_content.Size = new System.Drawing.Size(574, 199);
            this.rt_content.TabIndex = 0;
            this.rt_content.TabStop = false;
            this.rt_content.Text = "";
            this.rt_content.TextChanged += new System.EventHandler(this.rt_content_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "訊息";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tb_inp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 32);
            this.panel2.TabIndex = 12;
            // 
            // tb_inp
            // 
            this.tb_inp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.tb_inp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_inp.ForeColor = System.Drawing.Color.White;
            this.tb_inp.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_inp.Location = new System.Drawing.Point(97, 4);
            this.tb_inp.Name = "tb_inp";
            this.tb_inp.Size = new System.Drawing.Size(391, 22);
            this.tb_inp.TabIndex = 1;
            this.tb_inp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_inp_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "傳送訊息 : ";
            // 
            // t_update_msg
            // 
            this.t_update_msg.Interval = 10;
            this.t_update_msg.Tick += new System.EventHandler(this.t_update_msg_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "其他功能";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(600, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.fp_other);
            this.Controls.Add(this.p_top);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串列埠與硬體溝通視窗";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.p_top.ResumeLayout(false);
            this.p_top.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.Label lb_header_title;
        private System.Windows.Forms.Button b_header_cloase;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.FlowLayoutPanel fp_other;
        private System.Windows.Forms.Label lb_comport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rt_content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_inp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_islast;
        private System.Windows.Forms.Timer t_update_msg;
        private System.Windows.Forms.Label label3;
    }
}