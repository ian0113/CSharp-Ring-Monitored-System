namespace Serial溝通
{
    partial class SerialControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_serialPort = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_setting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_serialPort
            // 
            this.lb_serialPort.AutoSize = true;
            this.lb_serialPort.Location = new System.Drawing.Point(22, 14);
            this.lb_serialPort.Name = "lb_serialPort";
            this.lb_serialPort.Size = new System.Drawing.Size(69, 27);
            this.lb_serialPort.TabIndex = 0;
            this.lb_serialPort.Text = "label1";
            this.lb_serialPort.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SerialControl_MouseDoubleClick);
            this.lb_serialPort.MouseEnter += new System.EventHandler(this.SerialControl_MouseEnter);
            this.lb_serialPort.MouseLeave += new System.EventHandler(this.SerialControl_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(23, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 1;
            // 
            // btn_setting
            // 
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_setting.Location = new System.Drawing.Point(261, 12);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(54, 30);
            this.btn_setting.TabIndex = 2;
            this.btn_setting.Text = "設定";
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // SerialControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_serialPort);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SerialControl";
            this.Size = new System.Drawing.Size(350, 50);
            this.Load += new System.EventHandler(this.SerialControl_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SerialControl_MouseDoubleClick);
            this.MouseEnter += new System.EventHandler(this.SerialControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SerialControl_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_serialPort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_setting;
    }
}
