namespace Serial溝通
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.p_top = new System.Windows.Forms.Panel();
            this.lb_header_title = new System.Windows.Forms.Label();
            this.b_header_cloase = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.p_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // p_top
            // 
            this.p_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_top.Controls.Add(this.lb_header_title);
            this.p_top.Controls.Add(this.b_header_cloase);
            this.p_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top.ForeColor = System.Drawing.Color.Silver;
            this.p_top.Location = new System.Drawing.Point(0, 0);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(798, 28);
            this.p_top.TabIndex = 5;
            this.p_top.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseDoubleClick);
            this.p_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseDown);
            this.p_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseMove);
            this.p_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_top_MouseUp);
            // 
            // lb_header_title
            // 
            this.lb_header_title.AutoSize = true;
            this.lb_header_title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_header_title.ForeColor = System.Drawing.Color.Silver;
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
            this.b_header_cloase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_header_cloase.FlatAppearance.BorderSize = 0;
            this.b_header_cloase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_header_cloase.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.b_header_cloase.ForeColor = System.Drawing.Color.Silver;
            this.b_header_cloase.Location = new System.Drawing.Point(771, -3);
            this.b_header_cloase.Name = "b_header_cloase";
            this.b_header_cloase.Size = new System.Drawing.Size(30, 30);
            this.b_header_cloase.TabIndex = 2;
            this.b_header_cloase.Text = "x";
            this.b_header_cloase.UseVisualStyleBackColor = true;
            this.b_header_cloase.Click += new System.EventHandler(this.b_header_cloase_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 34);
            this.chart1.Name = "chart1";
            series2.BorderColor = System.Drawing.Color.Yellow;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Yellow;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star4;
            series2.Name = "name";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(774, 433);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(798, 479);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.p_top);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChartForm";
            this.Text = "ChartForm";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            this.p_top.ResumeLayout(false);
            this.p_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.Label lb_header_title;
        private System.Windows.Forms.Button b_header_cloase;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}