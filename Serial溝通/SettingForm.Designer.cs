namespace Serial溝通
{
    partial class SettingForm
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
            this.p_top = new System.Windows.Forms.Panel();
            this.lb_header_title = new System.Windows.Forms.Label();
            this.b_header_cloase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_endMsg = new System.Windows.Forms.CheckBox();
            this.cb_startMsg = new System.Windows.Forms.CheckBox();
            this.tb_endMsg = new System.Windows.Forms.TextBox();
            this.tb_startMsg = new System.Windows.Forms.TextBox();
            this.tb_totalPackage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.p_top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_top
            // 
            this.p_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_top.Controls.Add(this.lb_header_title);
            this.p_top.Controls.Add(this.b_header_cloase);
            this.p_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top.Location = new System.Drawing.Point(0, 0);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(600, 28);
            this.p_top.TabIndex = 2;
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
            this.lb_header_title.Size = new System.Drawing.Size(42, 22);
            this.lb_header_title.TabIndex = 0;
            this.lb_header_title.Text = "設定";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "總共幾行為一包封包 :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_endMsg);
            this.panel1.Controls.Add(this.cb_startMsg);
            this.panel1.Controls.Add(this.tb_endMsg);
            this.panel1.Controls.Add(this.tb_startMsg);
            this.panel1.Controls.Add(this.tb_totalPackage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 161);
            this.panel1.TabIndex = 0;
            // 
            // cb_endMsg
            // 
            this.cb_endMsg.AutoSize = true;
            this.cb_endMsg.Checked = true;
            this.cb_endMsg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_endMsg.Location = new System.Drawing.Point(59, 99);
            this.cb_endMsg.Name = "cb_endMsg";
            this.cb_endMsg.Size = new System.Drawing.Size(118, 25);
            this.cb_endMsg.TabIndex = 5;
            this.cb_endMsg.Text = "結束訊息為 :";
            this.cb_endMsg.UseVisualStyleBackColor = true;
            this.cb_endMsg.CheckedChanged += new System.EventHandler(this.cb_endMsg_CheckedChanged);
            // 
            // cb_startMsg
            // 
            this.cb_startMsg.AutoSize = true;
            this.cb_startMsg.Checked = true;
            this.cb_startMsg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_startMsg.Location = new System.Drawing.Point(59, 59);
            this.cb_startMsg.Name = "cb_startMsg";
            this.cb_startMsg.Size = new System.Drawing.Size(118, 25);
            this.cb_startMsg.TabIndex = 3;
            this.cb_startMsg.Text = "起始訊息為 :";
            this.cb_startMsg.UseVisualStyleBackColor = true;
            this.cb_startMsg.CheckedChanged += new System.EventHandler(this.cb_startMsg_CheckedChanged);
            // 
            // tb_endMsg
            // 
            this.tb_endMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tb_endMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_endMsg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_endMsg.ForeColor = System.Drawing.Color.Orange;
            this.tb_endMsg.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_endMsg.Location = new System.Drawing.Point(183, 102);
            this.tb_endMsg.MaxLength = 10;
            this.tb_endMsg.Name = "tb_endMsg";
            this.tb_endMsg.Size = new System.Drawing.Size(246, 22);
            this.tb_endMsg.TabIndex = 6;
            this.tb_endMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_endMsg.TextChanged += new System.EventHandler(this.tb_endMsg_TextChanged);
            // 
            // tb_startMsg
            // 
            this.tb_startMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tb_startMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_startMsg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_startMsg.ForeColor = System.Drawing.Color.Orange;
            this.tb_startMsg.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_startMsg.Location = new System.Drawing.Point(183, 60);
            this.tb_startMsg.MaxLength = 10;
            this.tb_startMsg.Name = "tb_startMsg";
            this.tb_startMsg.Size = new System.Drawing.Size(246, 22);
            this.tb_startMsg.TabIndex = 4;
            this.tb_startMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_startMsg.TextChanged += new System.EventHandler(this.tb_startMsg_TextChanged);
            // 
            // tb_totalPackage
            // 
            this.tb_totalPackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tb_totalPackage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_totalPackage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_totalPackage.ForeColor = System.Drawing.Color.Orange;
            this.tb_totalPackage.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_totalPackage.Location = new System.Drawing.Point(183, 16);
            this.tb_totalPackage.MaxLength = 1;
            this.tb_totalPackage.Name = "tb_totalPackage";
            this.tb_totalPackage.Size = new System.Drawing.Size(75, 22);
            this.tb_totalPackage.TabIndex = 1;
            this.tb_totalPackage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_totalPackage.TextChanged += new System.EventHandler(this.aTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "(包含起始結束)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "封包格式";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 272);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(576, 356);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "資料格式";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(196, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(309, 643);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.b_header_cloase_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(600, 695);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p_top);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.p_top.ResumeLayout(false);
            this.p_top.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.Label lb_header_title;
        private System.Windows.Forms.Button b_header_cloase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_endMsg;
        private System.Windows.Forms.CheckBox cb_startMsg;
        private System.Windows.Forms.TextBox tb_endMsg;
        private System.Windows.Forms.TextBox tb_startMsg;
        private System.Windows.Forms.TextBox tb_totalPackage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}